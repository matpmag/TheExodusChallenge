﻿namespace Exodus_Challenge
{
    partial class frmRegister
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.inpUser = new System.Windows.Forms.TextBox();
            this.inpPass = new System.Windows.Forms.TextBox();
            this.pbxAvatar = new System.Windows.Forms.PictureBox();
            this.inpMail = new System.Windows.Forms.TextBox();
            this.inpPassConfirm = new System.Windows.Forms.TextBox();
            this.nudTempAvatar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(70, 333);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(184, 36);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(212, 377);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 33);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // inpUser
            // 
            this.inpUser.ForeColor = System.Drawing.Color.Silver;
            this.inpUser.Location = new System.Drawing.Point(70, 188);
            this.inpUser.Name = "inpUser";
            this.inpUser.Size = new System.Drawing.Size(184, 30);
            this.inpUser.TabIndex = 2;
            this.inpUser.Text = "Username";
            this.inpUser.Click += new System.EventHandler(this.inpUser_Click);
            this.inpUser.TextChanged += new System.EventHandler(this.inpUser_TextChanged);
            // 
            // inpPass
            // 
            this.inpPass.ForeColor = System.Drawing.Color.Silver;
            this.inpPass.Location = new System.Drawing.Point(70, 260);
            this.inpPass.Name = "inpPass";
            this.inpPass.Size = new System.Drawing.Size(184, 30);
            this.inpPass.TabIndex = 3;
            this.inpPass.Text = "Password";
            this.inpPass.Click += new System.EventHandler(this.inpPass_Click);
            this.inpPass.TextChanged += new System.EventHandler(this.inpPass_TextChanged);
            // 
            // pbxAvatar
            // 
            this.pbxAvatar.BackColor = System.Drawing.Color.Transparent;
            this.pbxAvatar.ErrorImage = global::Exodus_Challenge.Properties.Resources.avatar;
            this.pbxAvatar.Image = global::Exodus_Challenge.Properties.Resources.avatar;
            this.pbxAvatar.Location = new System.Drawing.Point(98, 26);
            this.pbxAvatar.Name = "pbxAvatar";
            this.pbxAvatar.Size = new System.Drawing.Size(125, 125);
            this.pbxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAvatar.TabIndex = 4;
            this.pbxAvatar.TabStop = false;
            // 
            // inpMail
            // 
            this.inpMail.ForeColor = System.Drawing.Color.Silver;
            this.inpMail.Location = new System.Drawing.Point(70, 224);
            this.inpMail.Name = "inpMail";
            this.inpMail.Size = new System.Drawing.Size(184, 30);
            this.inpMail.TabIndex = 6;
            this.inpMail.Text = "Email";
            // 
            // inpPassConfirm
            // 
            this.inpPassConfirm.ForeColor = System.Drawing.Color.Silver;
            this.inpPassConfirm.Location = new System.Drawing.Point(70, 296);
            this.inpPassConfirm.Name = "inpPassConfirm";
            this.inpPassConfirm.Size = new System.Drawing.Size(184, 30);
            this.inpPassConfirm.TabIndex = 5;
            this.inpPassConfirm.Text = "Confirm";
            // 
            // nudTempAvatar
            // 
            this.nudTempAvatar.Location = new System.Drawing.Point(229, 121);
            this.nudTempAvatar.Name = "nudTempAvatar";
            this.nudTempAvatar.Size = new System.Drawing.Size(56, 30);
            this.nudTempAvatar.TabIndex = 7;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Exodus_Challenge.Properties.Resources.hieroglyph;
            this.ClientSize = new System.Drawing.Size(317, 416);
            this.Controls.Add(this.nudTempAvatar);
            this.Controls.Add(this.inpMail);
            this.Controls.Add(this.inpPassConfirm);
            this.Controls.Add(this.pbxAvatar);
            this.Controls.Add(this.inpPass);
            this.Controls.Add(this.inpUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegister);
            this.Font = new System.Drawing.Font("Segoe Print", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pbxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTempAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox inpUser;
        private System.Windows.Forms.TextBox inpPass;
        private System.Windows.Forms.PictureBox pbxAvatar;
        private System.Windows.Forms.TextBox inpMail;
        private System.Windows.Forms.TextBox inpPassConfirm;
        private System.Windows.Forms.NumericUpDown nudTempAvatar;
    }
}