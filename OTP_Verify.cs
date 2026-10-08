using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class OTP_Verify : Form
    {
        private int otp;

        public OTP_Verify()
        {
            InitializeComponent();
            InjectSmoothFigmaStyling();

            // Hardcode fallback text description context matching the Figma mockup look
            lblOTPprompt.Text = "       We have sent a 6-digit code to your email. Enter it below.";
            lblNoOTP.Text = "Didn't receive any security code?";
        }

        public OTP_Verify(int otp)
        {
            InitializeComponent();
            InjectSmoothFigmaStyling();

            this.otp = otp;

            lblOTPprompt.Text = "Enter the 6-digit OTP.";
            lblNoOTP.Text = "Didn't receive the code?";
        }

        private void OTPForm4_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        // ==========================================
        // SYSTEM OTP TRANSACTION VALIDATION CHECKS
        // ==========================================
        bool validateOTP()
        {
            if (txtOTP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter the verification code.");
                return false;
            }

            for (int i = 0; i < txtOTP.Text.Length; i++)
            {
                if (!char.IsDigit(txtOTP.Text[i]))
                {
                    MessageBox.Show("Verification code must be digits only.");
                    return false;
                }
            }

            if (txtOTP.Text.Length != 6)
            {
                MessageBox.Show("Verification code must have exactly 6 digits.");
                return false;
            }

            return true;
        }

        public bool IsOTPVerified { get; private set; } = false;

        private void btnVerify_Click(object sender, EventArgs e)
        { 
            if (!validateOTP())
                return;

            if (txtOTP.Text.Trim() == otp.ToString())
            {
                IsOTPVerified = true;

                MessageBox.Show("OTP verified successfully.");

                this.Close();   // Return to requestpasswordForm4
            }
            else
            {
                MessageBox.Show("Incorrect OTP.");

                txtOTP.Clear();
                txtOTP.Focus();
            }
        }
    

        private void btnResendOTP_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            otp = rnd.Next(100000, 999999);

            MessageBox.Show(
                "Demo OTP: " + otp,
                "OTP Resent",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            txtOTP.Clear();
            txtOTP.Focus();
        } 

        private void lblBack_Click(object sender, EventArgs e)
        {
            Password_Reset forgotPasswordForm = new Password_Reset();
            forgotPasswordForm.Show();
            this.Hide();
        }
        // =======================================================
        // UNIFIED SMOOTH FIGMA STYLING OVERRIDES FOR OTP FORM
        // =======================================================
        private void InjectSmoothFigmaStyling()
        {
            // Attach event triggers to the active visual layouts and actions
            if (pnlCard != null)
            {
                pnlCard.Paint += new PaintEventHandler(PaintSmoothFigmaCard);
            }

            if (btnVerify != null)
            {
                btnVerify.Paint += new PaintEventHandler(PaintSmoothFigmaButton);
            }

            if (btnResendOTP != null)
            {
                btnResendOTP.Paint += new PaintEventHandler(PaintSmoothFigmaButton);
            }

            // CHANGED: click events are wired in OTP_Verify.Designer.cs to the real handlers.
            // Do not attach them again here, otherwise one click can run twice.
        }

        private void PaintSmoothFigmaCard(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 16; // Exact Figma 'rounded-2xl' target configuration mapping
            Rectangle borderRect = new Rectangle(0, 0, pnlCard.Width - 1, pnlCard.Height - 1);
            System.Drawing.Drawing2D.GraphicsPath path = GetRoundedRectanglePath(borderRect, radius);

            using (SolidBrush brush = new SolidBrush(Color.White))
            {
                g.FillPath(brush, path);
            }

            using (Pen pen = new Pen(Color.FromArgb(209, 213, 219), 1)) // border-gray-300 lines
            {
                g.DrawPath(pen, path);
            }

            // Draw a vector envelope wireframe representation over the blue block wrapper container manually
            using (Pen whitePen = new Pen(Color.White, 2))
            {
                // Align line placements inside the pnlMailIconWrapper bounds tracking space
                g.DrawRectangle(whitePen, pnlMailIconWrapper.Left + 18, pnlMailIconWrapper.Top + 22, 28, 20);
                g.DrawLine(whitePen, pnlMailIconWrapper.Left + 18, pnlMailIconWrapper.Top + 22, pnlMailIconWrapper.Left + 32, pnlMailIconWrapper.Top + 34);
                g.DrawLine(whitePen, pnlMailIconWrapper.Left + 32, pnlMailIconWrapper.Top + 34, pnlMailIconWrapper.Left + 46, pnlMailIconWrapper.Top + 22);
            }
        }

        private void PaintSmoothFigmaButton(object sender, PaintEventArgs e)
        {
            System.Windows.Forms.Button activeBtn = (System.Windows.Forms.Button)sender;
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            int radius = 8; // Figma 'rounded-lg' button asset specification mapping
            Rectangle btnRect = new Rectangle(0, 0, activeBtn.Width, activeBtn.Height);
            System.Drawing.Drawing2D.GraphicsPath path = GetRoundedRectanglePath(btnRect, radius);

            activeBtn.Region = new Region(path);
        }

        private System.Drawing.Drawing2D.GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

    }
}
