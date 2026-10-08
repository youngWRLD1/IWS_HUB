namespace IwsHub2
{
    partial class Admin_Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flpStudentGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnReflesh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPastPapers = new System.Windows.Forms.Button();
            this.btnGroupPosts = new System.Windows.Forms.Button();
            this.btnStudents = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlNavbar = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.picWSUlogo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlNavbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblTitle);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblWelcome);
            this.panel1.Controls.Add(this.btnReflesh);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnPastPapers);
            this.panel1.Controls.Add(this.btnGroupPosts);
            this.panel1.Controls.Add(this.btnStudents);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(398, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 624);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flpStudentGrid);
            this.panel3.Location = new System.Drawing.Point(24, 273);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(590, 244);
            this.panel3.TabIndex = 11;
            // 
            // flpStudentGrid
            // 
            this.flpStudentGrid.BackColor = System.Drawing.Color.Gainsboro;
            this.flpStudentGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpStudentGrid.Location = new System.Drawing.Point(0, 0);
            this.flpStudentGrid.Name = "flpStudentGrid";
            this.flpStudentGrid.Size = new System.Drawing.Size(590, 244);
            this.flpStudentGrid.TabIndex = 20;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(221, 89);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(32, 17);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(531, 580);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(58, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "LogOut";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(131, 89);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(61, 17);
            this.lblWelcome.TabIndex = 10;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnReflesh
            // 
            this.btnReflesh.Location = new System.Drawing.Point(24, 538);
            this.btnReflesh.Margin = new System.Windows.Forms.Padding(2);
            this.btnReflesh.Name = "btnReflesh";
            this.btnReflesh.Size = new System.Drawing.Size(58, 23);
            this.btnReflesh.TabIndex = 7;
            this.btnReflesh.Text = "Refresh";
            this.btnReflesh.UseVisualStyleBackColor = true;
            this.btnReflesh.Click += new System.EventHandler(this.btnReflesh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 537);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(58, 24);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPastPapers
            // 
            this.btnPastPapers.Location = new System.Drawing.Point(531, 187);
            this.btnPastPapers.Margin = new System.Windows.Forms.Padding(2);
            this.btnPastPapers.Name = "btnPastPapers";
            this.btnPastPapers.Size = new System.Drawing.Size(83, 24);
            this.btnPastPapers.TabIndex = 4;
            this.btnPastPapers.Text = "PastPapers";
            this.btnPastPapers.UseVisualStyleBackColor = true;
            this.btnPastPapers.Click += new System.EventHandler(this.btnPastPapers_Click);
            // 
            // btnGroupPosts
            // 
            this.btnGroupPosts.Location = new System.Drawing.Point(268, 186);
            this.btnGroupPosts.Margin = new System.Windows.Forms.Padding(2);
            this.btnGroupPosts.Name = "btnGroupPosts";
            this.btnGroupPosts.Size = new System.Drawing.Size(94, 27);
            this.btnGroupPosts.TabIndex = 5;
            this.btnGroupPosts.Text = "GroupPosts";
            this.btnGroupPosts.UseVisualStyleBackColor = true;
            this.btnGroupPosts.Click += new System.EventHandler(this.btnGroupPosts_Click);
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(24, 187);
            this.btnStudents.Margin = new System.Windows.Forms.Padding(2);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(90, 24);
            this.btnStudents.TabIndex = 6;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlNavbar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1493, 115);
            this.panel2.TabIndex = 2;
            // 
            // pnlNavbar
            // 
            this.pnlNavbar.BackColor = System.Drawing.Color.White;
            this.pnlNavbar.Controls.Add(this.label7);
            this.pnlNavbar.Controls.Add(this.picWSUlogo);
            this.pnlNavbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNavbar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavbar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pnlNavbar.Name = "pnlNavbar";
            this.pnlNavbar.Size = new System.Drawing.Size(1493, 115);
            this.pnlNavbar.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(854, 44);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "IWS Hub";
            // 
            // picWSUlogo
            // 
            this.picWSUlogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picWSUlogo.Image = ((System.Drawing.Image)(resources.GetObject("picWSUlogo.Image")));
            this.picWSUlogo.Location = new System.Drawing.Point(588, 14);
            this.picWSUlogo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.picWSUlogo.Name = "picWSUlogo";
            this.picWSUlogo.Size = new System.Drawing.Size(231, 83);
            this.picWSUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWSUlogo.TabIndex = 2;
            this.picWSUlogo.TabStop = false;
            // 
            // AdminDashForm4
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1493, 787);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminDashForm4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashForm4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlNavbar.ResumeLayout(false);
            this.pnlNavbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPastPapers;
        private System.Windows.Forms.Button btnGroupPosts;
        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnReflesh;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlNavbar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picWSUlogo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flpStudentGrid;
    }
}