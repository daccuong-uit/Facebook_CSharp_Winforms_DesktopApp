namespace GUI.NewsFeed.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblFacebook = new System.Windows.Forms.Label();
            this.pnlMessengerMini = new System.Windows.Forms.Panel();
            this.lblTextChat = new System.Windows.Forms.Label();
            this.txtSearchInMess = new GUI.Components.CustomeInpputTextBox();
            this.pnlGoToMess = new System.Windows.Forms.Panel();
            this.lblGoToMessenger = new System.Windows.Forms.LinkLabel();
            this.btnComunication = new GUI.Components.CustomButton();
            this.btnMessageBox = new GUI.Components.CustomButton();
            this.flpListFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.users6 = new GUI.Controls.ChatControls.MyUserControl();
            this.pnlGoBack = new System.Windows.Forms.Panel();
            this.pnlControlTab = new System.Windows.Forms.Panel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearchOnFace = new System.Windows.Forms.TextBox();
            this.customeInpputTextBox1 = new GUI.Components.CustomeInpputTextBox();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.customButton5 = new GUI.Components.CustomButton();
            this.btnMyUser = new GUI.Components.CustomButton();
            this.btnGotoMyUser = new GUI.Components.CustomButton();
            this.pnlProfile = new GUI.Controls.Custome.CustomePanel();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.picSearch = new System.Windows.Forms.PictureBox();
            this.btnGroup = new System.Windows.Forms.Button();
            this.btnVideo = new System.Windows.Forms.Button();
            this.picFacebook = new GUI.Controls.CustomePicture();
            this.btnMessenger = new GUI.Components.CustomButton();
            this.btnAnouncement = new GUI.Components.CustomButton();
            this.picAvatarBar = new GUI.Controls.CustomePicture();
            this.btnHome = new System.Windows.Forms.Button();
            this.picGoBack = new System.Windows.Forms.PictureBox();
            this.picAvatar = new GUI.Controls.CustomePicture();
            this.btnLogout = new GUI.Components.CustomButton();
            this.btnChangeLan = new GUI.Components.CustomButton();
            this.btnDarkMode = new GUI.Components.CustomButton();
            this.btnOptional = new GUI.Components.CustomButton();
            this.btnNewChatMini = new GUI.Components.CustomButton();
            this.btnExpandScreen = new GUI.Components.CustomButton();
            this.pnlMessengerMini.SuspendLayout();
            this.pnlGoToMess.SuspendLayout();
            this.flpListFriends.SuspendLayout();
            this.pnlGoBack.SuspendLayout();
            this.pnlControlTab.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // windowControls
            // 
            this.windowControls.Size = new System.Drawing.Size(1280, 40);
            // 
            // lblFacebook
            // 
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblFacebook.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblFacebook.ForeColor = System.Drawing.Color.White;
            this.lblFacebook.Location = new System.Drawing.Point(68, 11);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(74, 19);
            this.lblFacebook.TabIndex = 10;
            this.lblFacebook.Text = "Facebook";
            // 
            // pnlMessengerMini
            // 
            this.pnlMessengerMini.AutoScroll = true;
            this.pnlMessengerMini.BackColor = System.Drawing.Color.White;
            this.pnlMessengerMini.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlMessengerMini.Controls.Add(this.lblTextChat);
            this.pnlMessengerMini.Controls.Add(this.txtSearchInMess);
            this.pnlMessengerMini.Controls.Add(this.pnlGoToMess);
            this.pnlMessengerMini.Controls.Add(this.btnComunication);
            this.pnlMessengerMini.Controls.Add(this.btnMessageBox);
            this.pnlMessengerMini.Controls.Add(this.btnOptional);
            this.pnlMessengerMini.Controls.Add(this.btnNewChatMini);
            this.pnlMessengerMini.Controls.Add(this.btnExpandScreen);
            this.pnlMessengerMini.Controls.Add(this.flpListFriends);
            this.pnlMessengerMini.Location = new System.Drawing.Point(950, 90);
            this.pnlMessengerMini.Name = "pnlMessengerMini";
            this.pnlMessengerMini.Size = new System.Drawing.Size(310, 622);
            this.pnlMessengerMini.TabIndex = 1;
            this.pnlMessengerMini.Visible = false;
            // 
            // lblTextChat
            // 
            this.lblTextChat.AllowDrop = true;
            this.lblTextChat.AutoEllipsis = true;
            this.lblTextChat.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTextChat.Location = new System.Drawing.Point(10, 3);
            this.lblTextChat.Name = "lblTextChat";
            this.lblTextChat.Size = new System.Drawing.Size(164, 35);
            this.lblTextChat.TabIndex = 3;
            this.lblTextChat.Text = "Đoạn chat";
            // 
            // txtSearchInMess
            // 
            this.txtSearchInMess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.txtSearchInMess.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.txtSearchInMess.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.txtSearchInMess.BorderRadius = 16;
            this.txtSearchInMess.BorderSize = 2;
            this.txtSearchInMess.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchInMess.Location = new System.Drawing.Point(10, 55);
            this.txtSearchInMess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtSearchInMess.Multiline = false;
            this.txtSearchInMess.Name = "txtSearchInMess";
            this.txtSearchInMess.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.txtSearchInMess.PasswordChar = false;
            this.txtSearchInMess.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSearchInMess.PlaceholderText = "Tìm kiếm trên Messenger";
            this.txtSearchInMess.Size = new System.Drawing.Size(274, 32);
            this.txtSearchInMess.TabIndex = 27;
            this.txtSearchInMess.Texts = "";
            this.txtSearchInMess.UnderlinedStyle = false;
            // 
            // pnlGoToMess
            // 
            this.pnlGoToMess.BackColor = System.Drawing.Color.Transparent;
            this.pnlGoToMess.Controls.Add(this.lblGoToMessenger);
            this.pnlGoToMess.Location = new System.Drawing.Point(0, 580);
            this.pnlGoToMess.Name = "pnlGoToMess";
            this.pnlGoToMess.Size = new System.Drawing.Size(305, 40);
            this.pnlGoToMess.TabIndex = 17;
            this.pnlGoToMess.Visible = false;
            this.pnlGoToMess.Click += new System.EventHandler(this.pnlGoToMess_Click);
            // 
            // lblGoToMessenger
            // 
            this.lblGoToMessenger.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblGoToMessenger.AutoSize = true;
            this.lblGoToMessenger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblGoToMessenger.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lblGoToMessenger.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.lblGoToMessenger.Location = new System.Drawing.Point(70, 12);
            this.lblGoToMessenger.Name = "lblGoToMessenger";
            this.lblGoToMessenger.Size = new System.Drawing.Size(171, 19);
            this.lblGoToMessenger.TabIndex = 6;
            this.lblGoToMessenger.TabStop = true;
            this.lblGoToMessenger.Text = "Xem tất cả trong mesenger";
            this.lblGoToMessenger.Click += new System.EventHandler(this.lblGoToMessenger_Click);
            // 
            // btnComunication
            // 
            this.btnComunication.BackColor = System.Drawing.Color.AliceBlue;
            this.btnComunication.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.btnComunication.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComunication.BorderRadius = 15;
            this.btnComunication.BorderSize = 0;
            this.btnComunication.FlatAppearance.BorderSize = 0;
            this.btnComunication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComunication.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnComunication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComunication.Location = new System.Drawing.Point(105, 102);
            this.btnComunication.Name = "btnComunication";
            this.btnComunication.Size = new System.Drawing.Size(105, 30);
            this.btnComunication.TabIndex = 23;
            this.btnComunication.Text = "Cộng đồng";
            this.btnComunication.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnComunication.UseVisualStyleBackColor = false;
            // 
            // btnMessageBox
            // 
            this.btnMessageBox.BackColor = System.Drawing.Color.AliceBlue;
            this.btnMessageBox.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.btnMessageBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnMessageBox.BorderRadius = 15;
            this.btnMessageBox.BorderSize = 0;
            this.btnMessageBox.FlatAppearance.BorderSize = 0;
            this.btnMessageBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessageBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMessageBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnMessageBox.Location = new System.Drawing.Point(12, 102);
            this.btnMessageBox.Name = "btnMessageBox";
            this.btnMessageBox.Size = new System.Drawing.Size(80, 30);
            this.btnMessageBox.TabIndex = 12;
            this.btnMessageBox.Text = "Hộp thư";
            this.btnMessageBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnMessageBox.UseVisualStyleBackColor = false;
            // 
            // flpListFriends
            // 
            this.flpListFriends.AutoSize = true;
            this.flpListFriends.BackColor = System.Drawing.Color.Transparent;
            this.flpListFriends.Controls.Add(this.users6);
            this.flpListFriends.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpListFriends.Location = new System.Drawing.Point(7, 140);
            this.flpListFriends.Name = "flpListFriends";
            this.flpListFriends.Size = new System.Drawing.Size(295, 480);
            this.flpListFriends.TabIndex = 25;
            // 
            // users6
            // 
            this.users6.Location = new System.Drawing.Point(3, 3);
            this.users6.Name = "users6";
            this.users6.Size = new System.Drawing.Size(280, 56);
            this.users6.TabIndex = 25;
            // 
            // pnlGoBack
            // 
            this.pnlGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.pnlGoBack.Controls.Add(this.picGoBack);
            this.pnlGoBack.Location = new System.Drawing.Point(0, 0);
            this.pnlGoBack.Name = "pnlGoBack";
            this.pnlGoBack.Size = new System.Drawing.Size(50, 40);
            this.pnlGoBack.TabIndex = 15;
            // 
            // pnlControlTab
            // 
            this.pnlControlTab.BackColor = System.Drawing.Color.White;
            this.pnlControlTab.Controls.Add(this.picSearch);
            this.pnlControlTab.Controls.Add(this.btnGroup);
            this.pnlControlTab.Controls.Add(this.btnVideo);
            this.pnlControlTab.Controls.Add(this.picFacebook);
            this.pnlControlTab.Controls.Add(this.btnMessenger);
            this.pnlControlTab.Controls.Add(this.btnAnouncement);
            this.pnlControlTab.Controls.Add(this.picAvatarBar);
            this.pnlControlTab.Controls.Add(this.btnHome);
            this.pnlControlTab.Controls.Add(this.txtSearchOnFace);
            this.pnlControlTab.Controls.Add(this.customeInpputTextBox1);
            this.pnlControlTab.Controls.Add(this.lblSearch);
            this.pnlControlTab.Location = new System.Drawing.Point(0, 40);
            this.pnlControlTab.Name = "pnlControlTab";
            this.pnlControlTab.Size = new System.Drawing.Size(1280, 50);
            this.pnlControlTab.TabIndex = 16;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblSearch.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearch.Location = new System.Drawing.Point(105, 20);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(178, 20);
            this.lblSearch.TabIndex = 34;
            this.lblSearch.Text = "Tìm kiếm trên Facebook";
            this.lblSearch.Click += new System.EventHandler(this.lblSearch_Click);
            // 
            // txtSearchOnFace
            // 
            this.txtSearchOnFace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.txtSearchOnFace.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchOnFace.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtSearchOnFace.Location = new System.Drawing.Point(100, 20);
            this.txtSearchOnFace.Name = "txtSearchOnFace";
            this.txtSearchOnFace.Size = new System.Drawing.Size(198, 19);
            this.txtSearchOnFace.TabIndex = 1;
            this.txtSearchOnFace.Visible = false;
            this.txtSearchOnFace.TextChanged += new System.EventHandler(this.txtSearchOnFace_TextChanged);
            this.txtSearchOnFace.Enter += new System.EventHandler(this.txtSearchOnFace_Enter);
            this.txtSearchOnFace.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchOnFace_KeyDown);
            this.txtSearchOnFace.Leave += new System.EventHandler(this.txtSearchOnFace_Leave);
            // 
            // customeInpputTextBox1
            // 
            this.customeInpputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderRadius = 17;
            this.customeInpputTextBox1.BorderSize = 2;
            this.customeInpputTextBox1.Enabled = false;
            this.customeInpputTextBox1.ForeColor = System.Drawing.Color.Black;
            this.customeInpputTextBox1.Location = new System.Drawing.Point(61, 10);
            this.customeInpputTextBox1.Multiline = true;
            this.customeInpputTextBox1.Name = "customeInpputTextBox1";
            this.customeInpputTextBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customeInpputTextBox1.PasswordChar = false;
            this.customeInpputTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customeInpputTextBox1.PlaceholderText = "";
            this.customeInpputTextBox1.Size = new System.Drawing.Size(250, 34);
            this.customeInpputTextBox1.TabIndex = 1;
            this.customeInpputTextBox1.Texts = "";
            this.customeInpputTextBox1.UnderlinedStyle = false;
            this.customeInpputTextBox1.Click += new System.EventHandler(this.customeInpputTextBox1_Click);
            this.customeInpputTextBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customeInpputTextBox1_MouseClick);
            // 
            // pnlUser
            // 
            this.pnlUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlUser.AutoScroll = true;
            this.pnlUser.BackColor = System.Drawing.Color.White;
            this.pnlUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlUser.Controls.Add(this.picAvatar);
            this.pnlUser.Controls.Add(this.customButton5);
            this.pnlUser.Controls.Add(this.btnLogout);
            this.pnlUser.Controls.Add(this.btnMyUser);
            this.pnlUser.Controls.Add(this.btnGotoMyUser);
            this.pnlUser.Controls.Add(this.btnChangeLan);
            this.pnlUser.Controls.Add(this.btnDarkMode);
            this.pnlUser.Controls.Add(this.pnlProfile);
            this.pnlUser.Location = new System.Drawing.Point(970, 91);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(310, 300);
            this.pnlUser.TabIndex = 30;
            this.pnlUser.Visible = false;
            // 
            // customButton5
            // 
            this.customButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.customButton5.BackColor = System.Drawing.Color.White;
            this.customButton5.BackgroundColor = System.Drawing.Color.White;
            this.customButton5.BorderColor = System.Drawing.Color.Gainsboro;
            this.customButton5.BorderRadius = 0;
            this.customButton5.BorderSize = 1;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.customButton5.Location = new System.Drawing.Point(15, 71);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(270, 2);
            this.customButton5.TabIndex = 30;
            this.customButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // btnMyUser
            // 
            this.btnMyUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMyUser.BackColor = System.Drawing.Color.Transparent;
            this.btnMyUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMyUser.BorderColor = System.Drawing.Color.White;
            this.btnMyUser.BorderRadius = 15;
            this.btnMyUser.BorderSize = 0;
            this.btnMyUser.FlatAppearance.BorderSize = 0;
            this.btnMyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnMyUser.ForeColor = System.Drawing.Color.Black;
            this.btnMyUser.Location = new System.Drawing.Point(71, 15);
            this.btnMyUser.Name = "btnMyUser";
            this.btnMyUser.Size = new System.Drawing.Size(214, 51);
            this.btnMyUser.TabIndex = 28;
            this.btnMyUser.Text = "Nguyễn Đắc Cường";
            this.btnMyUser.TextColor = System.Drawing.Color.Black;
            this.btnMyUser.UseVisualStyleBackColor = false;
            // 
            // btnGotoMyUser
            // 
            this.btnGotoMyUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGotoMyUser.BackColor = System.Drawing.Color.Transparent;
            this.btnGotoMyUser.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGotoMyUser.BorderColor = System.Drawing.Color.White;
            this.btnGotoMyUser.BorderRadius = 15;
            this.btnGotoMyUser.BorderSize = 0;
            this.btnGotoMyUser.FlatAppearance.BorderSize = 0;
            this.btnGotoMyUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGotoMyUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGotoMyUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnGotoMyUser.Location = new System.Drawing.Point(15, 77);
            this.btnGotoMyUser.Name = "btnGotoMyUser";
            this.btnGotoMyUser.Size = new System.Drawing.Size(270, 27);
            this.btnGotoMyUser.TabIndex = 28;
            this.btnGotoMyUser.Text = "Xem trang cá nhân";
            this.btnGotoMyUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGotoMyUser.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnGotoMyUser.UseVisualStyleBackColor = false;
            // 
            // pnlProfile
            // 
            this.pnlProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlProfile.BackColor = System.Drawing.Color.Transparent;
            this.pnlProfile.BorderColor = System.Drawing.Color.Gainsboro;
            this.pnlProfile.BorderRadius = 12;
            this.pnlProfile.Location = new System.Drawing.Point(8, 10);
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(290, 100);
            this.pnlProfile.TabIndex = 34;
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.Transparent;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContent.Location = new System.Drawing.Point(0, 90);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(1280, 630);
            this.pnlContent.TabIndex = 31;
            // 
            // picSearch
            // 
            this.picSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.picSearch.Image = global::GUI.Properties.Resources._32_dimgray_search;
            this.picSearch.Location = new System.Drawing.Point(75, 17);
            this.picSearch.Name = "picSearch";
            this.picSearch.Size = new System.Drawing.Size(24, 24);
            this.picSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSearch.TabIndex = 35;
            this.picSearch.TabStop = false;
            this.picSearch.Click += new System.EventHandler(this.picSearch_Click);
            this.picSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSearch_MouseClick);
            // 
            // btnGroup
            // 
            this.btnGroup.BackColor = System.Drawing.Color.Transparent;
            this.btnGroup.FlatAppearance.BorderSize = 0;
            this.btnGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroup.ForeColor = System.Drawing.Color.Black;
            this.btnGroup.Image = global::GUI.Properties.Resources._32_blue_friends;
            this.btnGroup.Location = new System.Drawing.Point(735, 0);
            this.btnGroup.Name = "btnGroup";
            this.btnGroup.Size = new System.Drawing.Size(210, 50);
            this.btnGroup.TabIndex = 26;
            this.btnGroup.UseVisualStyleBackColor = false;
            this.btnGroup.Click += new System.EventHandler(this.btnGroup_Click);
            // 
            // btnVideo
            // 
            this.btnVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnVideo.FlatAppearance.BorderSize = 0;
            this.btnVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideo.ForeColor = System.Drawing.Color.Black;
            this.btnVideo.Image = global::GUI.Properties.Resources._32_blue_film;
            this.btnVideo.Location = new System.Drawing.Point(525, 0);
            this.btnVideo.Name = "btnVideo";
            this.btnVideo.Size = new System.Drawing.Size(210, 50);
            this.btnVideo.TabIndex = 25;
            this.btnVideo.UseVisualStyleBackColor = false;
            this.btnVideo.Click += new System.EventHandler(this.btnVideo_Click);
            // 
            // picFacebook
            // 
            this.picFacebook.BackColor = System.Drawing.Color.Transparent;
            this.picFacebook.Image = global::GUI.Properties.Resources.ic_Facebook;
            this.picFacebook.Location = new System.Drawing.Point(15, 5);
            this.picFacebook.Name = "picFacebook";
            this.picFacebook.Size = new System.Drawing.Size(40, 40);
            this.picFacebook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFacebook.TabIndex = 19;
            this.picFacebook.TabStop = false;
            // 
            // btnMessenger
            // 
            this.btnMessenger.BackColor = System.Drawing.Color.Gainsboro;
            this.btnMessenger.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnMessenger.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnMessenger.BorderRadius = 40;
            this.btnMessenger.BorderSize = 0;
            this.btnMessenger.FlatAppearance.BorderSize = 0;
            this.btnMessenger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMessenger.ForeColor = System.Drawing.Color.White;
            this.btnMessenger.Image = global::GUI.Properties.Resources._20_black_messenger;
            this.btnMessenger.Location = new System.Drawing.Point(1120, 5);
            this.btnMessenger.Name = "btnMessenger";
            this.btnMessenger.Size = new System.Drawing.Size(40, 40);
            this.btnMessenger.TabIndex = 18;
            this.btnMessenger.TextColor = System.Drawing.Color.White;
            this.btnMessenger.UseVisualStyleBackColor = false;
            this.btnMessenger.Click += new System.EventHandler(this.customButton2_Click);
            // 
            // btnAnouncement
            // 
            this.btnAnouncement.BackColor = System.Drawing.Color.Gainsboro;
            this.btnAnouncement.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnAnouncement.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnAnouncement.BorderRadius = 40;
            this.btnAnouncement.BorderSize = 0;
            this.btnAnouncement.FlatAppearance.BorderSize = 0;
            this.btnAnouncement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnouncement.ForeColor = System.Drawing.Color.White;
            this.btnAnouncement.Image = global::GUI.Properties.Resources._20_black_ring;
            this.btnAnouncement.Location = new System.Drawing.Point(1170, 5);
            this.btnAnouncement.Name = "btnAnouncement";
            this.btnAnouncement.Size = new System.Drawing.Size(40, 40);
            this.btnAnouncement.TabIndex = 17;
            this.btnAnouncement.TextColor = System.Drawing.Color.White;
            this.btnAnouncement.UseVisualStyleBackColor = false;
            // 
            // picAvatarBar
            // 
            this.picAvatarBar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatarBar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatarBar.Location = new System.Drawing.Point(1220, 5);
            this.picAvatarBar.Name = "picAvatarBar";
            this.picAvatarBar.Size = new System.Drawing.Size(40, 40);
            this.picAvatarBar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatarBar.TabIndex = 0;
            this.picAvatarBar.TabStop = false;
            this.picAvatarBar.Click += new System.EventHandler(this.customePicture1_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::GUI.Properties.Resources._32_blue_home;
            this.btnHome.Location = new System.Drawing.Point(315, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(210, 50);
            this.btnHome.TabIndex = 24;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picGoBack
            // 
            this.picGoBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.picGoBack.Image = global::GUI.Properties.Resources._128_White_Back;
            this.picGoBack.Location = new System.Drawing.Point(15, 10);
            this.picGoBack.Name = "picGoBack";
            this.picGoBack.Size = new System.Drawing.Size(20, 20);
            this.picGoBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGoBack.TabIndex = 6;
            this.picGoBack.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(15, 15);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 29;
            this.picAvatar.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLogout.BackColor = System.Drawing.Color.White;
            this.btnLogout.BackgroundColor = System.Drawing.Color.White;
            this.btnLogout.BorderColor = System.Drawing.Color.Red;
            this.btnLogout.BorderRadius = 15;
            this.btnLogout.BorderSize = 0;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Image = global::GUI.Properties.Resources._32_black_logout;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(9, 240);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(289, 50);
            this.btnLogout.TabIndex = 33;
            this.btnLogout.Text = "          Đăng xuất";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.TextColor = System.Drawing.Color.Black;
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnChangeLan
            // 
            this.btnChangeLan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeLan.BackColor = System.Drawing.Color.White;
            this.btnChangeLan.BackgroundColor = System.Drawing.Color.White;
            this.btnChangeLan.BorderColor = System.Drawing.Color.White;
            this.btnChangeLan.BorderRadius = 15;
            this.btnChangeLan.BorderSize = 0;
            this.btnChangeLan.FlatAppearance.BorderSize = 0;
            this.btnChangeLan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangeLan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChangeLan.ForeColor = System.Drawing.Color.Black;
            this.btnChangeLan.Image = global::GUI.Properties.Resources._32_black_vietnam;
            this.btnChangeLan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeLan.Location = new System.Drawing.Point(8, 190);
            this.btnChangeLan.Name = "btnChangeLan";
            this.btnChangeLan.Size = new System.Drawing.Size(289, 50);
            this.btnChangeLan.TabIndex = 32;
            this.btnChangeLan.Text = "          Chuyển ngôn ngữ Anh/Việt";
            this.btnChangeLan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChangeLan.TextColor = System.Drawing.Color.Black;
            this.btnChangeLan.UseVisualStyleBackColor = false;
            this.btnChangeLan.Click += new System.EventHandler(this.btnChangeLan_Click);
            // 
            // btnDarkMode
            // 
            this.btnDarkMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDarkMode.BackColor = System.Drawing.Color.White;
            this.btnDarkMode.BackgroundColor = System.Drawing.Color.White;
            this.btnDarkMode.BorderColor = System.Drawing.Color.White;
            this.btnDarkMode.BorderRadius = 15;
            this.btnDarkMode.BorderSize = 0;
            this.btnDarkMode.FlatAppearance.BorderSize = 0;
            this.btnDarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarkMode.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDarkMode.ForeColor = System.Drawing.Color.Black;
            this.btnDarkMode.Image = global::GUI.Properties.Resources._32_black_empty_moon;
            this.btnDarkMode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.Location = new System.Drawing.Point(8, 140);
            this.btnDarkMode.Name = "btnDarkMode";
            this.btnDarkMode.Size = new System.Drawing.Size(289, 50);
            this.btnDarkMode.TabIndex = 28;
            this.btnDarkMode.Text = "          Bật chế độ ban đêm";
            this.btnDarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDarkMode.TextColor = System.Drawing.Color.Black;
            this.btnDarkMode.UseVisualStyleBackColor = false;
            // 
            // btnOptional
            // 
            this.btnOptional.BackColor = System.Drawing.Color.White;
            this.btnOptional.BackgroundColor = System.Drawing.Color.White;
            this.btnOptional.BorderColor = System.Drawing.Color.LightGray;
            this.btnOptional.BorderRadius = 24;
            this.btnOptional.BorderSize = 0;
            this.btnOptional.FlatAppearance.BorderSize = 0;
            this.btnOptional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptional.ForeColor = System.Drawing.Color.White;
            this.btnOptional.Image = global::GUI.Properties.Resources._16_black_option;
            this.btnOptional.Location = new System.Drawing.Point(200, 6);
            this.btnOptional.Name = "btnOptional";
            this.btnOptional.Size = new System.Drawing.Size(24, 24);
            this.btnOptional.TabIndex = 22;
            this.btnOptional.TextColor = System.Drawing.Color.White;
            this.btnOptional.UseVisualStyleBackColor = false;
            // 
            // btnNewChatMini
            // 
            this.btnNewChatMini.BackColor = System.Drawing.Color.White;
            this.btnNewChatMini.BackgroundColor = System.Drawing.Color.White;
            this.btnNewChatMini.BorderColor = System.Drawing.Color.LightGray;
            this.btnNewChatMini.BorderRadius = 24;
            this.btnNewChatMini.BorderSize = 0;
            this.btnNewChatMini.FlatAppearance.BorderSize = 0;
            this.btnNewChatMini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewChatMini.ForeColor = System.Drawing.Color.White;
            this.btnNewChatMini.Image = global::GUI.Properties.Resources._16_black_write;
            this.btnNewChatMini.Location = new System.Drawing.Point(230, 6);
            this.btnNewChatMini.Name = "btnNewChatMini";
            this.btnNewChatMini.Size = new System.Drawing.Size(24, 24);
            this.btnNewChatMini.TabIndex = 21;
            this.btnNewChatMini.TextColor = System.Drawing.Color.White;
            this.btnNewChatMini.UseVisualStyleBackColor = false;
            // 
            // btnExpandScreen
            // 
            this.btnExpandScreen.BackColor = System.Drawing.Color.White;
            this.btnExpandScreen.BackgroundColor = System.Drawing.Color.White;
            this.btnExpandScreen.BorderColor = System.Drawing.Color.LightGray;
            this.btnExpandScreen.BorderRadius = 24;
            this.btnExpandScreen.BorderSize = 0;
            this.btnExpandScreen.FlatAppearance.BorderSize = 0;
            this.btnExpandScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpandScreen.ForeColor = System.Drawing.Color.White;
            this.btnExpandScreen.Image = global::GUI.Properties.Resources._16_black_Maximize_AnotherStyle;
            this.btnExpandScreen.Location = new System.Drawing.Point(260, 6);
            this.btnExpandScreen.Name = "btnExpandScreen";
            this.btnExpandScreen.Size = new System.Drawing.Size(24, 24);
            this.btnExpandScreen.TabIndex = 20;
            this.btnExpandScreen.TextColor = System.Drawing.Color.White;
            this.btnExpandScreen.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.pnlControlTab);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.pnlGoBack);
            this.Controls.Add(this.pnlUser);
            this.Controls.Add(this.pnlMessengerMini);
            this.Controls.Add(this.pnlContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Controls.SetChildIndex(this.pnlContent, 0);
            this.Controls.SetChildIndex(this.pnlMessengerMini, 0);
            this.Controls.SetChildIndex(this.pnlUser, 0);
            this.Controls.SetChildIndex(this.pnlGoBack, 0);
            this.Controls.SetChildIndex(this.lblFacebook, 0);
            this.Controls.SetChildIndex(this.pnlControlTab, 0);
            this.Controls.SetChildIndex(this.windowControls, 0);
            this.pnlMessengerMini.ResumeLayout(false);
            this.pnlMessengerMini.PerformLayout();
            this.pnlGoToMess.ResumeLayout(false);
            this.pnlGoToMess.PerformLayout();
            this.flpListFriends.ResumeLayout(false);
            this.pnlGoBack.ResumeLayout(false);
            this.pnlControlTab.ResumeLayout(false);
            this.pnlControlTab.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFacebook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatarBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGoBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.Panel pnlGoBack;
        private System.Windows.Forms.PictureBox picGoBack;
        private System.Windows.Forms.Panel pnlControlTab;
        private Controls.CustomePicture picAvatarBar;
        private Components.CustomButton btnAnouncement;
        private Components.CustomButton btnMessenger;
        private Controls.CustomePicture picFacebook;
        private System.Windows.Forms.Panel pnlMessengerMini;
        private System.Windows.Forms.Label lblTextChat;
        private Components.CustomButton btnExpandScreen;
        private Components.CustomButton btnNewChatMini;
        private Components.CustomButton btnOptional;
        private Components.CustomButton btnMessageBox;
        private Components.CustomButton btnComunication;
        private System.Windows.Forms.FlowLayoutPanel flpListFriends;
        private System.Windows.Forms.Panel pnlGoToMess;
        private System.Windows.Forms.LinkLabel lblGoToMessenger;
        private Components.CustomeInpputTextBox txtSearchInMess;
        private Controls.ChatControls.MyUserControl users6;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnGroup;
        private System.Windows.Forms.Button btnVideo;
        private System.Windows.Forms.Panel pnlUser;
        private Controls.CustomePicture picAvatar;
        private Components.CustomButton customButton5;
        private Components.CustomButton btnLogout;
        private Components.CustomButton btnMyUser;
        private Components.CustomButton btnGotoMyUser;
        private Components.CustomButton btnChangeLan;
        private Components.CustomButton btnDarkMode;
        private Controls.Custome.CustomePanel pnlProfile;
        private System.Windows.Forms.Panel pnlContent;
        private UserControls.UCHome ucHome1;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.PictureBox picSearch;
        private System.Windows.Forms.TextBox txtSearchOnFace;
        private Components.CustomeInpputTextBox customeInpputTextBox1;
    }
}