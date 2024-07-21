namespace GUI.Controls
{
    partial class WindowControls
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
            this.ptbClose = new System.Windows.Forms.PictureBox();
            this.ptbMaximize = new System.Windows.Forms.PictureBox();
            this.ptbMinimize = new System.Windows.Forms.PictureBox();
            this.pnlClose = new System.Windows.Forms.Panel();
            this.pnlMaximize = new System.Windows.Forms.Panel();
            this.pnlMinimize = new System.Windows.Forms.Panel();
            this.lblLastMessContact = new System.Windows.Forms.Label();
            this.btnOptional = new GUI.Components.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).BeginInit();
            this.pnlClose.SuspendLayout();
            this.pnlMaximize.SuspendLayout();
            this.pnlMinimize.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbClose
            // 
            this.ptbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbClose.Image = global::GUI.Properties.Resources._24_white_close;
            this.ptbClose.Location = new System.Drawing.Point(19, 14);
            this.ptbClose.Name = "ptbClose";
            this.ptbClose.Size = new System.Drawing.Size(12, 12);
            this.ptbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbClose.TabIndex = 0;
            this.ptbClose.TabStop = false;
            this.ptbClose.Click += new System.EventHandler(this.ptbClose_Click);
            this.ptbClose.MouseEnter += new System.EventHandler(this.ptbClose_MouseEnter);
            this.ptbClose.MouseLeave += new System.EventHandler(this.ptbClose_MouseLeave);
            // 
            // ptbMaximize
            // 
            this.ptbMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMaximize.Image = global::GUI.Properties.Resources._24_white_square;
            this.ptbMaximize.Location = new System.Drawing.Point(17, 12);
            this.ptbMaximize.Name = "ptbMaximize";
            this.ptbMaximize.Size = new System.Drawing.Size(16, 16);
            this.ptbMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMaximize.TabIndex = 1;
            this.ptbMaximize.TabStop = false;
            this.ptbMaximize.Click += new System.EventHandler(this.ptbMaximize_Click);
            this.ptbMaximize.MouseEnter += new System.EventHandler(this.ptbMaximize_MouseEnter);
            this.ptbMaximize.MouseLeave += new System.EventHandler(this.ptbMaximize_MouseLeave);
            // 
            // ptbMinimize
            // 
            this.ptbMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbMinimize.Image = global::GUI.Properties.Resources._24_white_minimize;
            this.ptbMinimize.Location = new System.Drawing.Point(17, 12);
            this.ptbMinimize.Name = "ptbMinimize";
            this.ptbMinimize.Size = new System.Drawing.Size(16, 16);
            this.ptbMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ptbMinimize.TabIndex = 2;
            this.ptbMinimize.TabStop = false;
            this.ptbMinimize.Click += new System.EventHandler(this.ptbMinimize_Click);
            this.ptbMinimize.MouseEnter += new System.EventHandler(this.ptbMinimize_MouseEnter);
            this.ptbMinimize.MouseLeave += new System.EventHandler(this.ptbMinimize_MouseLeave);
            // 
            // pnlClose
            // 
            this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlClose.Controls.Add(this.ptbClose);
            this.pnlClose.Location = new System.Drawing.Point(1230, 0);
            this.pnlClose.Name = "pnlClose";
            this.pnlClose.Size = new System.Drawing.Size(50, 40);
            this.pnlClose.TabIndex = 3;
            this.pnlClose.Click += new System.EventHandler(this.pnlClose_Click);
            this.pnlClose.MouseEnter += new System.EventHandler(this.pnlClose_MouseEnter);
            this.pnlClose.MouseLeave += new System.EventHandler(this.pnlClose_MouseLeave);
            // 
            // pnlMaximize
            // 
            this.pnlMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMaximize.Controls.Add(this.ptbMaximize);
            this.pnlMaximize.Location = new System.Drawing.Point(1180, 0);
            this.pnlMaximize.Name = "pnlMaximize";
            this.pnlMaximize.Size = new System.Drawing.Size(50, 40);
            this.pnlMaximize.TabIndex = 4;
            this.pnlMaximize.Click += new System.EventHandler(this.pnlMaximize_Click);
            this.pnlMaximize.MouseEnter += new System.EventHandler(this.pnlMaximize_MouseEnter);
            this.pnlMaximize.MouseLeave += new System.EventHandler(this.pnlMaximize_MouseLeave);
            // 
            // pnlMinimize
            // 
            this.pnlMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMinimize.Controls.Add(this.ptbMinimize);
            this.pnlMinimize.Location = new System.Drawing.Point(1130, 0);
            this.pnlMinimize.Name = "pnlMinimize";
            this.pnlMinimize.Size = new System.Drawing.Size(50, 40);
            this.pnlMinimize.TabIndex = 5;
            this.pnlMinimize.Click += new System.EventHandler(this.pnlMinimize_Click);
            this.pnlMinimize.MouseEnter += new System.EventHandler(this.pnlMinimize_MouseEnter);
            this.pnlMinimize.MouseLeave += new System.EventHandler(this.pnlMinimize_MouseLeave);
            // 
            // lblLastMessContact
            // 
            this.lblLastMessContact.AllowDrop = true;
            this.lblLastMessContact.AutoEllipsis = true;
            this.lblLastMessContact.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblLastMessContact.ForeColor = System.Drawing.Color.White;
            this.lblLastMessContact.Location = new System.Drawing.Point(50, 10);
            this.lblLastMessContact.Name = "lblLastMessContact";
            this.lblLastMessContact.Size = new System.Drawing.Size(103, 20);
            this.lblLastMessContact.TabIndex = 11;
            this.lblLastMessContact.Text = "Facebook";
            // 
            // btnOptional
            // 
            this.btnOptional.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnOptional.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnOptional.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.btnOptional.BorderRadius = 24;
            this.btnOptional.BorderSize = 0;
            this.btnOptional.FlatAppearance.BorderSize = 0;
            this.btnOptional.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOptional.ForeColor = System.Drawing.Color.White;
            this.btnOptional.Image = global::GUI.Properties.Resources._16_black_option;
            this.btnOptional.Location = new System.Drawing.Point(20, 8);
            this.btnOptional.Name = "btnOptional";
            this.btnOptional.Size = new System.Drawing.Size(24, 24);
            this.btnOptional.TabIndex = 23;
            this.btnOptional.TextColor = System.Drawing.Color.White;
            this.btnOptional.UseVisualStyleBackColor = false;
            // 
            // WindowControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.btnOptional);
            this.Controls.Add(this.lblLastMessContact);
            this.Controls.Add(this.pnlMinimize);
            this.Controls.Add(this.pnlMaximize);
            this.Controls.Add(this.pnlClose);
            this.Name = "WindowControls";
            this.Size = new System.Drawing.Size(1280, 40);
            ((System.ComponentModel.ISupportInitialize)(this.ptbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMinimize)).EndInit();
            this.pnlClose.ResumeLayout(false);
            this.pnlMaximize.ResumeLayout(false);
            this.pnlMinimize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbClose;
        private System.Windows.Forms.PictureBox ptbMaximize;
        private System.Windows.Forms.PictureBox ptbMinimize;
        private System.Windows.Forms.Panel pnlClose;
        private System.Windows.Forms.Panel pnlMaximize;
        private System.Windows.Forms.Panel pnlMinimize;
        private System.Windows.Forms.Label lblLastMessContact;
        private Components.CustomButton btnOptional;
    }
}
