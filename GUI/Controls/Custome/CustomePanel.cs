using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.Controls.Custome
{
    public partial class CustomePanel : UserControl
    {
        private int borderRadius = 10;
        private Color borderColor = Color.LightGray;

        public CustomePanel()
        {
            InitializeComponent();
            Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
            Resize += CustomePanel_Resize;
        }
        private void CustomePanel_Resize(object sender, EventArgs e)
        {
            Invalidate(); // Yêu cầu vẽ lại toàn bộ nội dung khi kích thước thay đổi
        }

        [Category("Appearance")]
        [Description("The radius of the border.")]
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate(); // Vẽ lại khi giá trị thay đổi
            }
        }

        [Category("Appearance")]
        [Description("The color of the border.")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate(); // Vẽ lại khi giá trị thay đổi
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen borderPen = new Pen(borderColor))
            {
                Rectangle rect = new Rectangle(0, 0, Width - 2, Height - 2);

                // Vẽ hình chữ nhật với góc cong
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.DrawArc(borderPen, rect.X, rect.Y, borderRadius * 2, borderRadius * 2, 180, 90);
                e.Graphics.DrawArc(borderPen, rect.Width - borderRadius * 2, rect.Y, borderRadius * 2, borderRadius * 2, 270, 90);
                e.Graphics.DrawArc(borderPen, rect.Width - borderRadius * 2, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 0, 90);
                e.Graphics.DrawArc(borderPen, rect.X, rect.Height - borderRadius * 2, borderRadius * 2, borderRadius * 2, 90, 90);
                e.Graphics.DrawLine(borderPen, rect.X + borderRadius, rect.Y, rect.Width - borderRadius, rect.Y);
                e.Graphics.DrawLine(borderPen, rect.Width, rect.Y + borderRadius, rect.Width, rect.Height - borderRadius);
                e.Graphics.DrawLine(borderPen, rect.Width - borderRadius, rect.Height, rect.X + borderRadius, rect.Height);
                e.Graphics.DrawLine(borderPen, rect.X, rect.Height - borderRadius, rect.X, rect.Y + borderRadius);
            }
        }
    }
}