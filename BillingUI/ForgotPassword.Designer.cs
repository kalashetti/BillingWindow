namespace BillingUI
{
    partial class ForgotPassword
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword));
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.lblValidationMessage = new System.Windows.Forms.Label();
			this.txtNewPasswordConfirm = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblLogin = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtNewPassword = new System.Windows.Forms.TextBox();
			this.lblPassword = new System.Windows.Forms.Label();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.White;
			this.label1.Location = new System.Drawing.Point(201, 46);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(170, 23);
			this.label1.TabIndex = 8;
			this.label1.Text = "Change Password";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.lblValidationMessage);
			this.groupBox1.Controls.Add(this.txtNewPasswordConfirm);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.btnReset);
			this.groupBox1.Controls.Add(this.lblLogin);
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.Controls.Add(this.txtNewPassword);
			this.groupBox1.Controls.Add(this.lblPassword);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.ForeColor = System.Drawing.Color.White;
			this.groupBox1.Location = new System.Drawing.Point(76, 108);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(383, 289);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			// 
			// lblValidationMessage
			// 
			this.lblValidationMessage.AutoSize = true;
			this.lblValidationMessage.ForeColor = System.Drawing.Color.Red;
			this.lblValidationMessage.Location = new System.Drawing.Point(52, 194);
			this.lblValidationMessage.Name = "lblValidationMessage";
			this.lblValidationMessage.Size = new System.Drawing.Size(0, 18);
			this.lblValidationMessage.TabIndex = 8;
			// 
			// txtNewPasswordConfirm
			// 
			this.txtNewPasswordConfirm.Location = new System.Drawing.Point(223, 156);
			this.txtNewPasswordConfirm.Name = "txtNewPasswordConfirm";
			this.txtNewPasswordConfirm.PasswordChar = '*';
			this.txtNewPasswordConfirm.Size = new System.Drawing.Size(117, 24);
			this.txtNewPasswordConfirm.TabIndex = 7;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(49, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(166, 18);
			this.label2.TabIndex = 6;
			this.label2.Text = "Confirm New Pasword :";
			// 
			// btnReset
			// 
			this.btnReset.FlatAppearance.BorderSize = 0;
			this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnReset.ForeColor = System.Drawing.Color.Black;
			this.btnReset.Location = new System.Drawing.Point(265, 217);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(75, 37);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "Clear";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// lblLogin
			// 
			this.lblLogin.AutoSize = true;
			this.lblLogin.Location = new System.Drawing.Point(49, 59);
			this.lblLogin.Name = "lblLogin";
			this.lblLogin.Size = new System.Drawing.Size(164, 18);
			this.lblLogin.TabIndex = 0;
			this.lblLogin.Text = "User Name                   :";
			// 
			// btnLogin
			// 
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.btnLogin.ForeColor = System.Drawing.Color.Black;
			this.btnLogin.Location = new System.Drawing.Point(158, 217);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(75, 37);
			this.btnLogin.TabIndex = 2;
			this.btnLogin.Text = "Submit";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtNewPassword
			// 
			this.txtNewPassword.Location = new System.Drawing.Point(223, 104);
			this.txtNewPassword.Name = "txtNewPassword";
			this.txtNewPassword.PasswordChar = '*';
			this.txtNewPassword.Size = new System.Drawing.Size(117, 24);
			this.txtNewPassword.TabIndex = 4;
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Location = new System.Drawing.Point(49, 107);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(165, 18);
			this.lblPassword.TabIndex = 1;
			this.lblPassword.Text = "New Pasword               :";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(223, 56);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(117, 24);
			this.txtUserName.TabIndex = 3;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Location = new System.Drawing.Point(76, 32);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 53);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			// 
			// ForgotPassword
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(90)))), ((int)(((byte)(92)))));
			this.ClientSize = new System.Drawing.Size(546, 505);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ForgotPassword";
			this.Text = "Change Password";
			this.Load += new System.EventHandler(this.ForgotPassword_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.TextBox txtNewPasswordConfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValidationMessage;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}