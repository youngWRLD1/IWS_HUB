using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IwsHub2
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
            InjectSmoothFigmaStyling();
        }
        bool validateLog()
        {
            if (txtstudentno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your student number.");
                return false;
            }
            for (int i = 0; i < txtstudentno.Text.Length; i++)
            {
                if (!char.IsDigit(txtstudentno.Text[i]))
                {
                    MessageBox.Show("Student number must be digits only.");
                    return false;
                }
            }
            if (txtpassword.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your password.");
                return false;
            }

            bool hasUpper = txtpassword.Text.Any(char.IsUpper);
            bool hasLower = txtpassword.Text.Any(char.IsLower);
            bool hasDigit = txtpassword.Text.Any(char.IsDigit);
            bool hasSymbol = txtpassword.Text.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasUpper || !hasLower || !hasDigit || !hasSymbol)
            {
                MessageBox.Show("Password must contain uppercase, lowercase, number, and symbol.");
                return false;
            }

            return true;
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (!validateLog())
                return;

            SqlConnection con = Database.GetConnection();

            try
            {
                con.Open();

                string query = "SELECT FullName FROM Users WHERE StudentNumber=@StudentNumber AND Password=@Password";

                SqlCommand cmd = new SqlCommand(query, con);

                cmd.Parameters.AddWithValue("@StudentNumber", txtstudentno.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", txtpassword.Text);

                using (SqlDataReader reader = cmd.ExecuteReader())
                if (reader.Read())
                {
                    UserData.studentno = txtstudentno.Text.Trim();
                    UserData.password = txtpassword.Text;
                    UserData.fullname = reader["FullName"].ToString();

                    MessageBox.Show("Login Successful!");

                    Dashboard frm = new Dashboard(UserData.fullname);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Incorrect student number or password.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lblforgot_Click(object sender, EventArgs e)
        {
            Req_Password frm = new Req_Password();

            frm.Show();

            this.Hide();
        }

        private void lblsign_Click(object sender, EventArgs e)
        {
            Sign_Up frm = new Sign_Up();
            frm.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Home_Page ftm = new Home_Page();
            ftm.Show();
            this.Hide();
        }

            // =======================================================
        // UNIFIED SMOOTH FIGMA STYLING OVERRIDES FOR LOGIN FORM
        // =======================================================
        private void InjectSmoothFigmaStyling()
        {
            // Direct the layout background card and buttons to calculate vector shapes
            if (pnlCard != null)
            {
                pnlCard.Paint += new PaintEventHandler(PaintSmoothFigmaCard);
            }

            if (btnlogin != null)
            {
                btnlogin.Paint += new PaintEventHandler(PaintSmoothFigmaButton);
            }
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

        private void pnlCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Home_Page frm = new Home_Page();
            frm.Show();
            this.Hide();
        }

        private void chkShowPassword_CheckedChanged_1(object sender, EventArgs e)
        {
            txtpassword.UseSystemPasswordChar = !chkShowPassword.Checked;

        }
        
    }
 }
