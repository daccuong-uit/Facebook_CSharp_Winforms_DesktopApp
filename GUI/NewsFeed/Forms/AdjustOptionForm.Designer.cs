namespace GUI.NewsFeed.Forms
{
    partial class AdjustOptionForm
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
            this.pnlClose = new System.Windows.Forms.Panel();
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.line1 = new GUI.Components.CustomeInpputTextBox();
            this.lblIntro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnTakeAPhoto = new GUI.Components.CustomButton();
            this.customButton1 = new GUI.Components.CustomButton();
            this.customButton2 = new GUI.Components.CustomButton();
            this.customButton3 = new GUI.Components.CustomButton();
            this.customButton4 = new GUI.Components.CustomButton();
            this.flpFriendsSelect = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAccept = new GUI.Components.CustomButton();
            this.btnDecline = new GUI.Components.CustomButton();
            this.customButton5 = new GUI.Components.CustomButton();
            this.customButton6 = new GUI.Components.CustomButton();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlClose.Controls.Add(this.ptbClose);
            this.pnlClose.Location = new System.Drawing.Point(483, 3);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(50, 40);
            this.pnlClose.TabIndex = 64;
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
            // line1
            // 
            this.line1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.line1.BorderColor = System.Drawing.Color.Transparent;
            this.line1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.line1.BorderRadius = 0;
            this.line1.BorderSize = 2;
            this.line1.Location = new System.Drawing.Point(-2, 63);
            this.line1.Multiline = true;
            this.line1.Name = "line1";
            this.line1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.line1.PasswordChar = false;
            this.line1.PlaceholderColor = System.Drawing.Color.Transparent;
            this.line1.PlaceholderText = "";
            this.line1.Size = new System.Drawing.Size(550, 1);
            this.line1.TabIndex = 63;
            this.line1.Texts = "";
            this.line1.UnderlinedStyle = false;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(186, 18);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(172, 25);
            this.lblIntro.TabIndex = 62;
            this.lblIntro.Text = "Chọn đối tượng";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.btnTakeAPhoto);
            this.flowLayoutPanel1.Controls.Add(this.customButton1);
            this.flowLayoutPanel1.Controls.Add(this.customButton2);
            this.flowLayoutPanel1.Controls.Add(this.customButton3);
            this.flowLayoutPanel1.Controls.Add(this.customButton4);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 70);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(524, 280);
            this.flowLayoutPanel1.TabIndex = 65;
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
            this.btnTakeAPhoto.Location = new System.Drawing.Point(3, 3);
            this.btnTakeAPhoto.Name = "btnTakeAPhoto";
            this.btnTakeAPhoto.Size = new System.Drawing.Size(518, 50);
            this.btnTakeAPhoto.TabIndex = 63;
            this.btnTakeAPhoto.Text = "Công khai";
            this.btnTakeAPhoto.TextColor = System.Drawing.Color.Black;
            this.btnTakeAPhoto.UseVisualStyleBackColor = false;
            this.btnTakeAPhoto.Click += new System.EventHandler(this.btnTakeAPhoto_Click);
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
            this.customButton1.Location = new System.Drawing.Point(3, 59);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(518, 50);
            this.customButton1.TabIndex = 64;
            this.customButton1.Text = "Bạn bè";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
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
            this.customButton2.Location = new System.Drawing.Point(3, 115);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(518, 50);
            this.customButton2.TabIndex = 65;
            this.customButton2.Text = "Bạn bè ngoại trừ";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.customButton2_Click);
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
            this.customButton3.Location = new System.Drawing.Point(3, 171);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(518, 50);
            this.customButton3.TabIndex = 66;
            this.customButton3.Text = "Bạn bè cụ thể";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = false;
            this.customButton3.Click += new System.EventHandler(this.customButton3_Click);
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
            this.customButton4.Location = new System.Drawing.Point(3, 227);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(518, 50);
            this.customButton4.TabIndex = 67;
            this.customButton4.Text = "Chỉ mình tôi";
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = false;
            this.customButton4.Click += new System.EventHandler(this.customButton4_Click);
            // 
            // flpFriendsSelect
            // 
            this.flpFriendsSelect.AutoScroll = true;
            this.flpFriendsSelect.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpFriendsSelect.Location = new System.Drawing.Point(0, 0);
            this.flpFriendsSelect.Name = "flpFriendsSelect";
            this.flpFriendsSelect.Size = new System.Drawing.Size(524, 510);
            this.flpFriendsSelect.TabIndex = 66;
            this.flpFriendsSelect.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAccept);
            this.panel1.Controls.Add(this.btnDecline);
            this.panel1.Controls.Add(this.flpFriendsSelect);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 580);
            this.panel1.TabIndex = 67;
            this.panel1.Visible = false;
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccept.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccept.BorderColor = System.Drawing.Color.Transparent;
            this.btnAccept.BorderRadius = 10;
            this.btnAccept.BorderSize = 0;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnAccept.ForeColor = System.Drawing.Color.Black;
            this.btnAccept.Location = new System.Drawing.Point(269, 516);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(242, 50);
            this.btnAccept.TabIndex = 67;
            this.btnAccept.Text = "Đồng ý";
            this.btnAccept.TextColor = System.Drawing.Color.Black;
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
            this.btnDecline.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDecline.ForeColor = System.Drawing.Color.Black;
            this.btnDecline.Location = new System.Drawing.Point(21, 516);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(242, 50);
            this.btnDecline.TabIndex = 67;
            this.btnDecline.Text = "Huỷ";
            this.btnDecline.TextColor = System.Drawing.Color.Black;
            this.btnDecline.UseVisualStyleBackColor = false;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
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
            this.customButton5.Location = new System.Drawing.Point(281, 600);
            this.customButton5.Name = "customButton5";
            this.customButton5.Size = new System.Drawing.Size(242, 50);
            this.customButton5.TabIndex = 68;
            this.customButton5.Text = "Đồng ý";
            this.customButton5.TextColor = System.Drawing.Color.Black;
            this.customButton5.UseVisualStyleBackColor = false;
            this.customButton5.Click += new System.EventHandler(this.customButton5_Click);
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
            this.customButton6.Location = new System.Drawing.Point(33, 600);
            this.customButton6.Name = "customButton6";
            this.customButton6.Size = new System.Drawing.Size(242, 50);
            this.customButton6.TabIndex = 69;
            this.customButton6.Text = "Huỷ";
            this.customButton6.TextColor = System.Drawing.Color.Black;
            this.customButton6.UseVisualStyleBackColor = false;
            this.customButton6.Click += new System.EventHandler(this.customButton6_Click);
            // 
            // AdjustOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 660);
            this.Controls.Add(this.customButton5);
            this.Controls.Add(this.customButton6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlClose);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.lblIntro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdjustOptionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdjustOptionForm";
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.PictureBox ptbClose;
        private Components.CustomeInpputTextBox line1;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Components.CustomButton btnTakeAPhoto;
        private Components.CustomButton customButton1;
        private Components.CustomButton customButton2;
        private Components.CustomButton customButton3;
        private Components.CustomButton customButton4;
        private System.Windows.Forms.FlowLayoutPanel flpFriendsSelect;
        private System.Windows.Forms.Panel panel1;
        private Components.CustomButton btnDecline;
        private Components.CustomButton btnAccept;
        private Components.CustomButton customButton5;
        private Components.CustomButton customButton6;
    }
}