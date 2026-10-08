using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Upload_Papers : Form
    {
        public Upload_Papers()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            upload_and_browseForm4 frm = new upload_and_browseForm4();
            frm.Show();
            this.Hide();
        }

        private void btnbrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "PDF Files (*.pdf)|*.pdf|Word Files (*.docx)|*.docx|All Files (*.*)|*.*";
                if (open.ShowDialog() == DialogResult.OK) txtfile.Text = open.FileName;
            }
        }

        // CHANGED: the old Clear button was incorrectly connected to btnBack_Click.
        private void ClearForm()
        {
            txtmodule.Clear();
            txtyr.Clear();
            txtdescription.Clear();
            txtfile.Clear();
            cbocourseyear.SelectedIndex = -1;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private bool btnLoad()
        {
            if (string.IsNullOrWhiteSpace(txtmodule.Text)) { MessageBox.Show("Please select a module"); return false; }
            if (string.IsNullOrWhiteSpace(txtyr.Text)) { MessageBox.Show("Please enter the year"); return false; }
            if (!int.TryParse(txtyr.Text.Trim(), out int paperYear) || paperYear < 1900 || paperYear > 2100) { MessageBox.Show("Year must be a valid number."); return false; }
            if (cbocourseyear.SelectedIndex == -1) { MessageBox.Show("Please select the course year"); return false; }
            if (string.IsNullOrWhiteSpace(txtdescription.Text)) { MessageBox.Show("Please enter the description (test, notes, exam, quiz, etc)"); return false; }
            if (string.IsNullOrWhiteSpace(txtfile.Text) || !File.Exists(txtfile.Text)) { MessageBox.Show("Please select a valid file"); return false; }
            if (string.IsNullOrWhiteSpace(UserData.studentno)) { MessageBox.Show("You must be logged in to upload."); return false; }
            return true;
        }

        private void btnupload_Click(object sender, EventArgs e)
        {
            if (!btnLoad()) return;

            try
            {
                byte[] fileBytes = File.ReadAllBytes(txtfile.Text);
                string fileName = Path.GetFileName(txtfile.Text);
                int paperYear = int.Parse(txtyr.Text.Trim());

                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(@"
                    INSERT INTO PastPapers
                    (Module, CourseYear, Year, Description, FileName, FileData, FilePath, UploadedBy)
                    VALUES (@Module, @CourseYear, @Year, @Description, @FileName, @FileData, NULL, @UploadedBy)", con))
                {
                    cmd.Parameters.Add("@Module", SqlDbType.NVarChar, 150).Value = txtmodule.Text.Trim().ToUpper();
                    cmd.Parameters.Add("@CourseYear", SqlDbType.NVarChar, 30).Value = cbocourseyear.Text.Trim();
                    cmd.Parameters.Add("@Year", SqlDbType.Int).Value = paperYear;
                    cmd.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = txtdescription.Text.Trim();
                    cmd.Parameters.Add("@FileName", SqlDbType.NVarChar, 260).Value = fileName;
                    cmd.Parameters.Add("@FileData", SqlDbType.VarBinary, -1).Value = fileBytes;
                    cmd.Parameters.Add("@UploadedBy", SqlDbType.NVarChar, 20).Value = UserData.studentno;
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Past paper uploaded successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Past_Papers_Library frm = new Past_Papers_Library();
                frm.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Upload failed.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Paper_Form4_Load(object sender, EventArgs e)
        {
            if (cbocourseyear.Items.Count == 0)
            {
                cbocourseyear.Items.Add("1st year");
                cbocourseyear.Items.Add("2nd year");
                cbocourseyear.Items.Add("3rd year");
                cbocourseyear.Items.Add("Advancing year");
            }
            cbocourseyear.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void lblDashboard_Click(object sender, EventArgs e) { Dashboard frm = new Dashboard(UserData.fullname); frm.Show(); this.Hide(); }
        private void lblPastPapers_Click(object sender, EventArgs e) { upload_and_browseForm4 frm = new upload_and_browseForm4(); frm.Show(); this.Hide(); }
        private void lblGroupmates_Click(object sender, EventArgs e) { Find_Groupmates frm = new Find_Groupmates(); frm.Show(); this.Hide(); }
        private void label7_Click(object sender, EventArgs e) { Myprofile frm = new Myprofile(); frm.Show(); this.Hide(); }
    }
}
