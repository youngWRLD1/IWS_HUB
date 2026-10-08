using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Password_Reset : Form
    {
        private string studentNumber;
        public Password_Reset()
        {
            InitializeComponent();
        }
        public Password_Reset(string studentNo)
        {
            InitializeComponent();

            studentNumber = studentNo;
        }
        bool validatePassword()
        {
            if (txtpasswordnew.Text.Trim().Length == 0 || txtpasswordconfirm.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your password.");
                return false;
            }
            bool hasUpper = txtpasswordnew.Text.Any(char.IsUpper);
            bool hasLower = txtpasswordnew.Text.Any(char.IsLower);
            bool hasDigit = txtpasswordnew.Text.Any(char.IsDigit);
            bool hasSymbol = txtpasswordnew.Text.Any(ch => !char.IsLetterOrDigit(ch));
            if (!hasUpper || !hasLower || !hasDigit || !hasSymbol)
            {
                MessageBox.Show("Password must contain uppercase, lowercase, number, and symbol.");
                return false;
            }

            if (txtpasswordnew.Text != txtpasswordconfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }
            return true;
        }  
        private void btnenter_Click(object sender, EventArgs e)
        {
          if (!validatePassword())
            {
                return;
            } 
            try
            {
                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(
                    "UPDATE Users SET Password=@Password WHERE StudentNumber=@StudentNumber", con))
                {
                    cmd.Parameters.AddWithValue("@Password", txtpasswordnew.Text);
                    cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                    con.Open();

                    int rows = cmd.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        MessageBox.Show("Student account could not be found.");
                        return;
                    }
                }

                MessageBox.Show("Password changed successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not change the password.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            UserData.password = txtpasswordnew.Text;

            
           
            Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtpasswordnew.UseSystemPasswordChar = !chkshowpassword.Checked;
            txtpasswordconfirm.UseSystemPasswordChar = !chkshowpassword.Checked;
                
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Login_Page frm = new Login_Page();
            frm.Show();
            this.Hide();
        }

        // =======================================================
        // UNIFIED SMOOTH FIGMA STYLING OVERRIDES FOR RESET FORM
        // =======================================================
        private void InjectSmoothFigmaStyling()
        {
            // Direct the layout background card and buttons to calculate vector shapes
            if (pnlCard != null)
            {
                pnlCard.Paint += new PaintEventHandler(PaintSmoothFigmaCard);
            }

            if (btnenter != null)
            {
                btnenter.Paint += new PaintEventHandler(PaintSmoothFigmaButton);
            }

            // Ensure the input fields hide typed password text by default
            txtpasswordnew.UseSystemPasswordChar = true;
            txtpasswordconfirm.UseSystemPasswordChar = true;
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
