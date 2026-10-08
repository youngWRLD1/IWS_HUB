namespace IwsHub2
{
    partial class OTP_Verify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTP_Verify));
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnResendOTP = new System.Windows.Forms.Button();
            this.lblOTPprompt = new System.Windows.Forms.Label();
            this.lblNoOTP = new System.Windows.Forms.Label();
            this.txtOTP = new System.Windows.Forms.TextBox();
            this.lblBack = new System.Windows.Forms.Label();
            this.pnlCard = new System.Windows.Forms.Panel();
            this.pnlMailIconWrapper = new System.Windows.Forms.PictureBox();
            this.pnlCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMailIconWrapper)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerify
            // 
            this.btnVerify.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnVerify.FlatAppearance.BorderSize = 0;
            this.btnVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerify.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(48, 300);
            this.btnVerify.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(384, 45);
            this.btnVerify.TabIndex = 0;
            this.btnVerify.Text = "Verify OTP";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnResendOTP
            // 
            this.btnResendOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnResendOTP.BackColor = System.Drawing.Color.LightGray;
            this.btnResendOTP.CausesValidation = false;
            this.btnResendOTP.FlatAppearance.BorderSize = 0;
            this.btnResendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResendOTP.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.btnResendOTP.Location = new System.Drawing.Point(165, 420);
            this.btnResendOTP.Margin = new System.Windows.Forms.Padding(2);
            this.btnResendOTP.Name = "btnResendOTP";
            this.btnResendOTP.Size = new System.Drawing.Size(150, 35);
            this.btnResendOTP.TabIndex = 1;
            this.btnResendOTP.Text = "Resend OTP";
            this.btnResendOTP.UseVisualStyleBackColor = false;
            this.btnResendOTP.Click += new System.EventHandler(this.btnResendOTP_Click);
            // 
            // lblOTPprompt
            // 
            this.lblOTPprompt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblOTPprompt.AutoSize = true;
            this.lblOTPprompt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPprompt.Location = new System.Drawing.Point(10, 127);
            this.lblOTPprompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOTPprompt.Name = "lblOTPprompt";
            this.lblOTPprompt.Size = new System.Drawing.Size(484, 20);
            this.lblOTPprompt.TabIndex = 2;
            this.lblOTPprompt.Text = "We have sent a 6-digit OTP to your student mail. Please enter below";
            this.lblOTPprompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoOTP
            // 
            this.lblNoOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNoOTP.AutoSize = true;
            this.lblNoOTP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(114)))), ((int)(((byte)(128)))));
            this.lblNoOTP.Location = new System.Drawing.Point(169, 395);
            this.lblNoOTP.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOTP.Name = "lblNoOTP";
            this.lblNoOTP.Size = new System.Drawing.Size(142, 17);
            this.lblNoOTP.TabIndex = 3;
            this.lblNoOTP.Text = "Didn\'t receive the OTP?";
            this.lblNoOTP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtOTP
            // 
            this.txtOTP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOTP.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOTP.Location = new System.Drawing.Point(48, 220);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(2);
            this.txtOTP.MaxLength = 6;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Size = new System.Drawing.Size(384, 50);
            this.txtOTP.TabIndex = 4;
            this.txtOTP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtOTP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblBack
            // 
            this.lblBack.AutoSize = true;
            this.lblBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblBack.Location = new System.Drawing.Point(45, 500);
            this.lblBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBack.Name = "lblBack";
            this.lblBack.Size = new System.Drawing.Size(43, 17);
            this.lblBack.TabIndex = 5;
            this.lblBack.Text = "<Back";
            this.lblBack.Click += new System.EventHandler(this.lblBack_Click);
            // 
            // pnlCard
            // 
            this.pnlCard.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlCard.BackColor = System.Drawing.Color.White;
            this.pnlCard.Controls.Add(this.pnlMailIconWrapper);
            this.pnlCard.Controls.Add(this.lblBack);
            this.pnlCard.Controls.Add(this.txtOTP);
            this.pnlCard.Controls.Add(this.btnVerify);
            this.pnlCard.Controls.Add(this.btnResendOTP);
            this.pnlCard.Controls.Add(this.lblNoOTP);
            this.pnlCard.Controls.Add(this.lblOTPprompt);
            this.pnlCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.pnlCard.Location = new System.Drawing.Point(57, 71);
            this.pnlCard.Name = "pnlCard";
            this.pnlCard.Size = new System.Drawing.Size(505, 546);
            this.pnlCard.TabIndex = 6;
            // 
            // pnlMailIconWrapper
            // 
            this.pnlMailIconWrapper.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMailIconWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(58)))), ((int)(((byte)(138)))));
            this.pnlMailIconWrapper.Image = ((System.Drawing.Image)(resources.GetObject("pnlMailIconWrapper.Image")));
            this.pnlMailIconWrapper.Location = new System.Drawing.Point(208, 40);
            this.pnlMailIconWrapper.Name = "pnlMailIconWrapper";
            this.pnlMailIconWrapper.Size = new System.Drawing.Size(64, 64);
            this.pnlMailIconWrapper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pnlMailIconWrapper.TabIndex = 5;
            this.pnlMailIconWrapper.TabStop = false;
            // 
            // OTP_Verify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(250)))), ((int)(((byte)(251)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(618, 706);
            this.Controls.Add(this.pnlCard);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OTP_Verify";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPForm4";
            this.Load += new System.EventHandler(this.OTPForm4_Load);
            this.pnlCard.ResumeLayout(false);
            this.pnlCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlMailIconWrapper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnResendOTP;
        private System.Windows.Forms.Label lblOTPprompt;
        private System.Windows.Forms.Label lblNoOTP;
        private System.Windows.Forms.TextBox txtOTP;
        private System.Windows.Forms.Label lblBack;
        private System.Windows.Forms.Panel pnlCard;
        private System.Windows.Forms.PictureBox pnlMailIconWrapper;
    }
}