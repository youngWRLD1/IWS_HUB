namespace IwsHub2
{
    partial class Req_Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Req_Password));
            this.txtstudentno = new System.Windows.Forms.TextBox();
            this.btncontinue = new System.Windows.Forms.Button();
            this.lblback = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStudNo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstudentno
            // 
            this.txtstudentno.Location = new System.Drawing.Point(73, 246);
            this.txtstudentno.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtstudentno.Name = "txtstudentno";
            this.txtstudentno.Size = new System.Drawing.Size(320, 25);
            this.txtstudentno.TabIndex = 1;
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.Navy;
            this.btncontinue.ForeColor = System.Drawing.Color.White;
            this.btncontinue.Location = new System.Drawing.Point(73, 314);
            this.btncontinue.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(320, 69);
            this.btncontinue.TabIndex = 2;
            this.btncontinue.Text = "Continue";
            this.btncontinue.UseVisualStyleBackColor = false;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // lblback
            // 
            this.lblback.AutoSize = true;
            this.lblback.ForeColor = System.Drawing.Color.Navy;
            this.lblback.Location = new System.Drawing.Point(70, 423);
            this.lblback.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblback.Name = "lblback";
            this.lblback.Size = new System.Drawing.Size(43, 17);
            this.lblback.TabIndex = 3;
            this.lblback.Text = "<Back";
            this.lblback.Click += new System.EventHandler(this.lblback_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblStudNo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblback);
            this.panel1.Controls.Add(this.txtstudentno);
            this.panel1.Controls.Add(this.btncontinue);
            this.panel1.Location = new System.Drawing.Point(57, 71);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(505, 546);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lblStudNo
            // 
            this.lblStudNo.AutoSize = true;
            this.lblStudNo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.lblStudNo.Location = new System.Drawing.Point(76, 215);
            this.lblStudNo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStudNo.Name = "lblStudNo";
            this.lblStudNo.Size = new System.Drawing.Size(110, 17);
            this.lblStudNo.TabIndex = 8;
            this.lblStudNo.Text = "Student Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Request Password";
            // 
            // Req_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 682);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Req_Password";
            this.Text = "requestpasswordForm4";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtstudentno;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.Label lblback;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStudNo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}