using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace IwsHub2
{
    public partial class Sign_Up : Form
    {
        public Sign_Up()
        {
            InitializeComponent();
            InjectSmoothFigmaStyling();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        bool validateSign()
        {
            if (cbotitle.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your title");
                return false;
            }

            if (txtname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your name.");
                return false;
            }
            for (int i = 0; i < txtname.Text.Length; i++)
            {
                if (!char.IsLetter(txtname.Text[i]) && !char.IsWhiteSpace(txtname.Text[i]))
                {
                    MessageBox.Show("Name must contain letters only.");
                    return false;
                }
            }

            if (txtsurname.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your surname.");
                return false;
            }
            for (int i = 0; i < txtsurname.Text.Length; i++)
            {
                if (!char.IsLetter(txtsurname.Text[i]) && !char.IsWhiteSpace(txtsurname.Text[i]))
                {
                    MessageBox.Show("Surname must contain letters only.");
                    return false;
                }
            }

            if (!rdofemale.Checked && !rdomale.Checked && !rdoother.Checked)
            {
                MessageBox.Show("Please select a gender");
                return false;
            }

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

            if (txtstudentno.Text.Length != 9)
            {
                MessageBox.Show("Student number must have 9 digits.");
                return false;
            }

            if (txtemail.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your email.");
                return false;
            }
            for (int i = 0; i < txtemail.Text.Length; i++)
            {
                if (!char.IsLetterOrDigit(txtemail.Text[i]) && txtemail.Text[i] != '@' && txtemail.Text[i] != '.')
                {
                    MessageBox.Show("Please enter a valid email.");
                    return false;
                }
            }

            if (!txtemail.Text.Contains("@mywsu.ac.za"))
            {
                MessageBox.Show("Email must contain @mywsu.ac.za ");
                return false;
            }

            if (txtphoneno.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your phone number.");
                return false;
            }

            for (int i = 0; i < txtphoneno.Text.Length; i++)
            {
                if (!char.IsDigit(txtphoneno.Text[i]))
                {
                    MessageBox.Show("Phone number must be digits only.");
                    return false;
                }
            }
            if (txtphoneno.Text.Length != 10)
            {
                MessageBox.Show("Number must be 10 digits.");
                return false;
            }

            if (!txtphoneno.Text.StartsWith("0"))
            {
                MessageBox.Show("Phone number must start with 0.");
                return false;
            }
            if (txtpassword.Text.Trim().Length == 0 || txtconfirm.Text.Trim().Length == 0)
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

            if (txtpassword.Text != txtconfirm.Text)
            {
                MessageBox.Show("Passwords do not match.");
                return false;
            }

            if (!checkTnC.Checked)
            {
                MessageBox.Show("You must accept the Terms and Conditions");
                return false;
            }
            return true;

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            txtphoneno.Clear();
            txtemail.Clear();
            txtname.Clear();
            txtsurname.Clear();
            txtstudentno.Clear();
            txtpassword.Clear();
            txtconfirm.Clear();
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            // ===== 1. VALIDATE INPUT =====
            if (!validateSign())
            {
                return;
            }

            // ===== 2. SAVE TO DATABASE =====
            string fullname = txtname.Text + " " + txtsurname.Text;

            try
            {
                using (SqlConnection con = Database.GetConnection())
                {
                    con.Open();

                    string query = @"
                        INSERT INTO Users
                        (StudentNumber, FullName, StudentMail, PhoneNumber, Title, Gender, Password)
                        VALUES
                        (@StudentNumber, @FullName, @StudentMail, @PhoneNumber, @Title, @Gender, @Password)";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", txtstudentno.Text);
                        cmd.Parameters.AddWithValue("@FullName", fullname);
                        cmd.Parameters.AddWithValue("@StudentMail", txtemail.Text.Trim());
                        cmd.Parameters.AddWithValue("@PhoneNumber", txtphoneno.Text.Trim());
                        cmd.Parameters.AddWithValue("@Title", cbotitle.Text.Trim());
                        string gender = rdofemale.Checked ? "Female" : (rdomale.Checked ? "Male" : "Other");
                        cmd.Parameters.AddWithValue("@Gender", gender);
                        cmd.Parameters.AddWithValue("@Password", txtpassword.Text);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("✅ Registration successful!\n\n" +
                                            "Welcome, " + fullname + "!\n" +
                                            "You can now log in.",
                                            "Success",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information);

                            // ===== 3. ONLY OPEN ONE FORM =====
                            // Option A: Go to Login Form (Form2)
                            Login_Page frm = new Login_Page();
                            frm.Show();
                            this.Hide();

                            // OPTION B: OR go to Home Form (choose ONE, not both)
                            // HomeForm4 home = new HomeForm4(fullname);
                            // home.Show();
                            // this.Hide();

                            // OPTION C: OR stay on the same form and clear fields
                            // txtname.Clear();
                            // txtsurname.Clear();
                            // txtstudentno.Clear();
                            // txtemail.Clear();
                            // txtphoneno.Clear();
                            // txtpassword.Clear();
                            // txtconfirm.Clear();
                            // cbotitle.SelectedIndex = -1;
                        }
                        else
                        {
                            MessageBox.Show("❌ Registration failed.\nPlease try again.",
                                            "Error",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("❌ An error occurred:\n\n" + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        

        private void lbllog_Click(object sender, EventArgs e)
        {
            Login_Page ftm = new Login_Page();
            ftm.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            btnSign.Enabled = checkTnC.Checked;
        }

        private void cbotitle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboshow_CheckedChanged(object sender, EventArgs e)
        {

            txtpassword.UseSystemPasswordChar = !chkshowpassword.Checked;
            txtconfirm.UseSystemPasswordChar = !chkshowpassword.Checked;
        }

        private void label12_Click(object sender, EventArgs e)
        {
            Home_Page ftm = new Home_Page();
            ftm.Show();
            this.Hide();
        }


        // ==========================================
        // PASTE THIS ENTIRE BLOCK OF CODE HERE
        // ==========================================
        private void InjectSmoothFigmaStyling()
        {
            // Force form dimensions and colors to line up with Figma criteria
            this.Size = new Size(1296, 759);
            this.BackColor = Color.FromArgb(249, 250, 251); // Gray-50

            // Direct structural card elements and active buttons to run vector paint modifications
            pnlSignUpCard.Paint += new PaintEventHandler(PaintSmoothFigmaCard);
            btnCancel.Paint += new PaintEventHandler(PaintSmoothFigmaButton);
            btnSign.Paint += new PaintEventHandler(PaintSmoothFigmaButton);

            // Apply uniform typography styling across all your partner's specific inputs
            txtname.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtsurname.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtstudentno.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtemail.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtphoneno.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtpassword.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            txtconfirm.Font = new Font("Segoe UI", 11.5F, FontStyle.Regular);
            cbotitle.Font = new Font("Segoe UI", 11F, FontStyle.Regular);

            // Clean modern flat button presentation layers
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.Font = new Font("Segoe UI", 11F, FontStyle.Bold);

            btnSign.FlatStyle = FlatStyle.Flat;
            btnSign.FlatAppearance.BorderSize = 0;
            btnSign.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnSign.ForeColor = Color.White;



        }

        private void PaintSmoothFigmaCard(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 16; // Exact Figma 'rounded-2xl' target configuration mapping
            Rectangle borderRect = new Rectangle(0, 0, pnlSignUpCard.Width - 1, pnlSignUpCard.Height - 1);
            GraphicsPath path = GetRoundedRectanglePath(borderRect, radius);

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
            g.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 8; // Figma 'rounded-lg' button asset specification mapping
            Rectangle btnRect = new Rectangle(0, 0, activeBtn.Width, activeBtn.Height);
            GraphicsPath path = GetRoundedRectanglePath(btnRect, radius);

            activeBtn.Region = new Region(path);
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            int diameter = radius * 2;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();

            return path;
        }

        private void lblterms_Click(object sender, EventArgs e)
        {
            TermsAndConditionsForm4 frm = new TermsAndConditionsForm4();
            frm.Show();
            this.Hide();
        }
    }
}

