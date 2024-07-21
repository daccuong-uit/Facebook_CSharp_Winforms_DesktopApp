namespace GUI.NewsFeed.UserControls.Friends
{
    partial class FriendInFeed
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
            this.picAvatar = new GUI.Controls.CustomePicture();
            this.btnSendRequest = new GUI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(51, 17);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 36;
            this.lblName.Text = "Nguyễn Đắc Cường";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // picAvatar
            // 
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(3, 8);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(34, 34);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 35;
            this.picAvatar.TabStop = false;
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnSendRequest.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.btnSendRequest.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnSendRequest.BorderRadius = 12;
            this.btnSendRequest.BorderSize = 0;
            this.btnSendRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSendRequest.ForeColor = System.Drawing.Color.Black;
            this.btnSendRequest.Location = new System.Drawing.Point(295, 7);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(212, 35);
            this.btnSendRequest.TabIndex = 71;
            this.btnSendRequest.Text = "Thêm bạn bè";
            this.btnSendRequest.TextColor = System.Drawing.Color.Black;
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // FriendInFeed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Name = "FriendInFeed";
            this.Size = new System.Drawing.Size(510, 50);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private Controls.CustomePicture picAvatar;
        private Components.CustomButton btnSendRequest;
    }
}
