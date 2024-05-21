using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class MainForm : Form
    {
        private Settings settingsForm;
        private bool showInTaskbar;
        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            DraggableControl draggablePanel = new DraggableControl(dragPanel);
        }
        private void OpenSettingsForm(object sender, EventArgs e)
        {
            if (settingsForm == null || settingsForm.IsDisposed)
            {
                settingsForm = new Settings(this);
                settingsForm.FormClosed += SettingsForm_FormClosed;
                settingsForm.Show();
            }
            else
            {
                settingsForm.Activate();
            }
        }
        private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            settingsForm = null;
        }
        private void MinimizeWindow(object sender, EventArgs e)
        {
            this.ShowInTaskbar = true;
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