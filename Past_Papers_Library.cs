using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Past_Papers_Library : Form
    {
        private string activeYearFilter = "";

        public Past_Papers_Library()
        {
            InitializeComponent();
            this.SizeChanged += Past_Papers_Library_SizeChanged;
        }

        private void Past_Papers_Library_Load(object sender, EventArgs e)
        {
            flpPapersContainer.AutoScroll = true;
            flpPapersContainer.WrapContents = true;
            LoadPastPapers();
        }

        private void LoadPastPapers()
        {
            ExecutePaperQuery(@"SELECT PaperID, Module, CourseCode, CourseYear, Semester, [Year], [Description], FilePath, FileName, FileData, UploadedBy, UploadedAt
                                 FROM PastPapers ORDER BY UploadedAt DESC", null);
        }

        private void SearchAndFilterPapers()
        {
            string query = @"SELECT PaperID, Module, CourseCode, CourseYear, Semester, [Year], [Description], FilePath, FileName, FileData, UploadedBy, UploadedAt
                             FROM PastPapers WHERE Module LIKE @Module";
            if (!string.IsNullOrEmpty(activeYearFilter)) query += " AND [Year] = @Year";
            query += " ORDER BY UploadedAt DESC";
            ExecutePaperQuery(query, cmd =>
            {
                cmd.Parameters.Add("@Module", SqlDbType.NVarChar, 150).Value = "%" + txtSearchModule.Text.Trim() + "%";
                if (!string.IsNullOrEmpty(activeYearFilter)) cmd.Parameters.Add("@Year", SqlDbType.Int).Value = int.Parse(activeYearFilter);
            });
        }

        private void ExecutePaperQuery(string query, Action<SqlCommand> addParameters)
        {
            try
            {
                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    if (addParameters != null) addParameters(cmd);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        PopulatePapersList(dt);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Could not load past papers.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void PopulatePapersList(DataTable dt)
        {
            flpPapersContainer.Controls.Clear();
            if (dt.Rows.Count == 0)
            {
                flpPapersContainer.Controls.Add(new Label { Text = "No past question papers found matching your criteria.", Font = new Font("Segoe UI", 11F), ForeColor = Color.Gray, AutoSize = true, Margin = new Padding(20) });
                return;
            }

            flpPapersContainer.SuspendLayout();
            foreach (DataRow row in dt.Rows)
            {
                string paperId = row["PaperID"].ToString();
                string moduleName = row["Module"] == DBNull.Value ? "Unknown Module" : row["Module"].ToString();
                string code = row["CourseCode"] == DBNull.Value ? "" : row["CourseCode"].ToString();
                string year = row["Year"] == DBNull.Value ? "" : row["Year"].ToString();
                string semester = row["Semester"] == DBNull.Value ? "" : row["Semester"].ToString();
                string fileName = row["FileName"] == DBNull.Value ? "" : row["FileName"].ToString();
                string uploadedBy = row["UploadedBy"] == DBNull.Value ? "" : row["UploadedBy"].ToString();
                bool isOwner = !string.IsNullOrWhiteSpace(UserData.studentno) && UserData.studentno != "ADMIN" && uploadedBy == UserData.studentno;

                Panel card = new Panel { Width = Math.Max(650, flpPapersContainer.ClientSize.Width - 24), Height = 85, BackColor = Color.White, BorderStyle = BorderStyle.FixedSingle, Margin = new Padding(12,0,12,12), Padding = new Padding(15,10,15,10) };
                Label lblModule = new Label { Text = moduleName, Font = new Font("Segoe UI", 12F, FontStyle.Bold), Location = new Point(15,15), AutoSize = true };
                Label lblMeta = new Label { Text = (code + "   •   " + year + "   •   " + semester).Trim(' ', '•'), Font = new Font("Segoe UI",9.5F), ForeColor = Color.DimGray, Location = new Point(15,45), AutoSize = true };

                Button btnOpen = MakeButton("Open", 85, Color.FromArgb(5,150,105));
                Button btnDownload = MakeButton("Download", 100, Color.FromArgb(30,58,138));
                Button btnDelete = MakeButton("Delete", 90, Color.Maroon);
                btnOpen.Location = new Point(card.Width - 330, 24);
                btnDownload.Location = new Point(card.Width - 230, 24);
                btnDelete.Location = new Point(card.Width - 115, 24);
                btnOpen.Anchor = btnDownload.Anchor = btnDelete.Anchor = AnchorStyles.Right | AnchorStyles.Top;
                btnOpen.Click += (s,e) => ExecuteOpen(paperId);
                btnDownload.Click += (s,e) => ExecuteDownload(paperId);
                btnDelete.Enabled = isOwner;
                btnDelete.Text = isOwner ? "Delete" : "";
                btnDelete.Click += (s,e) => ExecuteDelete(paperId);

                card.Controls.Add(lblModule); card.Controls.Add(lblMeta); card.Controls.Add(btnOpen); card.Controls.Add(btnDownload); card.Controls.Add(btnDelete);
                flpPapersContainer.Controls.Add(card);
            }
            flpPapersContainer.ResumeLayout();
        }

        private Button MakeButton(string text, int width, Color backColor)
        {
            Button b = new Button { Text=text, Width=width, Height=35, BackColor=backColor, ForeColor=Color.White, FlatStyle=FlatStyle.Flat, Font=new Font("Segoe UI",9.5F,FontStyle.Bold), Cursor=Cursors.Hand };
            b.FlatAppearance.BorderSize = 0;
            return b;
        }

        private byte[] GetPaperBytes(string paperId, out string fileName, out string legacyPath)
        {
            fileName = "paper"; legacyPath = "";
            using (SqlConnection con = Database.GetConnection())
            using (SqlCommand cmd = new SqlCommand("SELECT FileName, FileData, FilePath FROM PastPapers WHERE PaperID=@PaperID", con))
            {
                cmd.Parameters.Add("@PaperID", SqlDbType.Int).Value = int.Parse(paperId);
                con.Open();
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    if (!r.Read()) return null;
                    fileName = r["FileName"] == DBNull.Value ? "paper" : r["FileName"].ToString();
                    legacyPath = r["FilePath"] == DBNull.Value ? "" : r["FilePath"].ToString();
                    return r["FileData"] == DBNull.Value ? null : (byte[])r["FileData"];
                }
            }
        }

        private void ExecuteDownload(string paperId)
        {
            try
            {
                string fileName, legacyPath;
                byte[] bytes = GetPaperBytes(paperId, out fileName, out legacyPath);
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.FileName = Path.GetFileName(string.IsNullOrWhiteSpace(fileName) ? legacyPath : fileName);
                    if (save.ShowDialog() != DialogResult.OK) return;
                    if (bytes != null) File.WriteAllBytes(save.FileName, bytes);
                    else if (!string.IsNullOrWhiteSpace(legacyPath) && File.Exists(legacyPath)) File.Copy(legacyPath, save.FileName, true);
                    else { MessageBox.Show("The paper file is not available.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                    MessageBox.Show("Question paper downloaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex) { MessageBox.Show("Download failed.\n\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ExecuteOpen(string paperId)
        {
            try
            {
                string fileName, legacyPath;
                byte[] bytes = GetPaperBytes(paperId, out fileName, out legacyPath);
                string path;
                if (bytes != null)
                {
                    string safeName = Path.GetFileName(fileName);
                    if (string.IsNullOrWhiteSpace(safeName)) safeName = "IWSHubPaper.pdf";
                    path = Path.Combine(Path.GetTempPath(), "IWSHub_" + paperId + "_" + safeName);
                    File.WriteAllBytes(path, bytes);
                }
                else path = legacyPath;

                if (string.IsNullOrWhiteSpace(path) || !File.Exists(path)) { MessageBox.Show("The paper file could not be found.", "File Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                System.Diagnostics.Process.Start(path);
            }
            catch (Exception ex) { MessageBox.Show("Could not open the paper.\n\n" + ex.Message, "Open Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ExecuteDelete(string paperId)
        {
            if (UserData.studentno == "ADMIN" || string.IsNullOrWhiteSpace(UserData.studentno)) { MessageBox.Show("Only the student who uploaded this paper can delete it."); return; }
            if (MessageBox.Show("Are you sure you want to permanently delete this past paper?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (SqlConnection con = Database.GetConnection())
                using (SqlCommand cmd = new SqlCommand("DELETE FROM PastPapers WHERE PaperID=@PaperID AND UploadedBy=@UploadedBy", con))
                {
                    cmd.Parameters.Add("@PaperID", SqlDbType.Int).Value = int.Parse(paperId);
                    cmd.Parameters.Add("@UploadedBy", SqlDbType.NVarChar,20).Value = UserData.studentno;
                    con.Open();
                    if (cmd.ExecuteNonQuery() == 0) { MessageBox.Show("You can only delete your own upload."); return; }
                }
                MessageBox.Show("Past paper deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPastPapers();
            }
            catch (Exception ex) { MessageBox.Show("Deletion failed.\n\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void txtSearchModule_TextChanged(object sender, EventArgs e) { SearchAndFilterPapers(); }
        private void btnSearch_Click(object sender, EventArgs e) { SearchAndFilterPapers(); }
        private void btnApplyFilter_Click(object sender, EventArgs e) { SearchAndFilterPapers(); }
        private void picFilter_Click(object sender, EventArgs e) { }
        private void btnBack_Click(object sender, EventArgs e) { upload_and_browseForm4 frm = new upload_and_browseForm4(); frm.Show(); this.Hide(); }
        private void lblPastPapers_Click(object sender, EventArgs e) { upload_and_browseForm4 frm = new upload_and_browseForm4(); frm.Show(); this.Hide(); }
        private void lblGroupmates_Click(object sender, EventArgs e) { Find_Groupmates frm = new Find_Groupmates(); frm.Show(); this.Hide(); }
        private void lblDashboard_Click(object sender, EventArgs e) { Dashboard frm = new Dashboard(UserData.fullname); frm.Show(); this.Hide(); }
        private void label1_Click(object sender, EventArgs e) { Myprofile frm = new Myprofile(); frm.Show(); this.Hide(); }

        private void Past_Papers_Library_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in flpPapersContainer.Controls) if (ctrl is Panel card)
            {
                card.Width = Math.Max(650, flpPapersContainer.ClientSize.Width - 24);
                foreach (Control child in card.Controls) if (child is Button b)
                {
                    if (b.Text == "Open") b.Location = new Point(card.Width - 330, 24);
                    else if (b.Text == "Download") b.Location = new Point(card.Width - 230, 24);
                    else if (b.Text == "Delete" || b.Text == "") b.Location = new Point(card.Width - 115, 24);
                }
            }
        }
    }
}
