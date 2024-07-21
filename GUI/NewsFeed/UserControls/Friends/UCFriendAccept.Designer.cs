namespace GUI.NewsFeed.UserControls.Comments
{
    partial class UCFriendAccept
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBanChung = new System.Windows.Forms.Label();
            this.customButton10 = new GUI.Components.CustomButton();
            this.customButton1 = new GUI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(3, 230);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(149, 18);
            this.lblName.TabIndex = 33;
            this.lblName.Text = "Nguyễn Đắc Cường";
            // 
            // lblBanChung
            // 
            this.lblBanChung.AutoSize = true;
            this.lblBanChung.BackColor = System.Drawing.Color.Transparent;
            this.lblBanChung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblBanChung.ForeColor = System.Drawing.Color.DimGray;
            this.lblBanChung.Location = new System.Drawing.Point(4, 255);
            this.lblBanChung.Name = "lblBanChung";
            this.lblBanChung.Size = new System.Drawing.Size(110, 14);
            this.lblBanChung.TabIndex = 34;
            this.lblBanChung.Text = "Một vài phút trước";
            // 
            // customButton10
            // 
            this.customButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.customButton10.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.customButton10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.customButton10.BorderRadius = 12;
            this.customButton10.BorderSize = 0;
            this.customButton10.FlatAppearance.BorderSize = 0;
            this.customButton10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton10.ForeColor = System.Drawing.Color.White;
            this.customButton10.Location = new System.Drawing.Point(5, 272);
            this.customButton10.Name = "customButton10";
            this.customButton10.Size = new System.Drawing.Size(212, 35);
            this.customButton10.TabIndex = 70;
            this.customButton10.Text = "Xác nhận";
            this.customButton10.TextColor = System.Drawing.Color.White;
            this.customButton10.UseVisualStyleBackColor = false;
            this.customButton10.Click += new System.EventHandler(this.customButton10_Click);
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customButton1.BorderRadius = 12;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customButton1.ForeColor = System.Drawing.Color.Black;
            this.customButton1.Location = new System.Drawing.Point(5, 313);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(212, 35);
            this.customButton1.TabIndex = 71;
            this.customButton1.Text = "Xoá";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // UCFriendAccept
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customButton10);
            this.Controls.Add(this.lblBanChung);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UCFriendAccept";
            this.Size = new System.Drawing.Size(222, 355);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBanChung;
        private Components.CustomButton customButton10;
        private Components.CustomButton customButton1;
    }
}
