using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Myprofile : Form
    {
        public Myprofile()
        {
            InitializeComponent();

            // CHANGED: Designer did not contain these event hookups.
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnBack.Click += btnBack_Click;

            cboCourseYear.Items.Clear();
            cboCourseYear.Items.Add("1st year");
            cboCourseYear.Items.Add("2nd year");
            cboCourseYear.Items.Add("3rd year");
            cboCourseYear.Items.Add("Advancing year");
            cboCourseYear.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadProfile();
            SetEditing(false);
        }

        private void LoadProfile()
        {
            if (string.IsNullOrWhiteSpace(UserData.studentno) || UserData.studentno == "ADMIN")
            {
                MessageBox.Show("No student is currently logged in.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(@"
                    SELECT StudentNumber, FullName, StudentMail, Course, CourseYear
                    FROM Users WHERE StudentNumber = @StudentNumber", con))
                {
                    cmd.Parameters.Add("@StudentNumber", SqlDbType.NVarChar, 20).Value = UserData.studentno;
                    con.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            MessageBox.Show("Your account could not be found.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        txtStudentNumber.Text = Convert.ToString(reader["StudentNumber"]);
                        txtFullName.Text = Convert.ToString(reader["FullName"]);
                        txtEmail.Text = Convert.ToString(reader["StudentMail"]);
                        txtCourse.Text = reader["Course"] == DBNull.Value ? "" : Convert.ToString(reader["Course"]);
                        cboCourseYear.Text = reader["CourseYear"] == DBNull.Value ? "" : Convert.ToString(reader["CourseYear"]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not load your profile.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetEditing(bool editing)
        {
            txtStudentNumber.ReadOnly = true;
            txtFullName.ReadOnly = !editing;
            txtEmail.ReadOnly = !editing;
            txtCourse.ReadOnly = !editing;
            cboCourseYear.Enabled = editing;
            btnEdit.Enabled = !editing;
            btnSave.Enabled = editing;
        }

        private bool ValidateProfile()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Full name cannot be empty.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || !txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Please enter a valid email address.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCourse.Text))
            {
                MessageBox.Show("Please enter your course.");
                return false;
            }
            if (cboCourseYear.SelectedIndex == -1)
            {
                MessageBox.Show("Please select your course year.");
                return false;
            }
            return true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            SetEditing(true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateProfile()) return;

            try
            {
                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(@"
                    UPDATE Users
                    SET FullName = @FullName, StudentMail = @StudentMail,
                        Course = @Course, CourseYear = @CourseYear
                    WHERE StudentNumber = @StudentNumber", con))
                {
                    cmd.Parameters.Add("@FullName", SqlDbType.NVarChar, 200).Value = txtFullName.Text.Trim();
                    cmd.Parameters.Add("@StudentMail", SqlDbType.NVarChar, 254).Value = txtEmail.Text.Trim();
                    cmd.Parameters.Add("@Course", SqlDbType.NVarChar, 150).Value = txtCourse.Text.Trim();
                    cmd.Parameters.Add("@CourseYear", SqlDbType.NVarChar, 30).Value = cboCourseYear.Text.Trim();
                    cmd.Parameters.Add("@StudentNumber", SqlDbType.NVarChar, 20).Value = UserData.studentno;
                    con.Open();
                    if (cmd.ExecuteNonQuery() == 0)
                    {
                        MessageBox.Show("No profile was updated.");
                        return;
                    }
                }

                UserData.fullname = txtFullName.Text.Trim();
                MessageBox.Show("Profile saved successfully.", "Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SetEditing(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save your profile.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(UserData.fullname);
            frm.Show();
            this.Hide();
        }
    }
}
