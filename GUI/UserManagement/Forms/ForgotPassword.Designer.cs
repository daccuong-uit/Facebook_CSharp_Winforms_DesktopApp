namespace GUI.UserManagement.Forms
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
            this.pnlGoBack = new System.Windows.Forms.Panel();
            this.picGoBack = new System.Windows.Forms.PictureBox();
            this.CtxtPassword = new GUI.Components.CustomeTextBox();
            this.CtxtEmail = new GUI.Components.CustomeTextBox();
            this.llblResetPassword = new System.Windows.Forms.LinkLabel();
            this.CbtnLogin = new GUI.Components.CustomButton();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlResetBoxStep1 = new System.Windows.Forms.Panel();
            this.btnCancel = new GUI.Components.CustomButton();
            this.btnGetOTP = new GUI.Components.CustomButton();
            this.CtxtEnterEmail = new GUI.Components.CustomeTextBox();
            this.lblText2 = new System.Windows.Forms.Label();
            this.lblText1 = new System.Windows.Forms.Label();
            this.pnlResetPassword3 = new System.Windows.Forms.Panel();
            this.txtNewPassConfirm = new GUI.Components.CustomeTextBox();
            this.btnCancel2 = new GUI.Components.CustomButton();
            this.btnComplete = new GUI.Components.CustomButton();
            this.txtNewPass = new GUI.Components.CustomeTextBox();
            this.lblResetPassword3 = new System.Windows.Forms.Label();
            this.pnlResetPasswordStep2 = new System.Windows.Forms.Panel();
            this.btnSendEmailAgain = new GUI.Components.CustomButton();
            this.btnNexttoReset = new GUI.Components.CustomButton();
            this.txtOTP = new GUI.Components.CustomeTextBox();
            this.lblTextOTP = new System.Windows.Forms.Label();
            this.lnlTextStep2 = new System.Windows.Forms.Label();
            this.pnlGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBack)).BeginInit();
            this.pnlLogin.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlResetBoxStep1.SuspendLayout();
            this.pnlResetPassword3.SuspendLayout();
            this.pnlResetPasswordStep2.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowControls
            // 
            this.windowControls.Size = new System.Drawing.Size(1280, 40);
            // 
            // pnlGoBack
            // 
            this.pnlGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlGoBack.Controls.Add(this.picGoBack);
            this.pnlGoBack.Location = new System.Drawing.Point(0, 0);
            this.pnlGoBack.Name = "pnlGoBack";
            this.pnlGoBack.Size = new System.Drawing.Size(50, 40);
            this.pnlGoBack.TabIndex = 7;
            this.pnlGoBack.Click += new System.EventHandler(this.pnlGoBack_Click);
            // 
            // picGoBack
            // 
            this.picGoBack.BackColor = System.Drawing.Color.Transparent;
            this.picGoBack.Image = global::GUI.Properties.Resources._128_White_Back;
            this.picGoBack.Location = new System.Drawing.Point(13, 8);
            this.picGoBack.Name = "picGoBack";
            this.picGoBack.Size = new System.Drawing.Size(24, 24);
            this.picGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoBack.TabIndex = 6;
            this.picGoBack.TabStop = false;
            this.picGoBack.Click += new System.EventHandler(this.picGoBack_Click);
            // 
            // CtxtPassword
            // 
            this.CtxtPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtxtPassword.BackColor = System.Drawing.Color.White;
            this.CtxtPassword.BorderColor = System.Drawing.Color.LightGray;
            this.CtxtPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CtxtPassword.BorderRadius = 6;
            this.CtxtPassword.BorderSize = 1;
            this.CtxtPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CtxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtxtPassword.Location = new System.Drawing.Point(700, 10);
            this.CtxtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.CtxtPassword.Multiline = false;
            this.CtxtPassword.Name = "CtxtPassword";
            this.CtxtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CtxtPassword.PasswordChar = false;
            this.CtxtPassword.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CtxtPassword.PlaceholderText = "Mật khẩu";
            this.CtxtPassword.Size = new System.Drawing.Size(260, 50);
            this.CtxtPassword.TabIndex = 5;
            this.CtxtPassword.Texts = null;
            this.CtxtPassword.UnderlinedStyle = false;
            // 
            // CtxtEmail
            // 
            this.CtxtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CtxtEmail.BackColor = System.Drawing.Color.White;
            this.CtxtEmail.BorderColor = System.Drawing.Color.LightGray;
            this.CtxtEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CtxtEmail.BorderRadius = 6;
            this.CtxtEmail.BorderSize = 1;
            this.CtxtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CtxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtxtEmail.Location = new System.Drawing.Point(430, 10);
            this.CtxtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.CtxtEmail.Multiline = false;
            this.CtxtEmail.Name = "CtxtEmail";
            this.CtxtEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CtxtEmail.PasswordChar = false;
            this.CtxtEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CtxtEmail.PlaceholderText = "Email hoặc số điện thoại";
            this.CtxtEmail.Size = new System.Drawing.Size(262, 50);
            this.CtxtEmail.TabIndex = 4;
            this.CtxtEmail.Texts = null;
            this.CtxtEmail.UnderlinedStyle = false;
            // 
            // llblResetPassword
            // 
            this.llblResetPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.llblResetPassword.AutoSize = true;
            this.llblResetPassword.BackColor = System.Drawing.Color.Transparent;
            this.llblResetPassword.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.llblResetPassword.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.llblResetPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.llblResetPassword.Location = new System.Drawing.Point(1102, 25);
            this.llblResetPassword.Name = "llblResetPassword";
            this.llblResetPassword.Size = new System.Drawing.Size(146, 21);
            this.llblResetPassword.TabIndex = 0;
            this.llblResetPassword.TabStop = true;
            this.llblResetPassword.Text = "Bạn quên email ư?";
            // 
            // CbtnLogin
            // 
            this.CbtnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbtnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CbtnLogin.BorderRadius = 12;
            this.CbtnLogin.BorderSize = 0;
            this.CbtnLogin.FlatAppearance.BorderSize = 0;
            this.CbtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbtnLogin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CbtnLogin.ForeColor = System.Drawing.Color.White;
            this.CbtnLogin.Location = new System.Drawing.Point(970, 10);
            this.CbtnLogin.Name = "CbtnLogin";
            this.CbtnLogin.Size = new System.Drawing.Size(120, 50);
            this.CbtnLogin.TabIndex = 6;
            this.CbtnLogin.Text = "Đăng nhập";
            this.CbtnLogin.TextColor = System.Drawing.Color.White;
            this.CbtnLogin.UseVisualStyleBackColor = false;
            this.CbtnLogin.Click += new System.EventHandler(this.CbtnLogin_Click);
            // 
            // pnlLogin
            // 
            this.pnlLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLogin.BackColor = System.Drawing.Color.White;
            this.pnlLogin.Controls.Add(this.lblFacebook);
            this.pnlLogin.Controls.Add(this.llblResetPassword);
            this.pnlLogin.Controls.Add(this.CtxtPassword);
            this.pnlLogin.Controls.Add(this.CtxtEmail);
            this.pnlLogin.Controls.Add(this.CbtnLogin);
            this.pnlLogin.Location = new System.Drawing.Point(0, 40);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(1280, 70);
            this.pnlLogin.TabIndex = 8;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.BackColor = System.Drawing.Color.Transparent;
            this.lblFacebook.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFacebook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblFacebook.Location = new System.Drawing.Point(10, 15);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(163, 40);
            this.lblFacebook.TabIndex = 0;
            this.lblFacebook.Text = "Facebook";
            // 
            // pnlContent
            // 
            this.pnlContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.pnlContent.Controls.Add(this.pnlResetBoxStep1);
            this.pnlContent.Controls.Add(this.pnlResetPassword3);
            this.pnlContent.Controls.Add(this.pnlResetPasswordStep2);
            this.pnlContent.Location = new System.Drawing.Point(0, 110);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1280, 610);
            this.pnlContent.TabIndex = 9;
            // 
            // pnlResetBoxStep1
            // 
            this.pnlResetBoxStep1.BackColor = System.Drawing.Color.White;
            this.pnlResetBoxStep1.Controls.Add(this.btnCancel);
            this.pnlResetBoxStep1.Controls.Add(this.btnGetOTP);
            this.pnlResetBoxStep1.Controls.Add(this.CtxtEnterEmail);
            this.pnlResetBoxStep1.Controls.Add(this.lblText2);
            this.pnlResetBoxStep1.Controls.Add(this.lblText1);
            this.pnlResetBoxStep1.Location = new System.Drawing.Point(390, 150);
            this.pnlResetBoxStep1.Name = "pnlResetBoxStep1";
            this.pnlResetBoxStep1.Size = new System.Drawing.Size(500, 250);
            this.pnlResetBoxStep1.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.BorderRadius = 12;
            this.btnCancel.BorderSize = 0;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(278, 190);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(80, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.TextColor = System.Drawing.Color.Black;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGetOTP
            // 
            this.btnGetOTP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnGetOTP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnGetOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnGetOTP.BorderRadius = 12;
            this.btnGetOTP.BorderSize = 0;
            this.btnGetOTP.FlatAppearance.BorderSize = 0;
            this.btnGetOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetOTP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGetOTP.ForeColor = System.Drawing.Color.White;
            this.btnGetOTP.Location = new System.Drawing.Point(364, 190);
            this.btnGetOTP.Name = "btnGetOTP";
            this.btnGetOTP.Size = new System.Drawing.Size(120, 40);
            this.btnGetOTP.TabIndex = 2;
            this.btnGetOTP.Text = "Lấy mã";
            this.btnGetOTP.TextColor = System.Drawing.Color.White;
            this.btnGetOTP.UseVisualStyleBackColor = false;
            this.btnGetOTP.Click += new System.EventHandler(this.btnGetOTP_Click);
            // 
            // CtxtEnterEmail
            // 
            this.CtxtEnterEmail.BackColor = System.Drawing.Color.White;
            this.CtxtEnterEmail.BorderColor = System.Drawing.Color.LightGray;
            this.CtxtEnterEmail.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.CtxtEnterEmail.BorderRadius = 6;
            this.CtxtEnterEmail.BorderSize = 1;
            this.CtxtEnterEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.CtxtEnterEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CtxtEnterEmail.Location = new System.Drawing.Point(21, 102);
            this.CtxtEnterEmail.Margin = new System.Windows.Forms.Padding(4);
            this.CtxtEnterEmail.Multiline = false;
            this.CtxtEnterEmail.Name = "CtxtEnterEmail";
            this.CtxtEnterEmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.CtxtEnterEmail.PasswordChar = false;
            this.CtxtEnterEmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.CtxtEnterEmail.PlaceholderText = "Nhập email";
            this.CtxtEnterEmail.Size = new System.Drawing.Size(463, 50);
            this.CtxtEnterEmail.TabIndex = 1;
            this.CtxtEnterEmail.Texts = null;
            this.CtxtEnterEmail.UnderlinedStyle = false;
            // 
            // lblText2
            // 
            this.lblText2.AllowDrop = true;
            this.lblText2.AutoEllipsis = true;
            this.lblText2.BackColor = System.Drawing.Color.Transparent;
            this.lblText2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblText2.Location = new System.Drawing.Point(17, 66);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(467, 32);
            this.lblText2.TabIndex = 0;
            this.lblText2.Text = "Vui lòng nhập email để nhận mã OTP";
            // 
            // lblText1
            // 
            this.lblText1.AllowDrop = true;
            this.lblText1.AutoEllipsis = true;
            this.lblText1.BackColor = System.Drawing.Color.Transparent;
            this.lblText1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblText1.Location = new System.Drawing.Point(15, 15);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(328, 35);
            this.lblText1.TabIndex = 0;
            this.lblText1.Text = "Lấy lại mật khẩu của bạn";
            // 
            // pnlResetPassword3
            // 
            this.pnlResetPassword3.BackColor = System.Drawing.Color.White;
            this.pnlResetPassword3.Controls.Add(this.txtNewPassConfirm);
            this.pnlResetPassword3.Controls.Add(this.btnCancel2);
            this.pnlResetPassword3.Controls.Add(this.btnComplete);
            this.pnlResetPassword3.Controls.Add(this.txtNewPass);
            this.pnlResetPassword3.Controls.Add(this.lblResetPassword3);
            this.pnlResetPassword3.Location = new System.Drawing.Point(390, 150);
            this.pnlResetPassword3.Name = "pnlResetPassword3";
            this.pnlResetPassword3.Size = new System.Drawing.Size(500, 250);
            this.pnlResetPassword3.TabIndex = 12;
            this.pnlResetPassword3.Visible = false;
            // 
            // txtNewPassConfirm
            // 
            this.txtNewPassConfirm.BackColor = System.Drawing.Color.White;
            this.txtNewPassConfirm.BorderColor = System.Drawing.Color.LightGray;
            this.txtNewPassConfirm.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.txtNewPassConfirm.BorderRadius = 6;
            this.txtNewPassConfirm.BorderSize = 1;
            this.txtNewPassConfirm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewPassConfirm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPassConfirm.Location = new System.Drawing.Point(21, 117);
            this.txtNewPassConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassConfirm.Multiline = false;
            this.txtNewPassConfirm.Name = "txtNewPassConfirm";
            this.txtNewPassConfirm.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPassConfirm.PasswordChar = false;
            this.txtNewPassConfirm.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPassConfirm.PlaceholderText = "Xác nhận mật khẩu";
            this.txtNewPassConfirm.Size = new System.Drawing.Size(463, 50);
            this.txtNewPassConfirm.TabIndex = 2;
            this.txtNewPassConfirm.Texts = null;
            this.txtNewPassConfirm.UnderlinedStyle = false;
            // 
            // btnCancel2
            // 
            this.btnCancel2.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel2.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnCancel2.BorderColor = System.Drawing.Color.LightGray;
            this.btnCancel2.BorderRadius = 12;
            this.btnCancel2.BorderSize = 0;
            this.btnCancel2.FlatAppearance.BorderSize = 0;
            this.btnCancel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCancel2.ForeColor = System.Drawing.Color.Black;
            this.btnCancel2.Location = new System.Drawing.Point(278, 190);
            this.btnCancel2.Name = "btnCancel2";
            this.btnCancel2.Size = new System.Drawing.Size(80, 40);
            this.btnCancel2.TabIndex = 4;
            this.btnCancel2.Text = "Hủy";
            this.btnCancel2.TextColor = System.Drawing.Color.Black;
            this.btnCancel2.UseVisualStyleBackColor = false;
            this.btnCancel2.Click += new System.EventHandler(this.btnCancel2_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComplete.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComplete.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComplete.BorderRadius = 12;
            this.btnComplete.BorderSize = 0;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnComplete.ForeColor = System.Drawing.Color.White;
            this.btnComplete.Location = new System.Drawing.Point(364, 190);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(120, 40);
            this.btnComplete.TabIndex = 3;
            this.btnComplete.Text = "Hoàn thành";
            this.btnComplete.TextColor = System.Drawing.Color.White;
            this.btnComplete.UseVisualStyleBackColor = false;
            this.btnComplete.Click += new System.EventHandler(this.btnComplete_Click);
            // 
            // txtNewPass
            // 
            this.txtNewPass.BackColor = System.Drawing.Color.White;
            this.txtNewPass.BorderColor = System.Drawing.Color.LightGray;
            this.txtNewPass.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.txtNewPass.BorderRadius = 6;
            this.txtNewPass.BorderSize = 1;
            this.txtNewPass.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtNewPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNewPass.Location = new System.Drawing.Point(21, 59);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPass.Multiline = false;
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNewPass.PasswordChar = false;
            this.txtNewPass.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNewPass.PlaceholderText = "Nhập mật khẩu mới";
            this.txtNewPass.Size = new System.Drawing.Size(463, 50);
            this.txtNewPass.TabIndex = 1;
            this.txtNewPass.Texts = null;
            this.txtNewPass.UnderlinedStyle = false;
            // 
            // lblResetPassword3
            // 
            this.lblResetPassword3.AllowDrop = true;
            this.lblResetPassword3.AutoEllipsis = true;
            this.lblResetPassword3.BackColor = System.Drawing.Color.Transparent;
            this.lblResetPassword3.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblResetPassword3.Location = new System.Drawing.Point(15, 15);
            this.lblResetPassword3.Name = "lblResetPassword3";
            this.lblResetPassword3.Size = new System.Drawing.Size(328, 35);
            this.lblResetPassword3.TabIndex = 0;
            this.lblResetPassword3.Text = "Lấy lại mật khẩu của bạn";
            // 
            // pnlResetPasswordStep2
            // 
            this.pnlResetPasswordStep2.BackColor = System.Drawing.Color.White;
            this.pnlResetPasswordStep2.Controls.Add(this.btnSendEmailAgain);
            this.pnlResetPasswordStep2.Controls.Add(this.btnNexttoReset);
            this.pnlResetPasswordStep2.Controls.Add(this.txtOTP);
            this.pnlResetPasswordStep2.Controls.Add(this.lblTextOTP);
            this.pnlResetPasswordStep2.Controls.Add(this.lnlTextStep2);
            this.pnlResetPasswordStep2.Location = new System.Drawing.Point(390, 150);
            this.pnlResetPasswordStep2.Name = "pnlResetPasswordStep2";
            this.pnlResetPasswordStep2.Size = new System.Drawing.Size(500, 250);
            this.pnlResetPasswordStep2.TabIndex = 11;
            this.pnlResetPasswordStep2.Visible = false;
            // 
            // btnSendEmailAgain
            // 
            this.btnSendEmailAgain.BackColor = System.Drawing.Color.LightGray;
            this.btnSendEmailAgain.BackgroundColor = System.Drawing.Color.LightGray;
            this.btnSendEmailAgain.BorderColor = System.Drawing.Color.LightGray;
            this.btnSendEmailAgain.BorderRadius = 12;
            this.btnSendEmailAgain.BorderSize = 0;
            this.btnSendEmailAgain.FlatAppearance.BorderSize = 0;
            this.btnSendEmailAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendEmailAgain.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendEmailAgain.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmailAgain.Location = new System.Drawing.Point(278, 190);
            this.btnSendEmailAgain.Name = "btnSendEmailAgain";
            this.btnSendEmailAgain.Size = new System.Drawing.Size(80, 40);
            this.btnSendEmailAgain.TabIndex = 3;
            this.btnSendEmailAgain.Text = "Gửi lại";
            this.btnSendEmailAgain.TextColor = System.Drawing.Color.Black;
            this.btnSendEmailAgain.UseVisualStyleBackColor = false;
            this.btnSendEmailAgain.Click += new System.EventHandler(this.btnSendEmailAgain_Click);
            // 
            // btnNexttoReset
            // 
            this.btnNexttoReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnNexttoReset.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnNexttoReset.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnNexttoReset.BorderRadius = 12;
            this.btnNexttoReset.BorderSize = 0;
            this.btnNexttoReset.FlatAppearance.BorderSize = 0;
            this.btnNexttoReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNexttoReset.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnNexttoReset.ForeColor = System.Drawing.Color.White;
            this.btnNexttoReset.Location = new System.Drawing.Point(364, 190);
            this.btnNexttoReset.Name = "btnNexttoReset";
            this.btnNexttoReset.Size = new System.Drawing.Size(120, 40);
            this.btnNexttoReset.TabIndex = 2;
            this.btnNexttoReset.Text = "Tiếp tục";
            this.btnNexttoReset.TextColor = System.Drawing.Color.White;
            this.btnNexttoReset.UseVisualStyleBackColor = false;
            this.btnNexttoReset.Click += new System.EventHandler(this.btnNexttoReset_Click);
            // 
            // txtOTP
            // 
            this.txtOTP.BackColor = System.Drawing.Color.White;
            this.txtOTP.BorderColor = System.Drawing.Color.LightGray;
            this.txtOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.txtOTP.BorderRadius = 6;
            this.txtOTP.BorderSize = 1;
            this.txtOTP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOTP.Location = new System.Drawing.Point(21, 102);
            this.txtOTP.Margin = new System.Windows.Forms.Padding(4);
            this.txtOTP.Multiline = false;
            this.txtOTP.Name = "txtOTP";
            this.txtOTP.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtOTP.PasswordChar = false;
            this.txtOTP.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtOTP.PlaceholderText = "Nhập mã OTP";
            this.txtOTP.Size = new System.Drawing.Size(463, 50);
            this.txtOTP.TabIndex = 1;
            this.txtOTP.Texts = null;
            this.txtOTP.UnderlinedStyle = false;
            // 
            // lblTextOTP
            // 
            this.lblTextOTP.AllowDrop = true;
            this.lblTextOTP.AutoEllipsis = true;
            this.lblTextOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblTextOTP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTextOTP.Location = new System.Drawing.Point(17, 66);
            this.lblTextOTP.Name = "lblTextOTP";
            this.lblTextOTP.Size = new System.Drawing.Size(467, 32);
            this.lblTextOTP.TabIndex = 0;
            this.lblTextOTP.Text = "Vui lòng nhập mã OTP";
            // 
            // lnlTextStep2
            // 
            this.lnlTextStep2.AllowDrop = true;
            this.lnlTextStep2.AutoEllipsis = true;
            this.lnlTextStep2.BackColor = System.Drawing.Color.Transparent;
            this.lnlTextStep2.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lnlTextStep2.Location = new System.Drawing.Point(15, 15);
            this.lnlTextStep2.Name = "lnlTextStep2";
            this.lnlTextStep2.Size = new System.Drawing.Size(328, 35);
            this.lnlTextStep2.TabIndex = 0;
            this.lnlTextStep2.Text = "Lấy lại mật khẩu của bạn";
            // 
            // ForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlGoBack);
            this.Controls.Add(this.pnlLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ForgotPassword";
            this.Text = "ForgotPassword";
            this.Controls.SetChildIndex(this.windowControls, 0);
            this.Controls.SetChildIndex(this.pnlLogin, 0);
            this.Controls.SetChildIndex(this.pnlGoBack, 0);
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.pnlGoBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGoBack)).EndInit();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlResetBoxStep1.ResumeLayout(false);
            this.pnlResetPassword3.ResumeLayout(false);
            this.pnlResetPasswordStep2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlGoBack;
        private System.Windows.Forms.PictureBox picGoBack;
        private Components.CustomeTextBox CtxtPassword;
        private Components.CustomeTextBox CtxtEmail;
        private System.Windows.Forms.LinkLabel llblResetPassword;
        private Components.CustomButton CbtnLogin;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlResetBoxStep1;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private Components.CustomeTextBox CtxtEnterEmail;
        private Components.CustomButton btnGetOTP;
        private Components.CustomButton btnCancel;
        private System.Windows.Forms.Panel pnlResetPasswordStep2;
        private Components.CustomButton btnSendEmailAgain;
        private Components.CustomButton btnNexttoReset;
        private Components.CustomeTextBox txtOTP;
        private System.Windows.Forms.Label lblTextOTP;
        private System.Windows.Forms.Label lnlTextStep2;
        private System.Windows.Forms.Panel pnlResetPassword3;
        private Components.CustomButton btnCancel2;
        private Components.CustomButton btnComplete;
        private Components.CustomeTextBox txtNewPass;
        private System.Windows.Forms.Label lblResetPassword3;
        private Components.CustomeTextBox txtNewPassConfirm;
    }
}