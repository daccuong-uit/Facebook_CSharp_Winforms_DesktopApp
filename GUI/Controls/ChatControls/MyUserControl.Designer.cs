namespace GUI.Controls.ChatControls
{
    partial class MyUserControl
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblLastMess = new System.Windows.Forms.Label();
            this.picAvatar = new GUI.Controls.CustomePicture();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AllowDrop = true;
            this.lblUserName.AutoEllipsis = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUserName.Location = new System.Drawing.Point(60, 10);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(240, 24);
            this.lblUserName.TabIndex = 2;
            this.lblUserName.Text = "Nguyễn Đắc Cường";
            // 
            // lblLastMess
            // 
            this.lblLastMess.AllowDrop = true;
            this.lblLastMess.AutoEllipsis = true;
            this.lblLastMess.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMess.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLastMess.ForeColor = System.Drawing.Color.Gray;
            this.lblLastMess.Location = new System.Drawing.Point(62, 33);
            this.lblLastMess.Name = "lblLastMess";
            this.lblLastMess.Size = new System.Drawing.Size(238, 20);
            this.lblLastMess.TabIndex = 3;
            this.lblLastMess.Text = "Nguyễn Đắc Cường";
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.White;
            this.picAvatar.Enabled = false;
            this.picAvatar.Image = global::GUI.Properties.Resources.avatar;
            this.picAvatar.Location = new System.Drawing.Point(3, 3);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(50, 50);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // MyUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblLastMess);
            this.Name = "MyUserControl";
            this.Size = new System.Drawing.Size(300, 56);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CustomePicture picAvatar;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblLastMess;
    }
}
