using GUI.Controls;
using System.Windows.Forms;
using System;
using System.Drawing;

public class BaseFormLogin : Form
{
    protected WindowControls windowControls;
    private bool isDragging;
    private int mouseX;
    private int mouseY;

    public BaseFormLogin()
    {
        windowControls = new WindowControls();
        windowControls.Dock = DockStyle.Top;
        this.Controls.Add(windowControls);
        this.StartPosition = FormStartPosition.CenterScreen;
        windowControls.Anchor = AnchorStyles.Top | AnchorStyles.Left;

        windowControls.MouseDown += WindowControls_MouseDown;
        windowControls.MouseMove += WindowControls_MouseMove;
        windowControls.MouseUp += WindowControls_MouseUp;

        windowControls.CloseClicked += CloseClicked;
        windowControls.MaximizeClicked += MaximizeClicked;
        windowControls.MinimizeClicked += MinimizeClicked;
    }

    protected virtual void CloseClicked(object sender, EventArgs e)
    {
        // Xử lý sự kiện đóng chương trình
        Application.Exit();
    }

    protected virtual void MaximizeClicked(object sender, EventArgs e)
    {
        // Xử lý sự kiện phóng to/thu nhỏ cửa sổ
        if (WindowState == FormWindowState.Normal)
        {
            WindowState = FormWindowState.Maximized;
        }
        else
        {
            WindowState = FormWindowState.Normal;
        }
    }

    protected virtual void MinimizeClicked(object sender, EventArgs e)
    {
        // Xử lý sự kiện thu nhỏ cửa sổ
        WindowState = FormWindowState.Minimized;
    }

    private void WindowControls_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
        {
            isDragging = true;
            mouseX = e.X;
            mouseY = e.Y;
        }
    }

    private void WindowControls_MouseMove(object sender, MouseEventArgs e)
    {
        if (isDragging)
        {
            this.Left += e.X - mouseX;
            this.Top += e.Y - mouseY;
        }
    }

    private void WindowControls_MouseUp(object sender, MouseEventArgs e)
    {
        isDragging = false;
    }
}