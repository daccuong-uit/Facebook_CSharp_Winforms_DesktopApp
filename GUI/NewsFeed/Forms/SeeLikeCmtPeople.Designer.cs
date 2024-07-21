namespace GUI.NewsFeed.Forms
{
    partial class SeeLikeCmtPeople
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.friendInFeed1 = new GUI.NewsFeed.UserControls.Friends.FriendInFeed();
            this.friendInFeed2 = new GUI.NewsFeed.UserControls.Friends.FriendInFeed();
            this.pnlClose.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.BackColor = System.Drawing.Color.Transparent;
            this.pnlClose.Controls.Add(this.ptbClose);
            this.pnlClose.Location = new System.Drawing.Point(490, 5);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(50, 40);
            this.pnlClose.TabIndex = 63;
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.BackColor = System.Drawing.Color.Transparent;
            this.ptbClose.Image = global::GUI.Properties.Resources._24_black_close;
            this.ptbClose.Location = new System.Drawing.Point(19, 15);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(12, 12);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.friendInFeed1);
            this.flowLayoutPanel1.Controls.Add(this.friendInFeed2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(5, 50);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(535, 555);
            this.flowLayoutPanel1.TabIndex = 64;
            // 
            // friendInFeed1
            // 
            this.friendInFeed1.BackColor = System.Drawing.Color.Transparent;
            this.friendInFeed1.Location = new System.Drawing.Point(3, 3);
            this.friendInFeed1.Name = "friendInFeed1";
            this.friendInFeed1.Size = new System.Drawing.Size(510, 50);
            this.friendInFeed1.TabIndex = 0;
            // 
            // friendInFeed2
            // 
            this.friendInFeed2.BackColor = System.Drawing.Color.Transparent;
            this.friendInFeed2.Location = new System.Drawing.Point(3, 59);
            this.friendInFeed2.Name = "friendInFeed2";
            this.friendInFeed2.Size = new System.Drawing.Size(510, 50);
            this.friendInFeed2.TabIndex = 1;
            // 
            // SeeLikeCmtPeople
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(545, 615);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pnlClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SeeLikeCmtPeople";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SeeLikeCmtPeople";
            this.pnlClose.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private UserControls.Friends.FriendInFeed friendInFeed1;
        private UserControls.Friends.FriendInFeed friendInFeed2;
    }
}