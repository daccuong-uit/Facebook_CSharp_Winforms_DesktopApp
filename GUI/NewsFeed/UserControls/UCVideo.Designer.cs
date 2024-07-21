namespace GUI.NewsFeed.UserControls
{
    partial class UCVideo
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.flpButton = new System.Windows.Forms.FlowLayoutPanel();
            this.lblIntro = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.btnHome = new GUI.Components.CustomButton();
            this.btnSavedVideo = new GUI.Components.CustomButton();
            this.pnlMenu.SuspendLayout();
            this.flpButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.pnlMenu.Controls.Add(this.flpButton);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(310, 630);
            this.pnlMenu.TabIndex = 3;
            // 
            // flpButton
            // 
            this.flpButton.BackColor = System.Drawing.Color.White;
            this.flpButton.Controls.Add(this.lblIntro);
            this.flpButton.Controls.Add(this.label1);
            this.flpButton.Controls.Add(this.label8);
            this.flpButton.Controls.Add(this.btnHome);
            this.flpButton.Controls.Add(this.btnSavedVideo);
            this.flpButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpButton.Location = new System.Drawing.Point(0, 0);
            this.flpButton.Name = "flpButton";
            this.flpButton.Size = new System.Drawing.Size(310, 630);
            this.flpButton.TabIndex = 39;
            // 
            // lblIntro
            // 
            this.lblIntro.AutoSize = true;
            this.lblIntro.BackColor = System.Drawing.Color.Transparent;
            this.lblIntro.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblIntro.ForeColor = System.Drawing.Color.Black;
            this.lblIntro.Location = new System.Drawing.Point(3, 0);
            this.lblIntro.Name = "lblIntro";
            this.lblIntro.Size = new System.Drawing.Size(70, 25);
            this.lblIntro.TabIndex = 40;
            this.lblIntro.Text = "Video";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(79, 0);
            this.label1.MaximumSize = new System.Drawing.Size(623, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "                                                        ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(3, 25);
            this.label8.MaximumSize = new System.Drawing.Size(623, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(175, 13);
            this.label8.TabIndex = 50;
            this.label8.Text = "                                                        ";
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.BackColor = System.Drawing.Color.Transparent;
            this.flpContent.Location = new System.Drawing.Point(390, 0);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(815, 630);
            this.flpContent.TabIndex = 4;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderColor = System.Drawing.Color.Transparent;
            this.btnHome.BorderRadius = 12;
            this.btnHome.BorderSize = 0;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnHome.ForeColor = System.Drawing.Color.Black;
            this.btnHome.Image = global::GUI.Properties.Resources._32_blue_film;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(3, 41);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(304, 40);
            this.btnHome.TabIndex = 38;
            this.btnHome.Text = "         Home";
            this.btnHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.TextColor = System.Drawing.Color.Black;
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // btnSavedVideo
            // 
            this.btnSavedVideo.BackColor = System.Drawing.Color.Transparent;
            this.btnSavedVideo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnSavedVideo.BorderColor = System.Drawing.Color.Transparent;
            this.btnSavedVideo.BorderRadius = 12;
            this.btnSavedVideo.BorderSize = 0;
            this.btnSavedVideo.FlatAppearance.BorderSize = 0;
            this.btnSavedVideo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSavedVideo.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSavedVideo.ForeColor = System.Drawing.Color.Black;
            this.btnSavedVideo.Image = global::GUI.Properties.Resources._32_pink_save;
            this.btnSavedVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavedVideo.Location = new System.Drawing.Point(3, 87);
            this.btnSavedVideo.Name = "btnSavedVideo";
            this.btnSavedVideo.Size = new System.Drawing.Size(304, 40);
            this.btnSavedVideo.TabIndex = 39;
            this.btnSavedVideo.Text = "         Video đã lưu";
            this.btnSavedVideo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSavedVideo.TextColor = System.Drawing.Color.Black;
            this.btnSavedVideo.UseVisualStyleBackColor = false;
            // 
            // UCVideo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(247)))), ((int)(((byte)(248)))));
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.pnlMenu);
            this.Name = "UCVideo";
            this.Size = new System.Drawing.Size(1280, 630);
            this.pnlMenu.ResumeLayout(false);
            this.flpButton.ResumeLayout(false);
            this.flpButton.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.FlowLayoutPanel flpButton;
        private Components.CustomButton btnHome;
        private Components.CustomButton btnSavedVideo;
        private System.Windows.Forms.Label lblIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}
