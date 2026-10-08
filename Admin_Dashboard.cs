using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace IwsHub2
{
    public partial class Admin_Dashboard : Form
    {
        string currentSection = "Students";
        private string selectedId = null; // ✅ NEW: Track which card is selected

        public Admin_Dashboard()

        {
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + UserData.fullname;
            LoadStudents();
        }

        // ──────────────────────────────────────────────────────────────
        // BUTTON CLICK HANDLERS
        // ──────────────────────────────────────────────────────────────

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            UserData.Clear();
            Home_Page home = new Home_Page();
            home.Show();
            this.Hide();
        }

        private void btnGroupPosts_Click(object sender, EventArgs e)
        {
            LoadGroupPosts();
        }

        private void btnPastPapers_Click(object sender, EventArgs e)
        {
            LoadPastPapers();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            LoadStudents();
        }

        private void btnReflesh_Click(object sender, EventArgs e)
        {
            if (currentSection == "Students")
                LoadStudents();
            else if (currentSection == "Group Posts")
                LoadGroupPosts();
            else if (currentSection == "Past Papers")
                LoadPastPapers();
        }

        // ──────────────────────────────────────────────────────────────
        // DELETE BUTTON HANDLER  (UPDATED FOR FLOWLAYOUTPANEL)
        // ──────────────────────────────────────────────────────────────

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // ✅ CHANGED: Check if a card is selected using selectedId
            if (string.IsNullOrEmpty(selectedId))
            {
                MessageBox.Show("Please select a card first by clicking on it.", "No Selection");
                return;
            }

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this record?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            try
            {
                string tableName = "";
                string idColumn = "";

                // ✅ CHANGED: Removed "Users" case since we're using "Students"
                if (currentSection == "Students")
                {
                    tableName = "Users";
                    idColumn = "StudentNumber";
                }
                else if (currentSection == "Group Posts")
                {
                    tableName = "GroupPosts";
                    idColumn = "PostID";
                }
                else if (currentSection == "Past Papers")
                {
                    tableName = "PastPapers";
                    idColumn = "PaperID";
                }

                string query = $"DELETE FROM {tableName} WHERE {idColumn} = @ID";

                using (SqlConnection connection = Database.GetConnection())
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ID", selectedId);
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Record deleted successfully.");

                // ✅ CHANGED: Refresh the current view
                btnReflesh.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not delete the record.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────────────────────
        // LOAD METHODS
        // ──────────────────────────────────────────────────────────────

        private void LoadStudents()
        {
            currentSection = "Students";
            string query = @"
                SELECT 
                    StudentNumber,
                    FullName, 
                    StudentMail
                FROM Users";

            LoadDataAsCards(query, "StudentNumber", "FullName", "StudentMail");
        }

        private void LoadGroupPosts()
        {
            currentSection = "Group Posts";
            string query = @"SELECT PostID, StudentNumber, StudentName, PostContent, PostedAt
                            FROM GroupPosts
                            ORDER BY PostedAt DESC";
            LoadDataAsCards(query, "PostID", "StudentName", "PostContent");
        }

        private void LoadPastPapers()
        {
            currentSection = "Past Papers";
            string query = @"SELECT PaperID, Module, [Description], CourseYear, [Year], UploadedAt
                            FROM PastPapers
                            ORDER BY UploadedAt DESC";
            LoadDataAsCards(query, "PaperID", "Module", "Description");
        }

        // ──────────────────────────────────────────────────────────────
        // ✅ NEW: Load data as cards in FlowLayoutPanel
        // ──────────────────────────────────────────────────────────────

        private void LoadDataAsCards(string query, string idColumn, string displayField1, string displayField2)
        {
            try
            {
                // Clear existing cards and previous selection
                selectedId = null;
                flpStudentGrid.Controls.Clear();

                using (SqlConnection connection = Database.GetConnection())
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);

                    if (table.Rows.Count == 0)
                    {
                        Label lblEmpty = new Label
                        {
                            Text = "No records found.",
                            AutoSize = true,
                            Font = new Font("Segoe UI", 12F),
                            ForeColor = Color.Gray
                        };
                        flpStudentGrid.Controls.Add(lblEmpty);
                        return;
                    }

                    // ✅ NEW: Create a card for each row
                    foreach (DataRow row in table.Rows)
                    {
                        string id = row[idColumn].ToString();
                        string field1 = row[displayField1]?.ToString() ?? "N/A";
                        string field2 = row[displayField2]?.ToString() ?? "N/A";

                        Panel card = CreateCard(id, field1, field2);

                        // Click event to select the card
                        card.Click += (sender, e) => SelectCard(card, id);

                        // Make child controls trigger selection too
                        foreach (Control ctrl in card.Controls)
                        {
                            ctrl.Click += (sender, e) => SelectCard(card, id);
                        }

                        flpStudentGrid.Controls.Add(card);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Could not load the data.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ──────────────────────────────────────────────────────────────
        // ✅ NEW: Create a single card (Panel with labels)
        // ──────────────────────────────────────────────────────────────

        private Panel CreateCard(string id, string field1, string field2)
        {
            Panel card = new Panel
            {
                Width = 250,
                Height = 120,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.White,
                Margin = new Padding(10),
                Padding = new Padding(10),
                Cursor = Cursors.Hand,
                Tag = id
            };

            // Label 1 (e.g., StudentNumber or Title)
            Label lbl1 = new Label
            {
                Text = field1,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                Location = new Point(10, 10),
                AutoSize = true,
                Tag = id
            };

            // Label 2 (e.g., StudentName or Description)
            Label lbl2 = new Label
            {
                Text = field2,
                Font = new Font("Segoe UI", 10F),
                Location = new Point(10, 40),
                AutoSize = true,
                ForeColor = Color.DarkGray,
                Tag = id
            };

            // Small ID label at bottom (optional)
            Label lblId = new Label
            {
                Text = $"ID: {id}",
                Font = new Font("Segoe UI", 8F),
                Location = new Point(10, 70),
                AutoSize = true,
                ForeColor = Color.LightGray,
                Tag = id
            };

            card.Controls.Add(lbl1);
            card.Controls.Add(lbl2);
            card.Controls.Add(lblId);

            return card;
        }

        // ──────────────────────────────────────────────────────────────
        // ✅ NEW: Handle card selection (highlight + store ID)
        // ──────────────────────────────────────────────────────────────

        private void SelectCard(Panel selectedCard, string id)
        {
            // Deselect all cards
            foreach (Control ctrl in flpStudentGrid.Controls)
            {
                if (ctrl is Panel card)
                {
                    card.BackColor = Color.White;
                    card.BorderStyle = BorderStyle.FixedSingle;
                }
            }

            // Select this card
            selectedCard.BackColor = Color.LightBlue;
            selectedCard.BorderStyle = BorderStyle.Fixed3D;
            selectedId = id;

            // Optional: Update status label
            // lblStatus.Text = $"Selected: {id}";
        }
    }
}