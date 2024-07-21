namespace GUI.UserManagement.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.lblTextFace = new System.Windows.Forms.Label();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnChangeLan = new System.Windows.Forms.Button();
            this.pnlLoginBox = new System.Windows.Forms.Panel();
            this.CbtnRegister = new GUI.Components.CustomButton();
            this.llblResetPassword = new System.Windows.Forms.LinkLabel();
            this.CtxtPassword = new GUI.Components.CustomeTextBox();
            this.CtxtEmail = new GUI.Components.CustomeTextBox();
            this.CbtnLogin = new GUI.Components.CustomButton();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlLoginBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowControls
            // 
            this.windowControls.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowControls.Dock = System.Windows.Forms.DockStyle.None;
            this.windowControls.Size = new System.Drawing.Size(1280, 40);
            // 
            // pnlTitle
            // 
            this.pnlTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTitle.BackColor = System.Drawing.Color.Transparent;
            this.pnlTitle.Controls.Add(this.lblTextFace);
            this.pnlTitle.Controls.Add(this.lblFacebook);
            this.pnlTitle.Location = new System.Drawing.Point(175, 150);
            this.pnlTitle.MinimumSize = new System.Drawing.Size(500, 235);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(500, 235);
            this.pnlTitle.TabIndex = 2;
            // 
            // lblTextFace
            // 
            this.lblTextFace.AllowDrop = true;
            this.lblTextFace.AutoEllipsis = true;
            this.lblTextFace.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTextFace.Location = new System.Drawing.Point(10, 85);
            this.lblTextFace.Name = "lblTextFace";
            this.lblTextFace.Size = new System.Drawing.Size(490, 66);
            this.lblTextFace.TabIndex = 0;
            this.lblTextFace.Text = "Facebook giúp bạn kết nối và chia sẻ với mọi người trong cuộc sống của bạn.";
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblFacebook.Location = new System.Drawing.Point(0, 0);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(294, 73);
            this.lblFacebook.TabIndex = 0;
            this.lblFacebook.Text = "Facebook";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.pnlContent.Controls.Add(this.button1);
            this.pnlContent.Controls.Add(this.btnChangeLan);
            this.pnlContent.Controls.Add(this.pnlLoginBox);
            this.pnlContent.Controls.Add(this.pnlTitle);
            this.pnlContent.Location = new System.Drawing.Point(0, 40);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1280, 685);
            this.pnlContent.TabIndex = 3;
            // 
            // btnChangeLan
            // 
            this.btnChangeLan.BackColor = System.Drawing.Color.Transparent;
            this.btnChangeLan.FlatAppearance.BorderSize = 0;
            this.btnChangeLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLan.Image = global::GUI.Properties.Resources._32_black_vietnam;
            this.btnChangeLan.Location = new System.Drawing.Point(3, 0);
            this.btnChangeLan.Name = "btnChangeLan";
            this.btnChangeLan.Size = new System.Drawing.Size(38, 33);
            this.btnChangeLan.TabIndex = 4;
            this.btnChangeLan.UseVisualStyleBackColor = false;
            this.btnChangeLan.Click += new System.EventHandler(this.btnChangeLan_Click);
            // 
            // pnlLoginBox
            // 
            this.pnlLoginBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlLoginBox.BackColor = System.Drawing.Color.White;
            this.pnlLoginBox.Controls.Add(this.CbtnRegister);
            this.pnlLoginBox.Controls.Add(this.llblResetPassword);
            this.pnlLoginBox.Controls.Add(this.CtxtPassword);
            this.pnlLoginBox.Controls.Add(this.CtxtEmail);
            this.pnlLoginBox.Controls.Add(this.CbtnLogin);
            this.pnlLoginBox.Location = new System.Drawing.Point(780, 130);
            this.pnlLoginBox.Name = "pnlLoginBox";
            this.pnlLoginBox.Size = new System.Drawing.Size(340, 300);
            this.pnlLoginBox.TabIndex = 8;
            // 
            // CbtnRegister
            // 
            this.CbtnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CbtnRegister.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CbtnRegister.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.CbtnRegister.BorderRadius = 20;
            this.CbtnRegister.BorderSize = 0;
            this.CbtnRegister.FlatAppearance.BorderSize = 0;
            this.CbtnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbtnRegister.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbtnRegister.ForeColor = System.Drawing.Color.White;
            this.CbtnRegister.Location = new System.Drawing.Point(60, 240);
            this.CbtnRegister.Name = "CbtnRegister";
            this.CbtnRegister.Size = new System.Drawing.Size(220, 47);
            this.CbtnRegister.TabIndex = 5;
            this.CbtnRegister.Text = "Tạo tài khoản mới";
            this.CbtnRegister.TextColor = System.Drawing.Color.White;
            this.CbtnRegister.UseVisualStyleBackColor = false;
            this.CbtnRegister.Click += new System.EventHandler(this.CbtnRegister_Click);
            // 
            // llblResetPassword
            // 
            this.llblResetPassword.AutoSize = true;
            this.llblResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblResetPassword.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblResetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblResetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.llblResetPassword.Location = new System.Drawing.Point(110, 195);
            this.llblResetPassword.Name = "llblResetPassword";
            this.llblResetPassword.Size = new System.Drawing.Size(108, 19);
            this.llblResetPassword.TabIndex = 4;
            this.llblResetPassword.TabStop = true;
            this.llblResetPassword.Text = "Quên mật khẩu?";
            this.llblResetPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llblResetPassword_LinkClicked);
            // 
            // CtxtPassword
            // 
            this.CtxtPassword.BackColor = System.Drawing.Color.White;
            this.CtxtPassword.BorderColor = System.Drawing.Color.LightGray;
            this.CtxtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CtxtPassword.BorderRadius = 6;
            this.CtxtPassword.BorderSize = 1;
            this.CtxtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CtxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtxtPassword.Location = new System.Drawing.Point(10, 70);
            this.CtxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.CtxtPassword.Multiline = false;
            this.CtxtPassword.Name = "CtxtPassword";
            this.CtxtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CtxtPassword.PasswordChar = false;
            this.CtxtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CtxtPassword.PlaceholderText = "Mật khẩu";
            this.CtxtPassword.Size = new System.Drawing.Size(320, 50);
            this.CtxtPassword.TabIndex = 2;
            this.CtxtPassword.Texts = null;
            this.CtxtPassword.UnderlinedStyle = false;
            // 
            // CtxtEmail
            // 
            this.CtxtEmail.BackColor = System.Drawing.Color.White;
            this.CtxtEmail.BorderColor = System.Drawing.Color.LightGray;
            this.CtxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CtxtEmail.BorderRadius = 6;
            this.CtxtEmail.BorderSize = 1;
            this.CtxtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CtxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtxtEmail.Location = new System.Drawing.Point(10, 10);
            this.CtxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.CtxtEmail.Multiline = false;
            this.CtxtEmail.Name = "CtxtEmail";
            this.CtxtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CtxtEmail.PasswordChar = false;
            this.CtxtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CtxtEmail.PlaceholderText = "Tên đăng nhập";
            this.CtxtEmail.Size = new System.Drawing.Size(320, 50);
            this.CtxtEmail.TabIndex = 1;
            this.CtxtEmail.Texts = null;
            this.CtxtEmail.UnderlinedStyle = false;
            // 
            // CbtnLogin
            // 
            this.CbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BorderRadius = 12;
            this.CbtnLogin.BorderSize = 0;
            this.CbtnLogin.FlatAppearance.BorderSize = 0;
            this.CbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbtnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbtnLogin.ForeColor = System.Drawing.Color.White;
            this.CbtnLogin.Location = new System.Drawing.Point(10, 130);
            this.CbtnLogin.Name = "CbtnLogin";
            this.CbtnLogin.Size = new System.Drawing.Size(320, 47);
            this.CbtnLogin.TabIndex = 3;
            this.CbtnLogin.Text = "Đăng nhập";
            this.CbtnLogin.TextColor = System.Drawing.Color.White;
            this.CbtnLogin.UseVisualStyleBackColor = false;
            this.CbtnLogin.Click += new System.EventHandler(this.CbtnLogin_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::GUI.Properties.Resources._32_black_empty_moon;
            this.button1.Location = new System.Drawing.Point(3, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 33);
            this.button1.TabIndex = 9;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(128, 72);
            this.Name = "LoginForm";
            this.Text = "Facebook - Đăng nhập hoặc đăng ký";
            this.Controls.SetChildIndex(this.windowControls, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlLoginBox.ResumeLayout(false);
            this.pnlLoginBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Label lblTextFace;
        private Components.CustomButton CbtnLogin;
        private Components.CustomButton CbtnRegister;
        private System.Windows.Forms.LinkLabel llblResetPassword;
        private Components.CustomeTextBox CtxtEmail;
        private Components.CustomeTextBox CtxtPassword;
        private System.Windows.Forms.Panel pnlLoginBox;
        private System.Windows.Forms.Button btnChangeLan;
        private System.Windows.Forms.Button button1;
    }
}