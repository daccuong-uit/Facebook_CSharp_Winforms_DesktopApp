namespace GUI.Controls.Custome
{
    partial class CustomeSearchingBox
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
            this.customeTextBox1 = new GUI.Components.CustomeTextBox();
            this.SuspendLayout();
            // 
            // customeTextBox1
            // 
            this.customeTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.customeTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.customeTextBox1.BorderColor = System.Drawing.Color.Transparent;
            this.customeTextBox1.BorderFocusColor = System.Drawing.Color.Transparent;
            this.customeTextBox1.BorderRadius = 25;
            this.customeTextBox1.BorderSize = 2;
            this.customeTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.customeTextBox1.Location = new System.Drawing.Point(0, 0);
            this.customeTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.customeTextBox1.Multiline = false;
            this.customeTextBox1.Name = "customeTextBox1";
            this.customeTextBox1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 7);
            this.customeTextBox1.PasswordChar = false;
            this.customeTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.customeTextBox1.PlaceholderText = "";
            this.customeTextBox1.Size = new System.Drawing.Size(400, 50);
            this.customeTextBox1.TabIndex = 0;
            this.customeTextBox1.Texts = "";
            this.customeTextBox1.UnderlinedStyle = false;
            // 
            // CustomeSearchingBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.customeTextBox1);
            this.Name = "CustomeSearchingBox";
            this.Size = new System.Drawing.Size(400, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Components.CustomeTextBox customeTextBox1;
    }
}
