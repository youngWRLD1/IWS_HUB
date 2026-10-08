namespace IwsHub2
{
    partial class Past_Papers_Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Past_Papers_Library));
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.lblGroupmates = new System.Windows.Forms.Label();
            this.lblPastPapers = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picWSUlogo = new System.Windows.Forms.PictureBox();
            this.txtSearchModule = new System.Windows.Forms.TextBox();
            this.lblLibraryHeader = new System.Windows.Forms.Label();
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.flpPapersContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackColor = System.Drawing.Color.White;
            this.pnlNavBar.Controls.Add(this.lblGroupmates);
            this.pnlNavBar.Controls.Add(this.lblPastPapers);
            this.pnlNavBar.Controls.Add(this.lblDashboard);
            this.pnlNavBar.Controls.Add(this.label1);
            this.pnlNavBar.Controls.Add(this.picWSUlogo);
            this.pnlNavBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavBar.Location = new System.Drawing.Point(0, 0);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(1280, 100);
            this.pnlNavBar.TabIndex = 7;
            // 
            // lblGroupmates
            // 
            this.lblGroupmates.AutoSize = true;
            this.lblGroupmates.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupmates.Location = new System.Drawing.Point(732, 50);
            this.lblGroupmates.Name = "lblGroupmates";
            this.lblGroupmates.Size = new System.Drawing.Size(83, 17);
            this.lblGroupmates.TabIndex = 1;
            this.lblGroupmates.Text = "Groupmates";
            this.lblGroupmates.Click += new System.EventHandler(this.lblGroupmates_Click);
            // 
            // lblPastPapers
            // 
            this.lblPastPapers.AutoSize = true;
            this.lblPastPapers.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastPapers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblPastPapers.Location = new System.Drawing.Point(602, 50);
            this.lblPastPapers.Name = "lblPastPapers";
            this.lblPastPapers.Size = new System.Drawing.Size(79, 17);
            this.lblPastPapers.TabIndex = 1;
            this.lblPastPapers.Text = "Past Papers";
            this.lblPastPapers.Click += new System.EventHandler(this.lblPastPapers_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDashboard.Location = new System.Drawing.Point(476, 50);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(75, 17);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1156, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "My Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picWSUlogo
            // 
            this.picWSUlogo.Image = ((System.Drawing.Image)(resources.GetObject("picWSUlogo.Image")));
            this.picWSUlogo.Location = new System.Drawing.Point(31, 12);
            this.picWSUlogo.Name = "picWSUlogo";
            this.picWSUlogo.Size = new System.Drawing.Size(180, 76);
            this.picWSUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWSUlogo.TabIndex = 0;
            this.picWSUlogo.TabStop = false;
            // 
            // txtSearchModule
            // 
            this.txtSearchModule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSearchModule.BackColor = System.Drawing.Color.White;
            this.txtSearchModule.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchModule.Location = new System.Drawing.Point(161, 208);
            this.txtSearchModule.Multiline = true;
            this.txtSearchModule.Name = "txtSearchModule";
            this.txtSearchModule.Size = new System.Drawing.Size(1040, 45);
            this.txtSearchModule.TabIndex = 9;
            this.txtSearchModule.TextChanged += new System.EventHandler(this.txtSearchModule_TextChanged);
            // 
            // lblLibraryHeader
            // 
            this.lblLibraryHeader.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLibraryHeader.AutoSize = true;
            this.lblLibraryHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibraryHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblLibraryHeader.Location = new System.Drawing.Point(75, 134);
            this.lblLibraryHeader.Name = "lblLibraryHeader";
            this.lblLibraryHeader.Size = new System.Drawing.Size(412, 40);
            this.lblLibraryHeader.TabIndex = 8;
            this.lblLibraryHeader.Text = "Past Question Papers Library";
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picSearchIcon.BackColor = System.Drawing.Color.White;
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(81, 209);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(80, 45);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchIcon.TabIndex = 12;
            this.picSearchIcon.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(1089, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 45);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // flpPapersContainer
            // 
            this.flpPapersContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpPapersContainer.AutoScroll = true;
            this.flpPapersContainer.BackColor = System.Drawing.Color.White;
            this.flpPapersContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpPapersContainer.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpPapersContainer.Location = new System.Drawing.Point(82, 283);
            this.flpPapersContainer.Name = "flpPapersContainer";
            this.flpPapersContainer.Size = new System.Drawing.Size(1119, 326);
            this.flpPapersContainer.TabIndex = 15;
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBack.BackColor = System.Drawing.Color.Silver;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(82, 651);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(112, 45);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Past_Papers_Library
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.flpPapersContainer);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.txtSearchModule);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblLibraryHeader);
            this.Controls.Add(this.picSearchIcon);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Past_Papers_Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BrowseForm4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Past_Papers_Library_Load);
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lblGroupmates;
        private System.Windows.Forms.Label lblPastPapers;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picWSUlogo;
        private System.Windows.Forms.TextBox txtSearchModule;
        private System.Windows.Forms.Label lblLibraryHeader;
        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.FlowLayoutPanel flpPapersContainer;
        private System.Windows.Forms.Button btnBack;
    }
}