namespace GUI.NewsFeed.Forms
{
    partial class PostingFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PostingFrom));
            this.lblIntro = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlMedia = new System.Windows.Forms.Panel();
            this.btnAddImageFromFile = new GUI.Components.CustomButton();
            this.btnTakeAPhoto = new GUI.Components.CustomButton();
            this.flpImagePosting = new System.Windows.Forms.FlowLayoutPanel();
            this.border = new GUI.Components.CustomeInpputTextBox();
            this.pnlStatitude = new System.Windows.Forms.Panel();
            this.flpStatitude = new System.Windows.Forms.FlowLayoutPanel();
            this.customButton1 = new GUI.Components.CustomButton();
            this.customButton2 = new GUI.Components.CustomButton();
            this.customButton3 = new GUI.Components.CustomButton();
            this.customButton4 = new GUI.Components.CustomButton();
            this.customButton5 = new GUI.Components.CustomButton();
            this.customButton6 = new GUI.Components.CustomButton();
            this.customButton7 = new GUI.Components.CustomButton();
            this.customButton8 = new GUI.Components.CustomButton();
            this.customButton9 = new GUI.Components.CustomButton();
            this.customButton10 = new GUI.Components.CustomButton();
            this.customeInpputTextBox1 = new GUI.Components.CustomeInpputTextBox();
            this.pnlAddPostActivity = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.picMedia = new System.Windows.Forms.PictureBox();
            this.picStatitude = new System.Windows.Forms.PictureBox();
            this.btnPost = new GUI.Components.CustomButton();
            this.flpOption = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.line1 = new GUI.Components.CustomeInpputTextBox();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.pnlSelectForm = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAccept = new GUI.Components.CustomButton();
            this.btnDecline = new GUI.Components.CustomButton();
            this.flpFriendsSelect = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOption = new GUI.Components.CustomButton();
            this.picAvatar = new GUI.Controls.CustomePicture();
            this.flpContent.SuspendLayout();
            this.pnlMedia.SuspendLayout();
            this.pnlStatitude.SuspendLayout();
            this.flpStatitude.SuspendLayout();
            this.pnlAddPostActivity.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatitude)).BeginInit();
            this.flpOption.SuspendLayout();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.pnlSelectForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(208, 20);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(134, 25);
            this.lblIntro.TabIndex = 41;
            this.lblIntro.Text = "Tạo bài viết";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(63, 83);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 56;
            this.lblName.Text = "Nguyễn Đắc Cường";
            // 
            // txtCaption
            // 
            this.txtCaption.BackColor = System.Drawing.Color.White;
            this.txtCaption.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtCaption.Location = new System.Drawing.Point(3, 3);
            this.txtCaption.Multiline = true;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(520, 56);
            this.txtCaption.TabIndex = 58;
            // 
            // flpContent
            // 
            this.flpContent.AutoSize = true;
            this.flpContent.BackColor = System.Drawing.Color.Transparent;
            this.flpContent.Controls.Add(this.txtCaption);
            this.flpContent.Controls.Add(this.pnlMedia);
            this.flpContent.Controls.Add(this.pnlStatitude);
            this.flpContent.Controls.Add(this.pnlAddPostActivity);
            this.flpContent.Controls.Add(this.btnPost);
            this.flpContent.Location = new System.Drawing.Point(12, 130);
            this.flpContent.MaximumSize = new System.Drawing.Size(526, 0);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(526, 752);
            this.flpContent.TabIndex = 59;
            // 
            // pnlMedia
            // 
            this.pnlMedia.BackColor = System.Drawing.Color.Transparent;
            this.pnlMedia.Controls.Add(this.btnAddImageFromFile);
            this.pnlMedia.Controls.Add(this.btnTakeAPhoto);
            this.pnlMedia.Controls.Add(this.flpImagePosting);
            this.pnlMedia.Controls.Add(this.border);
            this.pnlMedia.Location = new System.Drawing.Point(3, 65);
            this.pnlMedia.Name = "pnlMedia";
            this.pnlMedia.Size = new System.Drawing.Size(520, 280);
            this.pnlMedia.TabIndex = 60;
            // 
            // btnAddImageFromFile
            // 
            this.btnAddImageFromFile.AutoSize = true;
            this.btnAddImageFromFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddImageFromFile.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddImageFromFile.BorderColor = System.Drawing.Color.Transparent;
            this.btnAddImageFromFile.BorderRadius = 10;
            this.btnAddImageFromFile.BorderSize = 0;
            this.btnAddImageFromFile.FlatAppearance.BorderSize = 0;
            this.btnAddImageFromFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddImageFromFile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAddImageFromFile.ForeColor = System.Drawing.Color.Black;
            this.btnAddImageFromFile.Location = new System.Drawing.Point(0, 0);
            this.btnAddImageFromFile.Name = "btnAddImageFromFile";
            this.btnAddImageFromFile.Size = new System.Drawing.Size(500, 200);
            this.btnAddImageFromFile.TabIndex = 61;
            this.btnAddImageFromFile.Text = "Thêm ảnh hoặc video";
            this.btnAddImageFromFile.TextColor = System.Drawing.Color.Black;
            this.btnAddImageFromFile.UseVisualStyleBackColor = false;
            this.btnAddImageFromFile.Click += new System.EventHandler(this.btnAddImageFromFile_Click);
            // 
            // btnTakeAPhoto
            // 
            this.btnTakeAPhoto.AutoSize = true;
            this.btnTakeAPhoto.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnTakeAPhoto.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnTakeAPhoto.BorderColor = System.Drawing.Color.Transparent;
            this.btnTakeAPhoto.BorderRadius = 10;
            this.btnTakeAPhoto.BorderSize = 0;
            this.btnTakeAPhoto.FlatAppearance.BorderSize = 0;
            this.btnTakeAPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAPhoto.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTakeAPhoto.ForeColor = System.Drawing.Color.Black;
            this.btnTakeAPhoto.Location = new System.Drawing.Point(10, 220);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(500, 50);
            this.btnTakeAPhoto.TabIndex = 62;
            this.btnTakeAPhoto.Text = "Chụp ảnh mới";
            this.btnTakeAPhoto.TextColor = System.Drawing.Color.Black;
            this.btnTakeAPhoto.UseVisualStyleBackColor = false;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
            // 
            // flpImagePosting
            // 
            this.flpImagePosting.Location = new System.Drawing.Point(0, 0);
            this.flpImagePosting.Name = "flpImagePosting";
            this.flpImagePosting.Size = new System.Drawing.Size(500, 200);
            this.flpImagePosting.TabIndex = 63;
            this.flpImagePosting.Visible = false;
            // 
            // border
            // 
            this.border.BackColor = System.Drawing.Color.White;
            this.border.BorderColor = System.Drawing.Color.Silver;
            this.border.BorderFocusColor = System.Drawing.Color.Transparent;
            this.border.BorderRadius = 0;
            this.border.BorderSize = 1;
            this.border.Dock = System.Windows.Forms.DockStyle.Fill;
            this.border.Location = new System.Drawing.Point(0, 0);
            this.border.Multiline = true;
            this.border.Name = "border";
            this.border.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.border.PasswordChar = false;
            this.border.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.border.PlaceholderText = "";
            this.border.Size = new System.Drawing.Size(520, 280);
            this.border.TabIndex = 0;
            this.border.Texts = "";
            this.border.UnderlinedStyle = false;
            // 
            // pnlStatitude
            // 
            this.pnlStatitude.BackColor = System.Drawing.Color.Transparent;
            this.pnlStatitude.Controls.Add(this.flpStatitude);
            this.pnlStatitude.Controls.Add(this.customeInpputTextBox1);
            this.pnlStatitude.Location = new System.Drawing.Point(3, 351);
            this.pnlStatitude.Name = "pnlStatitude";
            this.pnlStatitude.Size = new System.Drawing.Size(520, 280);
            this.pnlStatitude.TabIndex = 64;
            this.pnlStatitude.Visible = false;
            // 
            // flpStatitude
            // 
            this.flpStatitude.AutoScroll = true;
            this.flpStatitude.Controls.Add(this.customButton1);
            this.flpStatitude.Controls.Add(this.customButton2);
            this.flpStatitude.Controls.Add(this.customButton3);
            this.flpStatitude.Controls.Add(this.customButton4);
            this.flpStatitude.Controls.Add(this.customButton5);
            this.flpStatitude.Controls.Add(this.customButton6);
            this.flpStatitude.Controls.Add(this.customButton7);
            this.flpStatitude.Controls.Add(this.customButton8);
            this.flpStatitude.Controls.Add(this.customButton9);
            this.flpStatitude.Controls.Add(this.customButton10);
            this.flpStatitude.Location = new System.Drawing.Point(10, 14);
            this.flpStatitude.Name = "flpStatitude";
            this.flpStatitude.Size = new System.Drawing.Size(500, 249);
            this.flpStatitude.TabIndex = 63;
            // 
            // customButton1
            // 
            this.customButton1.AutoSize = true;
            this.customButton1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton1.BorderColor = System.Drawing.Color.Transparent;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Image = global::GUI.Properties.Resources.emo01;
            this.customButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.Location = new System.Drawing.Point(3, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(234, 50);
            this.customButton1.TabIndex = 64;
            this.customButton1.Text = "          Hạnh phúc";
            this.customButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            // 
            // customButton2
            // 
            this.customButton2.AutoSize = true;
            this.customButton2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton2.BorderColor = System.Drawing.Color.Transparent;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton2.ForeColor = System.Drawing.Color.Black;
            this.customButton2.Image = global::GUI.Properties.Resources.emo03;
            this.customButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.Location = new System.Drawing.Point(243, 3);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(234, 50);
            this.customButton2.TabIndex = 64;
            this.customButton2.Text = "          Được yêu";
            this.customButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            // 
            // customButton3
            // 
            this.customButton3.AutoSize = true;
            this.customButton3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton3.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton3.BorderColor = System.Drawing.Color.Transparent;
            this.customButton3.BorderRadius = 10;
            this.customButton3.BorderSize = 0;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton3.ForeColor = System.Drawing.Color.Black;
            this.customButton3.Image = global::GUI.Properties.Resources.emo05;
            this.customButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.Location = new System.Drawing.Point(3, 59);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(234, 50);
            this.customButton3.TabIndex = 64;
            this.customButton3.Text = "          Tức giận";
            this.customButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            // 
            // customButton4
            // 
            this.customButton4.AutoSize = true;
            this.customButton4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton4.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton4.BorderColor = System.Drawing.Color.Transparent;
            this.customButton4.BorderRadius = 10;
            this.customButton4.BorderSize = 0;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton4.ForeColor = System.Drawing.Color.Black;
            this.customButton4.Image = global::GUI.Properties.Resources.emo07;
            this.customButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.Location = new System.Drawing.Point(243, 59);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(234, 50);
            this.customButton4.TabIndex = 64;
            this.customButton4.Text = "          Buồn ngủ";
            this.customButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = false;
            // 
            // customButton5
            // 
            this.customButton5.AutoSize = true;
            this.customButton5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton5.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton5.BorderColor = System.Drawing.Color.Transparent;
            this.customButton5.BorderRadius = 10;
            this.customButton5.BorderSize = 0;
            this.customButton5.FlatAppearance.BorderSize = 0;
            this.customButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton5.ForeColor = System.Drawing.Color.Black;
            this.customButton5.Image = global::GUI.Properties.Resources.emo10;
            this.customButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton5.Location = new System.Drawing.Point(3, 115);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(234, 50);
            this.customButton5.TabIndex = 64;
            this.customButton5.Text = "          Có phúc";
            this.customButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton5.TextColor = System.Drawing.Color.Black;
            this.customButton5.UseVisualStyleBackColor = false;
            // 
            // customButton6
            // 
            this.customButton6.AutoSize = true;
            this.customButton6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton6.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton6.BorderColor = System.Drawing.Color.Transparent;
            this.customButton6.BorderRadius = 10;
            this.customButton6.BorderSize = 0;
            this.customButton6.FlatAppearance.BorderSize = 0;
            this.customButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton6.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton6.ForeColor = System.Drawing.Color.Black;
            this.customButton6.Image = global::GUI.Properties.Resources.emo12;
            this.customButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton6.Location = new System.Drawing.Point(243, 115);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(234, 50);
            this.customButton6.TabIndex = 64;
            this.customButton6.Text = "          Đáng yêu";
            this.customButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton6.TextColor = System.Drawing.Color.Black;
            this.customButton6.UseVisualStyleBackColor = false;
            // 
            // customButton7
            // 
            this.customButton7.AutoSize = true;
            this.customButton7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton7.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton7.BorderColor = System.Drawing.Color.Transparent;
            this.customButton7.BorderRadius = 10;
            this.customButton7.BorderSize = 0;
            this.customButton7.FlatAppearance.BorderSize = 0;
            this.customButton7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton7.ForeColor = System.Drawing.Color.Black;
            this.customButton7.Image = global::GUI.Properties.Resources.emo13;
            this.customButton7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton7.Location = new System.Drawing.Point(3, 171);
            this.customButton7.Name = "customButton7";
            this.customButton7.Size = new System.Drawing.Size(234, 50);
            this.customButton7.TabIndex = 64;
            this.customButton7.Text = "          Bất lực";
            this.customButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton7.TextColor = System.Drawing.Color.Black;
            this.customButton7.UseVisualStyleBackColor = false;
            // 
            // customButton8
            // 
            this.customButton8.AutoSize = true;
            this.customButton8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton8.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton8.BorderColor = System.Drawing.Color.Transparent;
            this.customButton8.BorderRadius = 10;
            this.customButton8.BorderSize = 0;
            this.customButton8.FlatAppearance.BorderSize = 0;
            this.customButton8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton8.ForeColor = System.Drawing.Color.Black;
            this.customButton8.Image = global::GUI.Properties.Resources.emo14;
            this.customButton8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton8.Location = new System.Drawing.Point(243, 171);
            this.customButton8.Name = "customButton8";
            this.customButton8.Size = new System.Drawing.Size(234, 50);
            this.customButton8.TabIndex = 64;
            this.customButton8.Text = "          Mệt mỏi";
            this.customButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton8.TextColor = System.Drawing.Color.Black;
            this.customButton8.UseVisualStyleBackColor = false;
            // 
            // customButton9
            // 
            this.customButton9.AutoSize = true;
            this.customButton9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton9.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton9.BorderColor = System.Drawing.Color.Transparent;
            this.customButton9.BorderRadius = 10;
            this.customButton9.BorderSize = 0;
            this.customButton9.FlatAppearance.BorderSize = 0;
            this.customButton9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton9.ForeColor = System.Drawing.Color.Black;
            this.customButton9.Image = global::GUI.Properties.Resources.emo15;
            this.customButton9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton9.Location = new System.Drawing.Point(3, 227);
            this.customButton9.Name = "customButton9";
            this.customButton9.Size = new System.Drawing.Size(234, 50);
            this.customButton9.TabIndex = 64;
            this.customButton9.Text = "          Nghi ngờ";
            this.customButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton9.TextColor = System.Drawing.Color.Black;
            this.customButton9.UseVisualStyleBackColor = false;
            // 
            // customButton10
            // 
            this.customButton10.AutoSize = true;
            this.customButton10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.customButton10.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.customButton10.BorderColor = System.Drawing.Color.Transparent;
            this.customButton10.BorderRadius = 10;
            this.customButton10.BorderSize = 0;
            this.customButton10.FlatAppearance.BorderSize = 0;
            this.customButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton10.ForeColor = System.Drawing.Color.Black;
            this.customButton10.Image = global::GUI.Properties.Resources.emo08;
            this.customButton10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton10.Location = new System.Drawing.Point(243, 227);
            this.customButton10.Name = "customButton10";
            this.customButton10.Size = new System.Drawing.Size(234, 50);
            this.customButton10.TabIndex = 64;
            this.customButton10.Text = "          Hào hứng";
            this.customButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.customButton10.TextColor = System.Drawing.Color.Black;
            this.customButton10.UseVisualStyleBackColor = false;
            // 
            // customeInpputTextBox1
            // 
            this.customeInpputTextBox1.BackColor = System.Drawing.Color.White;
            this.customeInpputTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.customeInpputTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customeInpputTextBox1.BorderRadius = 0;
            this.customeInpputTextBox1.BorderSize = 1;
            this.customeInpputTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customeInpputTextBox1.Location = new System.Drawing.Point(0, 0);
            this.customeInpputTextBox1.Multiline = true;
            this.customeInpputTextBox1.Name = "customeInpputTextBox1";
            this.customeInpputTextBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customeInpputTextBox1.PasswordChar = false;
            this.customeInpputTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customeInpputTextBox1.PlaceholderText = "";
            this.customeInpputTextBox1.Size = new System.Drawing.Size(520, 280);
            this.customeInpputTextBox1.TabIndex = 0;
            this.customeInpputTextBox1.Texts = "";
            this.customeInpputTextBox1.UnderlinedStyle = false;
            // 
            // pnlAddPostActivity
            // 
            this.pnlAddPostActivity.BackColor = System.Drawing.Color.Transparent;
            this.pnlAddPostActivity.Controls.Add(this.flowLayoutPanel1);
            this.pnlAddPostActivity.Location = new System.Drawing.Point(3, 637);
            this.pnlAddPostActivity.Name = "pnlAddPostActivity";
            this.pnlAddPostActivity.Size = new System.Drawing.Size(520, 56);
            this.pnlAddPostActivity.TabIndex = 63;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.picMedia);
            this.flowLayoutPanel1.Controls.Add(this.picStatitude);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(520, 56);
            this.flowLayoutPanel1.TabIndex = 65;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.MinimumSize = new System.Drawing.Size(0, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 50);
            this.label1.TabIndex = 64;
            this.label1.Text = "Thêm vào bài viết của bạn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(209, 0);
            this.label3.MaximumSize = new System.Drawing.Size(623, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "                                                           ";
            // 
            // picMedia
            // 
            this.picMedia.Image = global::GUI.Properties.Resources._32_green_image;
            this.picMedia.Location = new System.Drawing.Point(399, 3);
            this.picMedia.Name = "picMedia";
            this.picMedia.Size = new System.Drawing.Size(50, 50);
            this.picMedia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMedia.TabIndex = 66;
            this.picMedia.TabStop = false;
            this.picMedia.Click += new System.EventHandler(this.picMedia_Click);
            // 
            // picStatitude
            // 
            this.picStatitude.Image = global::GUI.Properties.Resources._32_gold_smile;
            this.picStatitude.Location = new System.Drawing.Point(455, 3);
            this.picStatitude.Name = "picStatitude";
            this.picStatitude.Size = new System.Drawing.Size(50, 50);
            this.picStatitude.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStatitude.TabIndex = 66;
            this.picStatitude.TabStop = false;
            this.picStatitude.Click += new System.EventHandler(this.picStatitude_Click);
            // 
            // btnPost
            // 
            this.btnPost.AutoSize = true;
            this.btnPost.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnPost.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnPost.BorderColor = System.Drawing.Color.Transparent;
            this.btnPost.BorderRadius = 10;
            this.btnPost.BorderSize = 0;
            this.btnPost.FlatAppearance.BorderSize = 0;
            this.btnPost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPost.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPost.ForeColor = System.Drawing.Color.White;
            this.btnPost.Location = new System.Drawing.Point(3, 699);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(520, 50);
            this.btnPost.TabIndex = 64;
            this.btnPost.Text = "Đăng bài";
            this.btnPost.TextColor = System.Drawing.Color.White;
            this.btnPost.UseVisualStyleBackColor = false;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // flpOption
            // 
            this.flpOption.AutoSize = true;
            this.flpOption.Controls.Add(this.radioButton1);
            this.flpOption.Controls.Add(this.radioButton2);
            this.flpOption.Controls.Add(this.radioButton3);
            this.flpOption.Controls.Add(this.radioButton4);
            this.flpOption.Controls.Add(this.radioButton5);
            this.flpOption.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpOption.Location = new System.Drawing.Point(164, 104);
            this.flpOption.Name = "flpOption";
            this.flpOption.Size = new System.Drawing.Size(135, 120);
            this.flpOption.TabIndex = 60;
            this.flpOption.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton1.Location = new System.Drawing.Point(3, 3);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 18);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Công khai";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton2.Location = new System.Drawing.Point(3, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 18);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Bạn bè";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton3.Location = new System.Drawing.Point(3, 51);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(129, 18);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bạn bè ngoại trừ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton4.Location = new System.Drawing.Point(3, 75);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(110, 18);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bạn bè cụ thể";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.radioButton5.Location = new System.Drawing.Point(3, 99);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(99, 18);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Chỉ mình tôi";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.line1.BorderColor = System.Drawing.Color.Transparent;
            this.line1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.line1.BorderRadius = 0;
            this.line1.BorderSize = 2;
            this.line1.Location = new System.Drawing.Point(0, 65);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.line1.PasswordChar = false;
            this.line1.PlaceholderColor = System.Drawing.Color.Transparent;
            this.line1.PlaceholderText = "";
            this.line1.Size = new System.Drawing.Size(550, 1);
            this.line1.TabIndex = 54;
            this.line1.Texts = "";
            this.line1.UnderlinedStyle = false;
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlClose.Controls.Add(this.ptbClose);
            this.pnlClose.Location = new System.Drawing.Point(485, 5);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(50, 40);
            this.pnlClose.TabIndex = 61;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = global::GUI.Properties.Resources._24_black_close;
            this.ptbClose.Location = new System.Drawing.Point(19, 14);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(12, 12);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // pnlSelectForm
            // 
            this.pnlSelectForm.Controls.Add(this.label2);
            this.pnlSelectForm.Controls.Add(this.btnAccept);
            this.pnlSelectForm.Controls.Add(this.btnDecline);
            this.pnlSelectForm.Controls.Add(this.flpFriendsSelect);
            this.pnlSelectForm.Location = new System.Drawing.Point(13, 130);
            this.pnlSelectForm.Name = "pnlSelectForm";
            this.pnlSelectForm.Size = new System.Drawing.Size(525, 462);
            this.pnlSelectForm.TabIndex = 62;
            this.pnlSelectForm.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 65;
            this.label2.Text = "Chọn người dùng";
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(246)))));
            this.btnAccept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(246)))));
            this.btnAccept.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderRadius = 10;
            this.btnAccept.BorderSize = 0;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccept.ForeColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(275, 402);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(245, 50);
            this.btnAccept.TabIndex = 64;
            this.btnAccept.Text = "Xác nhận";
            this.btnAccept.TextColor = System.Drawing.Color.White;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.AutoSize = true;
            this.btnDecline.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecline.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecline.BorderColor = System.Drawing.Color.Transparent;
            this.btnDecline.BorderRadius = 10;
            this.btnDecline.BorderSize = 0;
            this.btnDecline.FlatAppearance.BorderSize = 0;
            this.btnDecline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecline.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDecline.ForeColor = System.Drawing.Color.Black;
            this.btnDecline.Location = new System.Drawing.Point(8, 402);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(245, 50);
            this.btnDecline.TabIndex = 63;
            this.btnDecline.Text = "Huỷ";
            this.btnDecline.TextColor = System.Drawing.Color.Black;
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // flpFriendsSelect
            // 
            this.flpFriendsSelect.AutoScroll = true;
            this.flpFriendsSelect.Location = new System.Drawing.Point(0, 45);
            this.flpFriendsSelect.Name = "flpFriendsSelect";
            this.flpFriendsSelect.Size = new System.Drawing.Size(525, 351);
            this.flpFriendsSelect.TabIndex = 0;
            // 
            // btnOption
            // 
            this.btnOption.AutoSize = true;
            this.btnOption.BackColor = System.Drawing.Color.Transparent;
            this.btnOption.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnOption.BorderColor = System.Drawing.Color.Transparent;
            this.btnOption.BorderRadius = 10;
            this.btnOption.BorderSize = 0;
            this.btnOption.FlatAppearance.BorderSize = 0;
            this.btnOption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnOption.ForeColor = System.Drawing.Color.Black;
            this.btnOption.Image = global::GUI.Properties.Resources._16_black_option;
            this.btnOption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.Location = new System.Drawing.Point(63, 103);
            this.btnOption.Name = "btnOption";
            this.btnOption.Size = new System.Drawing.Size(118, 24);
            this.btnOption.TabIndex = 57;
            this.btnOption.Text = "     Công khai";
            this.btnOption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOption.TextColor = System.Drawing.Color.Black;
            this.btnOption.UseVisualStyleBackColor = false;
            this.btnOption.Click += new System.EventHandler(this.btnOption_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(15, 85);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(38, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 55;
            this.picAvatar.TabStop = false;
            // 
            // PostingFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 615);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.flpOption);
            this.Controls.Add(this.btnOption);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lblIntro);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.pnlSelectForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(545, 615);
            this.Name = "PostingFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.flpContent.ResumeLayout(false);
            this.flpContent.PerformLayout();
            this.pnlMedia.ResumeLayout(false);
            this.pnlMedia.PerformLayout();
            this.pnlStatitude.ResumeLayout(false);
            this.flpStatitude.ResumeLayout(false);
            this.flpStatitude.PerformLayout();
            this.pnlAddPostActivity.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMedia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picStatitude)).EndInit();
            this.flpOption.ResumeLayout(false);
            this.flpOption.PerformLayout();
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.pnlSelectForm.ResumeLayout(false);
            this.pnlSelectForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.CustomeInpputTextBox border;
        private System.Windows.Forms.Label lblIntro;
        private Components.CustomeInpputTextBox line1;
        private System.Windows.Forms.Label lblName;
        private Controls.CustomePicture picAvatar;
        private Components.CustomButton btnOption;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private System.Windows.Forms.Panel pnlMedia;
        private Components.CustomButton btnAddImageFromFile;
        private Components.CustomButton btnTakeAPhoto;
        private System.Windows.Forms.Panel pnlAddPostActivity;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picMedia;
        private System.Windows.Forms.PictureBox picStatitude;
        private Components.CustomButton btnPost;
        private System.Windows.Forms.FlowLayoutPanel flpImagePosting;
        private System.Windows.Forms.Panel pnlStatitude;
        private Components.CustomeInpputTextBox customeInpputTextBox1;
        private System.Windows.Forms.FlowLayoutPanel flpStatitude;
        private Components.CustomButton customButton1;
        private Components.CustomButton customButton2;
        private Components.CustomButton customButton3;
        private Components.CustomButton customButton4;
        private Components.CustomButton customButton5;
        private Components.CustomButton customButton6;
        private Components.CustomButton customButton7;
        private Components.CustomButton customButton8;
        private Components.CustomButton customButton9;
        private Components.CustomButton customButton10;
        private System.Windows.Forms.FlowLayoutPanel flpOption;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.Panel pnlSelectForm;
        private System.Windows.Forms.FlowLayoutPanel flpFriendsSelect;
        private Components.CustomButton btnAccept;
        private Components.CustomButton btnDecline;
        private System.Windows.Forms.Label label2;
    }
}