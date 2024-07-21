namespace GUI.NewsFeed.UserControls.UCUserProfiles
{
    partial class UCVideoPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCVideoPost));
            this.btnLike = new System.Windows.Forms.Button();
            this.btnCmt = new System.Windows.Forms.Button();
            this.btnShare = new System.Windows.Forms.Button();
            this.picEmo = new System.Windows.Forms.PictureBox();
            this.lblNumberofLike = new System.Windows.Forms.Label();
            this.lblNumberofCmt = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.picAvatar = new GUI.Controls.CustomePicture();
            this.lblCaption = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Media = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picEmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLike
            // 
            this.btnLike.BackColor = System.Drawing.Color.Transparent;
            this.btnLike.FlatAppearance.BorderSize = 0;
            this.btnLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLike.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnLike.ForeColor = System.Drawing.Color.DimGray;
            this.btnLike.Image = global::GUI.Properties.Resources._32_dimgray_like;
            this.btnLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.Location = new System.Drawing.Point(0, 0);
            this.btnLike.Name = "btnLike";
            this.btnLike.Size = new System.Drawing.Size(100, 35);
            this.btnLike.TabIndex = 36;
            this.btnLike.Text = "          Thích";
            this.btnLike.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLike.UseVisualStyleBackColor = false;
            // 
            // btnCmt
            // 
            this.btnCmt.BackColor = System.Drawing.Color.Transparent;
            this.btnCmt.FlatAppearance.BorderSize = 0;
            this.btnCmt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCmt.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnCmt.ForeColor = System.Drawing.Color.DimGray;
            this.btnCmt.Image = global::GUI.Properties.Resources._32_dimgray_comment;
            this.btnCmt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCmt.Location = new System.Drawing.Point(106, 0);
            this.btnCmt.Name = "btnCmt";
            this.btnCmt.Size = new System.Drawing.Size(120, 35);
            this.btnCmt.TabIndex = 37;
            this.btnCmt.Text = "          Bình luận";
            this.btnCmt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCmt.UseVisualStyleBackColor = false;
            // 
            // btnShare
            // 
            this.btnShare.BackColor = System.Drawing.Color.Transparent;
            this.btnShare.FlatAppearance.BorderSize = 0;
            this.btnShare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShare.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnShare.ForeColor = System.Drawing.Color.DimGray;
            this.btnShare.Image = global::GUI.Properties.Resources._32_dimgray_share;
            this.btnShare.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShare.Location = new System.Drawing.Point(232, 0);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(111, 35);
            this.btnShare.TabIndex = 38;
            this.btnShare.Text = "          Chia sẻ";
            this.btnShare.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShare.UseVisualStyleBackColor = false;
            // 
            // picEmo
            // 
            this.picEmo.Image = global::GUI.Properties.Resources.emo011;
            this.picEmo.Location = new System.Drawing.Point(617, 0);
            this.picEmo.Name = "picEmo";
            this.picEmo.Size = new System.Drawing.Size(24, 24);
            this.picEmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmo.TabIndex = 39;
            this.picEmo.TabStop = false;
            // 
            // lblNumberofLike
            // 
            this.lblNumberofLike.AutoSize = true;
            this.lblNumberofLike.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberofLike.Location = new System.Drawing.Point(647, 0);
            this.lblNumberofLike.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblNumberofLike.Name = "lblNumberofLike";
            this.lblNumberofLike.Size = new System.Drawing.Size(28, 24);
            this.lblNumberofLike.TabIndex = 40;
            this.lblNumberofLike.Text = "113";
            this.lblNumberofLike.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNumberofCmt
            // 
            this.lblNumberofCmt.AutoSize = true;
            this.lblNumberofCmt.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblNumberofCmt.Location = new System.Drawing.Point(692, 0);
            this.lblNumberofCmt.MinimumSize = new System.Drawing.Size(0, 24);
            this.lblNumberofCmt.Name = "lblNumberofCmt";
            this.lblNumberofCmt.Size = new System.Drawing.Size(81, 24);
            this.lblNumberofCmt.TabIndex = 41;
            this.lblNumberofCmt.Tag = " ";
            this.lblNumberofCmt.Text = "113 Bình luận";
            this.lblNumberofCmt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTime.ForeColor = System.Drawing.Color.DimGray;
            this.lblTime.Location = new System.Drawing.Point(47, 27);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(110, 14);
            this.lblTime.TabIndex = 46;
            this.lblTime.Text = "Một vài phút trước";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(47, 3);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "Nguyễn Đắc Cường";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(3, 3);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(38, 38);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 44;
            this.picAvatar.TabStop = false;
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.BackColor = System.Drawing.Color.Transparent;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCaption.ForeColor = System.Drawing.Color.Black;
            this.lblCaption.Location = new System.Drawing.Point(3, 0);
            this.lblCaption.MaximumSize = new System.Drawing.Size(778, 0);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(773, 72);
            this.lblCaption.TabIndex = 43;
            this.lblCaption.Text = resources.GetString("lblCaption.Text");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.lblCaption);
            this.flowLayoutPanel1.Controls.Add(this.Media);
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 45);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(800, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(800, 656);
            this.flowLayoutPanel1.TabIndex = 47;
            // 
            // Media
            // 
            this.Media.Enabled = true;
            this.Media.Location = new System.Drawing.Point(3, 75);
            this.Media.Name = "Media";
            this.Media.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Media.OcxState")));
            this.Media.Size = new System.Drawing.Size(783, 532);
            this.Media.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnLike);
            this.panel1.Controls.Add(this.btnShare);
            this.panel1.Controls.Add(this.btnCmt);
            this.panel1.Controls.Add(this.lblNumberofLike);
            this.panel1.Controls.Add(this.picEmo);
            this.panel1.Controls.Add(this.lblNumberofCmt);
            this.panel1.Location = new System.Drawing.Point(3, 613);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1019, 40);
            this.panel1.TabIndex = 48;
            // 
            // UCVideoPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Name = "UCVideoPost";
            this.Size = new System.Drawing.Size(803, 704);
            ((System.ComponentModel.ISupportInitialize)(this.picEmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Media)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLike;
        private System.Windows.Forms.Button btnCmt;
        private System.Windows.Forms.Button btnShare;
        private System.Windows.Forms.PictureBox picEmo;
        private System.Windows.Forms.Label lblNumberofLike;
        private System.Windows.Forms.Label lblNumberofCmt;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblName;
        private Controls.CustomePicture picAvatar;
        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private AxWMPLib.AxWindowsMediaPlayer Media;
        private System.Windows.Forms.Panel panel1;
    }
}
