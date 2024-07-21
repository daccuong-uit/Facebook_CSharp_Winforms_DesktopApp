namespace GUI.Controls.ChatControls
{
    partial class IconChatUsers
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
            this.lblTime = new System.Windows.Forms.Label();
            this.picEmo = new System.Windows.Forms.PictureBox();
            this.picAvatar = new GUI.Controls.CustomePicture();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picEmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AllowDrop = true;
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTime.AutoEllipsis = true;
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblTime.ForeColor = System.Drawing.Color.Gray;
            this.lblTime.Location = new System.Drawing.Point(6, 45);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(50, 15);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "5:55 PM";
            // 
            // picEmo
            // 
            this.picEmo.Image = global::GUI.Properties.Resources.ic_Facebook;
            this.picEmo.Location = new System.Drawing.Point(10, 0);
            this.picEmo.Name = "picEmo";
            this.picEmo.Size = new System.Drawing.Size(42, 42);
            this.picEmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEmo.TabIndex = 8;
            this.picEmo.TabStop = false;
            // 
            // picAvatar
            // 
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(3, 3);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 2;
            this.picAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTime);
            this.panel1.Controls.Add(this.picEmo);
            this.panel1.Location = new System.Drawing.Point(70, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 66);
            this.panel1.TabIndex = 9;
            // 
            // IconChatUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.panel1);
            this.Name = "IconChatUsers";
            this.Size = new System.Drawing.Size(181, 93);
            ((System.ComponentModel.ISupportInitialize)(this.picEmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomePicture picAvatar;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.PictureBox picEmo;
        private System.Windows.Forms.Panel panel1;
    }
}
