using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class DraggableControl : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        private const int SW_MAXIMIZE = 3;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public Control TargetControl { get; private set; }
        public DraggableControl(Control control)
        {
            TargetControl = control;
            TargetControl.MouseMove += Control_MouseMove;
        }
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(TargetControl.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                CenterToScreenIfControlIsUnderTaskbar();
            }
        }
        private void CenterToScreenIfControlIsUnderTaskbar()
        {
            // Überprüfen, ob die PanelLeiste teilweise außerhalb des sichtbaren Bildschirmbereichs liegt (unter der Taskleiste z.B.)
            int taskBarHeight = Screen.PrimaryScreen.Bounds.Height - Screen.PrimaryScreen.WorkingArea.Height;
            int visibleAreaTop = Screen.PrimaryScreen.WorkingArea.Top + taskBarHeight;
            int panelTopRelativeToScreen = TargetControl.FindForm().Top + 20;

            if (panelTopRelativeToScreen > Screen.PrimaryScreen.Bounds.Height - visibleAreaTop)
            {
                int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
                int centerY = Screen.PrimaryScreen.Bounds.Height / 2;
                TargetControl.FindForm().Location = new Point(centerX - TargetControl.FindForm().Width / 2, centerY - TargetControl.FindForm().Height / 2);
            }
        }
    }
}
