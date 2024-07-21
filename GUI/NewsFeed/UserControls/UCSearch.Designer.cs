namespace GUI.NewsFeed.UserControls
{
    partial class UCSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAll = new GUI.Components.CustomButton();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucFriendUI2 = new GUI.NewsFeed.UserControls.Friends.UCFriendUI();
            this.btnGroups = new GUI.Components.CustomButton();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.flpBtn = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIntro = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.line1 = new GUI.Components.CustomeInpputTextBox();
            this.btnPosst = new GUI.Components.CustomButton();
            this.btnPeople = new GUI.Components.CustomButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.ucFriendUI1 = new GUI.NewsFeed.UserControls.Friends.UCFriendUI();
            this.ucFriendUI3 = new GUI.NewsFeed.UserControls.Friends.UCFriendUI();
            this.ucFeed2 = new GUI.NewsFeed.UserControls.UCFeed();
            this.flpContent.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            this.flpBtn.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAll
            // 
            this.btnAll.BackColor = System.Drawing.Color.Transparent;
            this.btnAll.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderColor = System.Drawing.Color.Transparent;
            this.btnAll.BorderRadius = 12;
            this.btnAll.BorderSize = 0;
            this.btnAll.FlatAppearance.BorderSize = 0;
            this.btnAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAll.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAll.ForeColor = System.Drawing.Color.Black;
            this.btnAll.Image = global::GUI.Properties.Resources._32_blue_film;
            this.btnAll.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.Location = new System.Drawing.Point(3, 48);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(280, 40);
            this.btnAll.TabIndex = 38;
            this.btnAll.Text = "         Tất cả";
            this.btnAll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAll.TextColor = System.Drawing.Color.Black;
            this.btnAll.UseVisualStyleBackColor = false;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Controls.Add(this.flowLayoutPanel1);
            this.flpContent.Controls.Add(this.flowLayoutPanel2);
            this.flpContent.Location = new System.Drawing.Point(475, 0);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(805, 630);
            this.flpContent.TabIndex = 8;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.ucFriendUI2);
            this.flowLayoutPanel1.Controls.Add(this.ucFriendUI1);
            this.flowLayoutPanel1.Controls.Add(this.ucFriendUI3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(636, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(636, 322);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // ucFriendUI2
            // 
            this.ucFriendUI2.BackColor = System.Drawing.Color.White;
            this.ucFriendUI2.Location = new System.Drawing.Point(3, 3);
            this.ucFriendUI2.MaximumSize = new System.Drawing.Size(222, 355);
            this.ucFriendUI2.Name = "ucFriendUI2";
            this.ucFriendUI2.Size = new System.Drawing.Size(206, 316);
            this.ucFriendUI2.TabIndex = 2;
            // 
            // btnGroups
            // 
            this.btnGroups.BackColor = System.Drawing.Color.Transparent;
            this.btnGroups.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnGroups.BorderColor = System.Drawing.Color.Transparent;
            this.btnGroups.BorderRadius = 12;
            this.btnGroups.BorderSize = 0;
            this.btnGroups.FlatAppearance.BorderSize = 0;
            this.btnGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroups.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnGroups.ForeColor = System.Drawing.Color.Black;
            this.btnGroups.Image = global::GUI.Properties.Resources._32_blue_groups;
            this.btnGroups.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.Location = new System.Drawing.Point(3, 186);
            this.btnGroups.Name = "btnGroups";
            this.btnGroups.Size = new System.Drawing.Size(280, 40);
            this.btnGroups.TabIndex = 39;
            this.btnGroups.Text = "         Nhóm";
            this.btnGroups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGroups.TextColor = System.Drawing.Color.Black;
            this.btnGroups.UseVisualStyleBackColor = false;
            this.btnGroups.Visible = false;
            this.btnGroups.Click += new System.EventHandler(this.btnGroups_Click);
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.BackColor = System.Drawing.Color.White;
            this.pnlMenu.Controls.Add(this.flpBtn);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(310, 630);
            this.pnlMenu.TabIndex = 7;
            // 
            // flpBtn
            // 
            this.flpBtn.BackColor = System.Drawing.Color.Transparent;
            this.flpBtn.Controls.Add(this.lblIntro);
            this.flpBtn.Controls.Add(this.label8);
            this.flpBtn.Controls.Add(this.line1);
            this.flpBtn.Controls.Add(this.btnAll);
            this.flpBtn.Controls.Add(this.btnPosst);
            this.flpBtn.Controls.Add(this.btnPeople);
            this.flpBtn.Controls.Add(this.btnGroups);
            this.flpBtn.Location = new System.Drawing.Point(0, 0);
            this.flpBtn.Name = "flpBtn";
            this.flpBtn.Size = new System.Drawing.Size(292, 627);
            this.flpBtn.TabIndex = 39;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(3, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(191, 25);
            this.lblIntro.TabIndex = 40;
            this.lblIntro.Text = "Kết quả tìm kiếm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 25);
            this.label8.MaximumSize = new System.Drawing.Size(623, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "                                                        ";
            // 
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.line1.BorderColor = System.Drawing.Color.Transparent;
            this.line1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.line1.BorderRadius = 0;
            this.line1.BorderSize = 2;
            this.line1.Location = new System.Drawing.Point(3, 41);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.line1.PasswordChar = false;
            this.line1.PlaceholderColor = System.Drawing.Color.Transparent;
            this.line1.PlaceholderText = "";
            this.line1.Size = new System.Drawing.Size(307, 1);
            this.line1.TabIndex = 53;
            this.line1.Texts = "";
            this.line1.UnderlinedStyle = false;
            // 
            // btnPosst
            // 
            this.btnPosst.BackColor = System.Drawing.Color.Transparent;
            this.btnPosst.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPosst.BorderColor = System.Drawing.Color.Transparent;
            this.btnPosst.BorderRadius = 12;
            this.btnPosst.BorderSize = 0;
            this.btnPosst.FlatAppearance.BorderSize = 0;
            this.btnPosst.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosst.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPosst.ForeColor = System.Drawing.Color.Black;
            this.btnPosst.Image = global::GUI.Properties.Resources._32_blue_film;
            this.btnPosst.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosst.Location = new System.Drawing.Point(3, 94);
            this.btnPosst.Name = "btnPosst";
            this.btnPosst.Size = new System.Drawing.Size(280, 40);
            this.btnPosst.TabIndex = 57;
            this.btnPosst.Text = "         Bài viết";
            this.btnPosst.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPosst.TextColor = System.Drawing.Color.Black;
            this.btnPosst.UseVisualStyleBackColor = false;
            this.btnPosst.Click += new System.EventHandler(this.btnPosst_Click);
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.Color.Transparent;
            this.btnPeople.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPeople.BorderColor = System.Drawing.Color.Transparent;
            this.btnPeople.BorderRadius = 12;
            this.btnPeople.BorderSize = 0;
            this.btnPeople.FlatAppearance.BorderSize = 0;
            this.btnPeople.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPeople.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPeople.ForeColor = System.Drawing.Color.Black;
            this.btnPeople.Image = global::GUI.Properties.Resources._32_blue_film;
            this.btnPeople.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.Location = new System.Drawing.Point(3, 140);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(280, 40);
            this.btnPeople.TabIndex = 56;
            this.btnPeople.Text = "         Mọi người";
            this.btnPeople.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPeople.TextColor = System.Drawing.Color.Black;
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.Controls.Add(this.ucFeed2);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 331);
            this.flowLayoutPanel2.MaximumSize = new System.Drawing.Size(638, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(638, 517);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // ucFriendUI1
            // 
            this.ucFriendUI1.BackColor = System.Drawing.Color.White;
            this.ucFriendUI1.Location = new System.Drawing.Point(215, 3);
            this.ucFriendUI1.MaximumSize = new System.Drawing.Size(222, 355);
            this.ucFriendUI1.Name = "ucFriendUI1";
            this.ucFriendUI1.Size = new System.Drawing.Size(206, 316);
            this.ucFriendUI1.TabIndex = 3;
            // 
            // ucFriendUI3
            // 
            this.ucFriendUI3.BackColor = System.Drawing.Color.White;
            this.ucFriendUI3.Location = new System.Drawing.Point(427, 3);
            this.ucFriendUI3.MaximumSize = new System.Drawing.Size(222, 355);
            this.ucFriendUI3.Name = "ucFriendUI3";
            this.ucFriendUI3.Size = new System.Drawing.Size(206, 316);
            this.ucFriendUI3.TabIndex = 4;
            // 
            // ucFeed2
            // 
            this.ucFeed2.AutoSize = true;
            this.ucFeed2.BackColor = System.Drawing.Color.White;
            this.ucFeed2.Location = new System.Drawing.Point(3, 3);
            this.ucFeed2.MinimumSize = new System.Drawing.Size(632, 0);
            this.ucFeed2.Name = "ucFeed2";
            this.ucFeed2.Size = new System.Drawing.Size(635, 511);
            this.ucFeed2.TabIndex = 5;
            // 
            // UCSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "UCSearch";
            this.Size = new System.Drawing.Size(1280, 630);
            this.flpContent.ResumeLayout(false);
            this.flpContent.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.pnlMenu.ResumeLayout(false);
            this.flpBtn.ResumeLayout(false);
            this.flpBtn.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CustomButton btnAll;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
        private Components.CustomButton btnGroups;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.FlowLayoutPanel flpBtn;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label label8;
        private Components.CustomeInpputTextBox line1;
        private Components.CustomButton btnPosst;
        private Components.CustomButton btnPeople;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Friends.UCFriendUI ucFriendUI2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private Friends.UCFriendUI ucFriendUI1;
        private Friends.UCFriendUI ucFriendUI3;
        private UCFeed ucFeed2;
    }
}
