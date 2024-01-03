using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class MainForm : Form
    {
        private bool isDragging;
        private Point lastLocation;
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_MAXIMIZE = 3;

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            isDragging = true;
            lastLocation = e.Location;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.Location.X - lastLocation.X;
                int deltaY = e.Location.Y - lastLocation.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
            if (this.Top <= Screen.PrimaryScreen.WorkingArea.Top)
            {
                ShowWindow(this.Handle, SW_MAXIMIZE);
            }
        }
        private void WindowMinimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void FensterSchließen(object sender, EventArgs e)
        {
            this.Close();
        }

        //_________________________________________________________________________________________________________________________________

        [DllImport("user32.dll", SetLastError = true)]
        private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public int type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }
        private const int INPUT_MOUSE = 0;
        private const int MOUSEEVENTF_MOVE = 0x0001;

        private bool isJiggling = false;
        private bool moveRight = true;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timerMouseJiggler.Interval = 60000;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (isJiggling)
            {
                timerMouseJiggler.Stop();
                btnStartStop.BackColor = Color.Red;
            }
            else
            {
                timerMouseJiggler.Start();
                btnStartStop.BackColor = Color.Green;
            }
            isJiggling = !isJiggling;
        }

        private void timerMouseJiggler_Tick(object sender, EventArgs e)
        {
            int deltaX = moveRight ? 5 : -5;
            MoveMouse(deltaX, 0);
            moveRight = !moveRight;
        }

        private void MoveMouse(int deltaX, int deltaY)
        {
            INPUT[] input = new INPUT[1];
            input[0].type = INPUT_MOUSE;
            input[0].mi.dx = deltaX;
            input[0].mi.dy = deltaY;
            input[0].mi.dwFlags = MOUSEEVENTF_MOVE;
            SendInput(1, input, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}