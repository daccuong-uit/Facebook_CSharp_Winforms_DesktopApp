namespace GUI.NewsFeed.UserControls.Comments
{
    partial class UCComments
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
            this.border = new GUI.Components.CustomButton();
            this.lblCmt = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(55, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 35;
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
            this.picAvatar.TabIndex = 34;
            this.picAvatar.TabStop = false;
            // 
            // border
            // 
            this.border.AutoSize = true;
            this.border.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.border.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.border.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.border.BorderRadius = 12;
            this.border.BorderSize = 0;
            this.border.Enabled = false;
            this.border.FlatAppearance.BorderSize = 0;
            this.border.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.border.ForeColor = System.Drawing.Color.White;
            this.border.Location = new System.Drawing.Point(50, 3);
            this.border.Name = "border";
            this.border.Size = new System.Drawing.Size(154, 56);
            this.border.TabIndex = 37;
            this.border.TextColor = System.Drawing.Color.White;
            this.border.UseVisualStyleBackColor = false;
            // 
            // lblCmt
            // 
            this.lblCmt.AutoSize = true;
            this.lblCmt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.lblCmt.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblCmt.ForeColor = System.Drawing.Color.Black;
            this.lblCmt.Location = new System.Drawing.Point(55, 28);
            this.lblCmt.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblCmt.Name = "lblCmt";
            this.lblCmt.Size = new System.Drawing.Size(38, 18);
            this.lblCmt.TabIndex = 36;
            this.lblCmt.Text = "Hello";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(50, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(550, 1);
            this.flowLayoutPanel1.TabIndex = 38;
            // 
            // UCComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCmt);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.picAvatar);
            this.Controls.Add(this.border);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "UCComments";
            this.Size = new System.Drawing.Size(603, 110);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblName;
        private Controls.CustomePicture picAvatar;
        private Components.CustomButton border;
        private System.Windows.Forms.Label lblCmt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
