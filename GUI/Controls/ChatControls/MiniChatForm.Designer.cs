namespace GUI.Controls.ChatControls
{
    partial class MiniChatForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMini = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.lblTextChatUserName = new System.Windows.Forms.Label();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnlChatBar = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.picLike = new System.Windows.Forms.PictureBox();
            this.customeInpputTextBox1 = new GUI.Components.CustomeInpputTextBox();
            this.picGotoChatUser = new GUI.Controls.CustomePicture();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            this.pnlOption.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnlChatBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGotoChatUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picMini);
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.lblTextChatUserName);
            this.panel1.Controls.Add(this.pnlOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 40);
            this.panel1.TabIndex = 2;
            // 
            // picMini
            // 
            this.picMini.Image = global::GUI.Properties.Resources._24_blue_minimize;
            this.picMini.Location = new System.Drawing.Point(240, 5);
            this.picMini.Name = "picMini";
            this.picMini.Size = new System.Drawing.Size(24, 24);
            this.picMini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picMini.TabIndex = 1;
            this.picMini.TabStop = false;
            // 
            // picClose
            // 
            this.picClose.Image = global::GUI.Properties.Resources._24_blue_close;
            this.picClose.Location = new System.Drawing.Point(270, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(24, 24);
            this.picClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picClose.TabIndex = 0;
            this.picClose.TabStop = false;
            // 
            // lblTextChatUserName
            // 
            this.lblTextChatUserName.AllowDrop = true;
            this.lblTextChatUserName.AutoEllipsis = true;
            this.lblTextChatUserName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTextChatUserName.Location = new System.Drawing.Point(40, 1);
            this.lblTextChatUserName.Name = "lblTextChatUserName";
            this.lblTextChatUserName.Size = new System.Drawing.Size(160, 38);
            this.lblTextChatUserName.TabIndex = 4;
            this.lblTextChatUserName.Text = "Nguyễn Đắc Cường";
            this.lblTextChatUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlOption
            // 
            this.pnlOption.Controls.Add(this.pictureBox3);
            this.pnlOption.Controls.Add(this.picGotoChatUser);
            this.pnlOption.Location = new System.Drawing.Point(0, 0);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(220, 40);
            this.pnlOption.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::GUI.Properties.Resources._24_blue_arow;
            this.pictureBox3.Location = new System.Drawing.Point(200, 13);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pnlChatBar
            // 
            this.pnlChatBar.Controls.Add(this.panel2);
            this.pnlChatBar.Controls.Add(this.pictureBox4);
            this.pnlChatBar.Controls.Add(this.picLike);
            this.pnlChatBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlChatBar.Location = new System.Drawing.Point(0, 360);
            this.pnlChatBar.Name = "pnlChatBar";
            this.pnlChatBar.Size = new System.Drawing.Size(300, 40);
            this.pnlChatBar.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.customeInpputTextBox1);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 40);
            this.panel2.TabIndex = 6;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::GUI.Properties.Resources._24_blue_image;
            this.pictureBox6.Location = new System.Drawing.Point(34, 8);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(24, 24);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox6.TabIndex = 3;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GUI.Properties.Resources._24_blue_add;
            this.pictureBox5.Location = new System.Drawing.Point(4, 8);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox5.TabIndex = 2;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GUI.Properties.Resources._24_blue_face_smile;
            this.pictureBox1.Location = new System.Drawing.Point(64, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::GUI.Properties.Resources._24_blue_like;
            this.pictureBox2.Location = new System.Drawing.Point(270, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(24, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GUI.Properties.Resources._24_blue_face_smile;
            this.pictureBox4.Location = new System.Drawing.Point(59, 8);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // picLike
            // 
            this.picLike.Image = global::GUI.Properties.Resources._24_blue_like;
            this.picLike.Location = new System.Drawing.Point(270, 8);
            this.picLike.Name = "picLike";
            this.picLike.Size = new System.Drawing.Size(24, 24);
            this.picLike.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picLike.TabIndex = 0;
            this.picLike.TabStop = false;
            // 
            // customeInpputTextBox1
            // 
            this.customeInpputTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.customeInpputTextBox1.BorderRadius = 16;
            this.customeInpputTextBox1.BorderSize = 2;
            this.customeInpputTextBox1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.customeInpputTextBox1.Location = new System.Drawing.Point(94, 4);
            this.customeInpputTextBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.customeInpputTextBox1.Multiline = true;
            this.customeInpputTextBox1.Name = "customeInpputTextBox1";
            this.customeInpputTextBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.customeInpputTextBox1.PasswordChar = false;
            this.customeInpputTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customeInpputTextBox1.PlaceholderText = "Aa";
            this.customeInpputTextBox1.Size = new System.Drawing.Size(170, 32);
            this.customeInpputTextBox1.TabIndex = 4;
            this.customeInpputTextBox1.Texts = "Nguyen Dac Cuong";
            this.customeInpputTextBox1.UnderlinedStyle = false;
            // 
            // picGotoChatUser
            // 
            this.picGotoChatUser.Image = global::GUI.Properties.Resources.avatar;
            this.picGotoChatUser.Location = new System.Drawing.Point(4, 4);
            this.picGotoChatUser.Name = "picGotoChatUser";
            this.picGotoChatUser.Size = new System.Drawing.Size(32, 32);
            this.picGotoChatUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGotoChatUser.TabIndex = 2;
            this.picGotoChatUser.TabStop = false;
            // 
            // MiniChatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlChatBar);
            this.Controls.Add(this.panel1);
            this.Name = "MiniChatForm";
            this.Size = new System.Drawing.Size(300, 400);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            this.pnlOption.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnlChatBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLike)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGotoChatUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.PictureBox picMini;
        private System.Windows.Forms.Panel panel1;
        private CustomePicture picGotoChatUser;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Label lblTextChatUserName;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlChatBar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox picLike;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Components.CustomeInpputTextBox customeInpputTextBox1;
    }
}
