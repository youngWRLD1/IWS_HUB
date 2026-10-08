namespace IwsHub2
{
    partial class Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblsign = new System.Windows.Forms.Label();
            this.lblforgot = new System.Windows.Forms.Label();
            this.lblStudNo = new System.Windows.Forms.Label();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picWSUlogo = new System.Windows.Forms.PictureBox();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentno
            // 
            this.txtstudentno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstudentno.Location = new System.Drawing.Point(48, 200);
            this.txtstudentno.Margin = new System.Windows.Forms.Padding(2);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(344, 29);
            this.txtstudentno.TabIndex = 0;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(48, 260);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(344, 29);
            this.txtpassword.TabIndex = 1;
            this.txtpassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnlogin.FlatAppearance.BorderSize = 0;
            this.btnlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlogin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.White;
            this.btnlogin.Location = new System.Drawing.Point(48, 350);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(344, 45);
            this.btnlogin.TabIndex = 2;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblPassword.Location = new System.Drawing.Point(48, 235);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(66, 17);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(120, 125);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(190, 30);
            this.lblLogin.TabIndex = 4;
            this.lblLogin.Text = "Login to IWS Hub";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblsign
            // 
            this.lblsign.AutoSize = true;
            this.lblsign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblsign.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsign.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblsign.Location = new System.Drawing.Point(115, 435);
            this.lblsign.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsign.Name = "lblsign";
            this.lblsign.Size = new System.Drawing.Size(92, 17);
            this.lblsign.TabIndex = 5;
            this.lblsign.Text = "Sign Up        |";
            this.lblsign.Click += new System.EventHandler(this.lblsign_Click);
            // 
            // lblforgot
            // 
            this.lblforgot.AutoSize = true;
            this.lblforgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblforgot.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblforgot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.lblforgot.Location = new System.Drawing.Point(223, 435);
            this.lblforgot.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblforgot.Name = "lblforgot";
            this.lblforgot.Size = new System.Drawing.Size(111, 17);
            this.lblforgot.TabIndex = 6;
            this.lblforgot.Text = "Forgot Password";
            this.lblforgot.Click += new System.EventHandler(this.lblforgot_Click);
            // 
            // lblStudNo
            // 
            this.lblStudNo.AutoSize = true;
            this.lblStudNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblStudNo.Location = new System.Drawing.Point(48, 175);
            this.lblStudNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudNo.Name = "lblStudNo";
            this.lblStudNo.Size = new System.Drawing.Size(82, 17);
            this.lblStudNo.TabIndex = 7;
            this.lblStudNo.Text = "Student No.";
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblBack.Location = new System.Drawing.Point(35, 680);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(43, 17);
            this.lblBack.TabIndex = 8;
            this.lblBack.Text = "<Back";
            this.lblBack.Click += new System.EventHandler(this.label3_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.chkShowPassword);
            this.pnlCard.Controls.Add(this.label1);
            this.pnlCard.Controls.Add(this.picWSUlogo);
            this.pnlCard.Controls.Add(this.lblLogin);
            this.pnlCard.Controls.Add(this.lblStudNo);
            this.pnlCard.Controls.Add(this.txtstudentno);
            this.pnlCard.Controls.Add(this.lblforgot);
            this.pnlCard.Controls.Add(this.txtpassword);
            this.pnlCard.Controls.Add(this.lblsign);
            this.pnlCard.Controls.Add(this.btnlogin);
            this.pnlCard.Controls.Add(this.lblPassword);
            this.pnlCard.Location = new System.Drawing.Point(91, 56);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(436, 546);
            this.pnlCard.TabIndex = 9;
            this.pnlCard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlCard_Paint);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Checked = true;
            this.chkShowPassword.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkShowPassword.Location = new System.Drawing.Point(51, 310);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 11;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(20, 476);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "<Back";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // picWSUlogo
            // 
            this.picWSUlogo.Image = ((System.Drawing.Image)(resources.GetObject("picWSUlogo.Image")));
            this.picWSUlogo.Location = new System.Drawing.Point(120, 40);
            this.picWSUlogo.Name = "picWSUlogo";
            this.picWSUlogo.Size = new System.Drawing.Size(200, 64);
            this.picWSUlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWSUlogo.TabIndex = 9;
            this.picWSUlogo.TabStop = false;
            // 
            // Login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.ClientSize = new System.Drawing.Size(618, 682);
            this.Controls.Add(this.pnlCard);
            this.Controls.Add(this.lblBack);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(24)))), ((int)(((byte)(39)))));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWSUlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblsign;
        private System.Windows.Forms.Label lblforgot;
        private System.Windows.Forms.Label lblStudNo;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox picWSUlogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkShowPassword;
    }
}