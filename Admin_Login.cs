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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            string studentNumber = txtadmin.Text.Trim();
            string password = txtpassword.Text;

            // CHANGED:
            // For now, ANY registered student can enter the Admin Dashboard.
            if (string.IsNullOrWhiteSpace(studentNumber) ||
                string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show(
                    "Please enter your student number and password.",
                    "Login Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (SqlConnection conn = Database.GetConnection())
                {
                    conn.Open();

                    // CHANGED:
                    // Check the Users table instead of the Admin table.
                    string query = @"
                SELECT StudentNumber, FullName
                FROM Users
                WHERE StudentNumber = @StudentNumber
                AND Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@StudentNumber", studentNumber);
                        cmd.Parameters.AddWithValue("@Password", password);

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Login successful
                                UserData.studentno = reader["StudentNumber"].ToString();
                                UserData.fullname = reader["FullName"].ToString();
                                UserData.password = password;

                                MessageBox.Show(
                                    "Admin access granted.",
                                    "Login Successful",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                                Admin_Dashboard adminDashboard = new Admin_Dashboard();

                                adminDashboard.Show();

                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show(
                                    "Incorrect student number or password.",
                                    "Login Failed",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not connect to the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Home_Page ftm = new Home_Page();
            ftm.Show();
            this.Hide();
        }
    }
}
