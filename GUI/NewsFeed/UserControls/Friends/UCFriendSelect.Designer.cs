namespace GUI.NewsFeed.UserControls.Friends
{
    partial class UCFriendSelect
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
            this.lblName = new System.Windows.Forms.Label();
            this.customePicture1 = new GUI.Controls.CustomePicture();
            this.picAvatar = new GUI.Controls.CustomePicture();
            ((System.ComponentModel.ISupportInitialize)(this.customePicture1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(63, 18);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Nguyễn Đắc Cường";
            // 
            // customePicture1
            // 
            this.customePicture1.Image = global::GUI.Properties.Resources._32_dimgray_tick;
            this.customePicture1.Location = new System.Drawing.Point(450, 9);
            this.customePicture1.Name = "customePicture1";
            this.customePicture1.Size = new System.Drawing.Size(32, 32);
            this.customePicture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.customePicture1.TabIndex = 37;
            this.customePicture1.TabStop = false;
            this.customePicture1.Click += new System.EventHandler(this.customePicture1_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 35;
            this.picAvatar.TabStop = false;
            // 
            // UCFriendSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customePicture1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Name = "UCFriendSelect";
            this.Size = new System.Drawing.Size(500, 50);
            ((System.ComponentModel.ISupportInitialize)(this.customePicture1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Controls.CustomePicture picAvatar;
        private Controls.CustomePicture customePicture1;
    }
}
