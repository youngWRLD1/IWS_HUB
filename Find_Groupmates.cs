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
    public partial class Find_Groupmates : Form
    {
        public Find_Groupmates()
        {
           InitializeComponent();

                // Connect the buttons/textboxes to the code
                btnPostRequest.Click += btnPostRequest_Click;
                txtFilterGroupmates.TextChanged += txtFilterGroupmates_TextChanged;

                // Load posts when the form opens
                this.Load += FinderForm4_Load; 
        }

            // =========================================================
            // LOAD ALL POSTS
            // =========================================================
            
        private void btnPostRequest_Click(object sender, EventArgs e)
        {  
            string postContent = txtPostContent.Text.Trim();

                if (string.IsNullOrWhiteSpace(postContent))
                {
                    MessageBox.Show(
                        "Please enter a group request before posting.",
                        "Empty Post",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                if (string.IsNullOrWhiteSpace(UserData.studentno) ||
                    string.IsNullOrWhiteSpace(UserData.fullname))
                {
                    MessageBox.Show(
                        "You must be logged in before creating a post.",
                        "Login Required",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                SqlConnection con = Database.GetConnection();

                try
                {
                    con.Open();

                    string query = @"
                    INSERT INTO GroupPosts
                    (
                        StudentNumber,
                        StudentName,
                        PostContent
                    )
                    VALUES
                    (
                        @StudentNumber,
                        @StudentName,
                        @PostContent
                    )";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add("@StudentNumber", SqlDbType.NVarChar, 20)
                            .Value = UserData.studentno;

                        cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar, 200)
                            .Value = UserData.fullname;

                        cmd.Parameters.Add("@PostContent", SqlDbType.NVarChar)
                            .Value = postContent;

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show(
                        "Your group request has been posted successfully!",
                        "Post Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Clear the textbox
                    txtPostContent.Clear();

                    // Refresh posts
                    LoadPosts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not create the post.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
        }
            // =========================================================
            // POST REQUEST
            // =========================================================
          private void LoadPosts()
            {
                SqlConnection con = Database.GetConnection();

                try
                {
                    con.Open();

                    string query = @"
                    SELECT
                        PostID,
                        StudentNumber,
                        StudentName,
                        PostContent,
                        PostedAt
                    FROM GroupPosts
                    ORDER BY PostedAt DESC";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        DisplayPosts(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not load group requests.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

            // =========================================================
            // DISPLAY POSTS ON THE GUI
            // =========================================================
            private void DisplayPosts(DataTable table)
            {
                flpStudentGrid.Controls.Clear();

                if (table.Rows.Count == 0)
                {
                    Label noPosts = new Label();

                    noPosts.Text = "No group requests have been posted yet.";
                    noPosts.Font = new Font("Segoe UI", 11F);
                    noPosts.ForeColor = Color.Gray;
                    noPosts.AutoSize = true;
                    noPosts.Margin = new Padding(20);

                    flpStudentGrid.Controls.Add(noPosts);

                    return;
                }

                foreach (DataRow row in table.Rows)
                {
                    int postID = Convert.ToInt32(row["PostID"]);

                    string studentNumber =
                        row["StudentNumber"].ToString();

                    string studentName =
                        row["StudentName"].ToString();

                    string postContent =
                        row["PostContent"].ToString();

                    DateTime postedAt =
                        Convert.ToDateTime(row["PostedAt"]);

                    CreatePostCard(
                        postID,
                        studentNumber,
                        studentName,
                        postContent,
                        postedAt);
                }
            }

            // =========================================================
            // CREATE ONE POST CARD
            // =========================================================
            private void CreatePostCard(
                int postID,
                string studentNumber,
                string studentName,
                string postContent,
                DateTime postedAt)
            {
                Panel postCard = new Panel();

                postCard.Width = flpStudentGrid.ClientSize.Width - 25;
                postCard.Height = 150;

                postCard.BackColor = Color.White;
                postCard.BorderStyle = BorderStyle.FixedSingle;

                postCard.Margin = new Padding(10);

                // -------------------------
                // STUDENT NAME
                // -------------------------
                Label lblName = new Label();

                lblName.Text = studentName;
                lblName.Font = new Font(
                    "Segoe UI",
                    11F,
                    FontStyle.Bold);

                lblName.ForeColor =
                    Color.FromArgb(30, 58, 138);

                lblName.Location =
                    new Point(15, 12);

                lblName.AutoSize = true;

                // -------------------------
                // STUDENT NUMBER
                // -------------------------
                Label lblStudentNo = new Label();

                lblStudentNo.Text =
                    "Student No: " + studentNumber;

                lblStudentNo.Font =
                    new Font("Segoe UI", 8.5F);

                lblStudentNo.ForeColor =
                    Color.Gray;

                lblStudentNo.Location =
                    new Point(15, 38);

                lblStudentNo.AutoSize = true;

                // -------------------------
                // POST CONTENT
                // -------------------------
                Label lblContent = new Label();

                lblContent.Text = postContent;

                lblContent.Font =
                    new Font("Segoe UI", 10F);

                lblContent.ForeColor =
                    Color.Black;

                lblContent.Location =
                    new Point(15, 62);

                lblContent.MaximumSize =
                    new Size(postCard.Width - 180, 55);

                lblContent.AutoSize = true;

                // -------------------------
                // DATE
                // -------------------------
                Label lblDate = new Label();

                lblDate.Text =
                    postedAt.ToString("dd MMM yyyy HH:mm");

                lblDate.Font =
                    new Font("Segoe UI", 8F);

                lblDate.ForeColor =
                    Color.Gray;

                lblDate.Location =
                    new Point(15, 125);

                lblDate.AutoSize = true;

                // -------------------------
                // DELETE BUTTON
                // Only the person who
                // created the post sees it
                // -------------------------
                if (UserData.studentno == studentNumber)
                {
                    Button btnDelete = new Button();

                    btnDelete.Text = "Delete";

                    btnDelete.Width = 80;
                    btnDelete.Height = 30;

                    btnDelete.Location =
                        new Point(postCard.Width - 100, 15);

                    btnDelete.BackColor =
                        Color.Firebrick;

                    btnDelete.ForeColor =
                        Color.White;

                    btnDelete.FlatStyle =
                        FlatStyle.Flat;

                    btnDelete.Cursor =
                        Cursors.Hand;

                    btnDelete.Click += (sender, e) =>
                    {
                        DeletePost(postID);
                    };

                    postCard.Controls.Add(btnDelete);
                }

                // Add everything to card
                postCard.Controls.Add(lblName);
                postCard.Controls.Add(lblStudentNo);
                postCard.Controls.Add(lblContent);
                postCard.Controls.Add(lblDate);

                // Add card to FlowLayoutPanel
                flpStudentGrid.Controls.Add(postCard);
            }

            // =========================================================
            // DELETE OWN POST
            // =========================================================
            private void DeletePost(int postID)
            {
                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this post?",
                    "Delete Post",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result != DialogResult.Yes)
                    return;

                SqlConnection con = Database.GetConnection();

                try
                {
                    con.Open();

                    string query = @"
                    DELETE FROM GroupPosts
                    WHERE PostID = @PostID
                    AND StudentNumber = @StudentNumber";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@PostID",
                            SqlDbType.Int).Value = postID;

                        cmd.Parameters.Add(
                            "@StudentNumber",
                            SqlDbType.NVarChar,
                            20).Value = UserData.studentno;

                        cmd.ExecuteNonQuery();
                    }

                    LoadPosts();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not delete the post.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }

           
            private void SearchPosts(string searchText)
            {
                SqlConnection con = Database.GetConnection();

                try
                {
                    con.Open();

                    string query = @"
                    SELECT
                        PostID,
                        StudentNumber,
                        StudentName,
                        PostContent,
                        PostedAt
                    FROM GroupPosts
                    WHERE StudentName LIKE @Search
                       OR StudentNumber LIKE @Search
                       OR PostContent LIKE @Search
                    ORDER BY PostedAt DESC";

                    using (SqlCommand cmd =
                        new SqlCommand(query, con))
                    {
                        cmd.Parameters.Add(
                            "@Search",
                            SqlDbType.NVarChar,
                            200).Value = "%" + searchText + "%";

                        SqlDataAdapter adapter =
                            new SqlDataAdapter(cmd);

                        DataTable table = new DataTable();

                        adapter.Fill(table);

                        DisplayPosts(table);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not search posts.\n\n" + ex.Message,
                        "Database Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        
            // =========================================================
            // SEARCH GROUP REQUESTS
            // =========================================================
            

        private void txtFilterGroupmates_TextChanged(object sender, EventArgs e)
        {

                SearchPosts(txtFilterGroupmates.Text.Trim());
        }
            // =========================================================
            // WHEN GROUP FINDER OPENS
            // =========================================================
        private void FinderForm4_Load(object sender, EventArgs e)
        {
                flpStudentGrid.AutoScroll = true;
                flpStudentGrid.WrapContents = false;
                flpStudentGrid.FlowDirection = FlowDirection.TopDown;

                LoadPosts();
        }

        private void lblGroupmates_Click(object sender, EventArgs e)
        {
            Find_Groupmates frm = new Find_Groupmates();
            frm.Show();
            this.Hide();
        }

        private void lblPastPapers_Click(object sender, EventArgs e)
        {
            upload_and_browseForm4 frm = new upload_and_browseForm4();
            frm.Show();
            this.Hide();
        }

        private void lblDashboard_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(UserData.fullname);
            frm.Show();
            this.Hide();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Dashboard frm = new Dashboard(UserData.fullname);
            frm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Myprofile frm = new Myprofile();
            frm.Show();
            this.Hide();
        }
    }
}
