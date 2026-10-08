namespace IwsHub2
{
    partial class Find_Groupmates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Find_Groupmates));
            this.picSearchIcon = new System.Windows.Forms.PictureBox();
            this.lblPostPrompt = new System.Windows.Forms.Label();
            this.btnPostRequest = new System.Windows.Forms.Button();
            this.txtPostContent = new System.Windows.Forms.TextBox();
            this.txtFilterGroupmates = new System.Windows.Forms.TextBox();
            this.lblGroupmatesHeader = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.lblGroupmates = new System.Windows.Forms.Label();
            this.lblPastPapers = new System.Windows.Forms.Label();
            this.lblDashboard = new System.Windows.Forms.Label();
            this.picWSUlogo = new System.Windows.Forms.PictureBox();
            this.flpStudentGrid = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPostRequestCard = new System.Windows.Forms.Panel();
            this.btnback = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).BeginInit();
            this.pnlPostRequestCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSearchIcon
            // 
            this.picSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.picSearchIcon.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picSearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("picSearchIcon.Image")));
            this.picSearchIcon.Location = new System.Drawing.Point(78, 182);
            this.picSearchIcon.Name = "picSearchIcon";
            this.picSearchIcon.Size = new System.Drawing.Size(80, 45);
            this.picSearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSearchIcon.TabIndex = 17;
            this.picSearchIcon.TabStop = false;
            // 
            // lblPostPrompt
            // 
            this.lblPostPrompt.AutoSize = true;
            this.lblPostPrompt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostPrompt.Location = new System.Drawing.Point(20, 15);
            this.lblPostPrompt.Name = "lblPostPrompt";
            this.lblPostPrompt.Size = new System.Drawing.Size(302, 17);
            this.lblPostPrompt.TabIndex = 0;
            this.lblPostPrompt.Text = "Looking for a group? Post your project request:";
            // 
            // btnPostRequest
            // 
            this.btnPostRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnPostRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostRequest.ForeColor = System.Drawing.Color.White;
            this.btnPostRequest.Location = new System.Drawing.Point(23, 139);
            this.btnPostRequest.Name = "btnPostRequest";
            this.btnPostRequest.Size = new System.Drawing.Size(102, 33);
            this.btnPostRequest.TabIndex = 2;
            this.btnPostRequest.Text = "Post Request";
            this.btnPostRequest.UseVisualStyleBackColor = false;
            this.btnPostRequest.Click += new System.EventHandler(this.btnPostRequest_Click);
            // 
            // txtPostContent
            // 
            this.txtPostContent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPostContent.Location = new System.Drawing.Point(23, 36);
            this.txtPostContent.Multiline = true;
            this.txtPostContent.Name = "txtPostContent";
            this.txtPostContent.Size = new System.Drawing.Size(1106, 73);
            this.txtPostContent.TabIndex = 1;
            // 
            // txtFilterGroupmates
            // 
            this.txtFilterGroupmates.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilterGroupmates.BackColor = System.Drawing.Color.White;
            this.txtFilterGroupmates.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFilterGroupmates.Location = new System.Drawing.Point(158, 182);
            this.txtFilterGroupmates.Multiline = true;
            this.txtFilterGroupmates.Name = "txtFilterGroupmates";
            this.txtFilterGroupmates.Size = new System.Drawing.Size(1092, 45);
            this.txtFilterGroupmates.TabIndex = 16;
            this.txtFilterGroupmates.TextChanged += new System.EventHandler(this.txtFilterGroupmates_TextChanged);
            // 
            // lblGroupmatesHeader
            // 
            this.lblGroupmatesHeader.AutoSize = true;
            this.lblGroupmatesHeader.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupmatesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.lblGroupmatesHeader.Location = new System.Drawing.Point(31, 120);
            this.lblGroupmatesHeader.Name = "lblGroupmatesHeader";
            this.lblGroupmatesHeader.Size = new System.Drawing.Size(254, 40);
            this.lblGroupmatesHeader.TabIndex = 15;
            this.lblGroupmatesHeader.Text = "Find Groupmates";
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
            this.pnlNavBar.Size = new System.Drawing.Size(1306, 100);
            this.pnlNavBar.TabIndex = 14;
            // 
            // lblGroupmates
            // 
            this.lblGroupmates.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGroupmates.AutoSize = true;
            this.lblGroupmates.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGroupmates.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblGroupmates.Location = new System.Drawing.Point(760, 41);
            this.lblGroupmates.Name = "lblGroupmates";
            this.lblGroupmates.Size = new System.Drawing.Size(83, 17);
            this.lblGroupmates.TabIndex = 1;
            this.lblGroupmates.Text = "Groupmates";
            this.lblGroupmates.Click += new System.EventHandler(this.lblGroupmates_Click);
            // 
            // lblPastPapers
            // 
            this.lblPastPapers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblPastPapers.AutoSize = true;
            this.lblPastPapers.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPastPapers.Location = new System.Drawing.Point(628, 41);
            this.lblPastPapers.Name = "lblPastPapers";
            this.lblPastPapers.Size = new System.Drawing.Size(79, 17);
            this.lblPastPapers.TabIndex = 1;
            this.lblPastPapers.Text = "Past Papers";
            this.lblPastPapers.Click += new System.EventHandler(this.lblPastPapers_Click);
            // 
            // lblDashboard
            // 
            this.lblDashboard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDashboard.AutoSize = true;
            this.lblDashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDashboard.Location = new System.Drawing.Point(500, 41);
            this.lblDashboard.Name = "lblDashboard";
            this.lblDashboard.Size = new System.Drawing.Size(75, 17);
            this.lblDashboard.TabIndex = 1;
            this.lblDashboard.Text = "Dashboard";
            this.lblDashboard.Click += new System.EventHandler(this.lblDashboard_Click);
            // 
            // picWSUlogo
            // 
            this.picWSUlogo.Image = ((System.Drawing.Image)(resources.GetObject("picWSUlogo.Image")));
            this.picWSUlogo.Location = new System.Drawing.Point(25, 12);
            this.picWSUlogo.Name = "picWSUlogo";
            this.picWSUlogo.Size = new System.Drawing.Size(198, 71);
            this.picWSUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWSUlogo.TabIndex = 0;
            this.picWSUlogo.TabStop = false;
            // 
            // flpStudentGrid
            // 
            this.flpStudentGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flpStudentGrid.BackColor = System.Drawing.Color.White;
            this.flpStudentGrid.Location = new System.Drawing.Point(78, 464);
            this.flpStudentGrid.Name = "flpStudentGrid";
            this.flpStudentGrid.Size = new System.Drawing.Size(1172, 199);
            this.flpStudentGrid.TabIndex = 19;
            // 
            // pnlPostRequestCard
            // 
            this.pnlPostRequestCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlPostRequestCard.BackColor = System.Drawing.Color.White;
            this.pnlPostRequestCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPostRequestCard.Controls.Add(this.lblPostPrompt);
            this.pnlPostRequestCard.Controls.Add(this.btnPostRequest);
            this.pnlPostRequestCard.Controls.Add(this.txtPostContent);
            this.pnlPostRequestCard.Location = new System.Drawing.Point(78, 255);
            this.pnlPostRequestCard.Name = "pnlPostRequestCard";
            this.pnlPostRequestCard.Size = new System.Drawing.Size(1172, 178);
            this.pnlPostRequestCard.TabIndex = 18;
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.Location = new System.Drawing.Point(78, 684);
            this.btnback.Margin = new System.Windows.Forms.Padding(2);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(102, 39);
            this.btnback.TabIndex = 20;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1187, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "MyProfile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Find_Groupmates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1306, 825);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.picSearchIcon);
            this.Controls.Add(this.txtFilterGroupmates);
            this.Controls.Add(this.lblGroupmatesHeader);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.flpStudentGrid);
            this.Controls.Add(this.pnlPostRequestCard);
            this.Name = "Find_Groupmates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FinderForm4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FinderForm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSearchIcon)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            this.pnlNavBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).EndInit();
            this.pnlPostRequestCard.ResumeLayout(false);
            this.pnlPostRequestCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSearchIcon;
        private System.Windows.Forms.Label lblPostPrompt;
        private System.Windows.Forms.Button btnPostRequest;
        private System.Windows.Forms.TextBox txtPostContent;
        private System.Windows.Forms.TextBox txtFilterGroupmates;
        private System.Windows.Forms.Label lblGroupmatesHeader;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Label lblGroupmates;
        private System.Windows.Forms.Label lblPastPapers;
        private System.Windows.Forms.Label lblDashboard;
        private System.Windows.Forms.PictureBox picWSUlogo;
        private System.Windows.Forms.FlowLayoutPanel flpStudentGrid;
        private System.Windows.Forms.Panel pnlPostRequestCard;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Label label1;
    }
}