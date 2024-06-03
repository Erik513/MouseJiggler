using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class MainForm : Form
    {
        //private Settings settingsForm;
        ////timer
        //private const int INPUT_MOUSE = 0;
        //private const int MOUSEEVENTF_MOVE = 0x0001;
        //private bool isJiggling = false;
        //private bool moveRight = true;
        //private int distance = 5; // Move 5 pixel
        //public Timer timerMouseJiggler;
        //[DllImport("user32.dll", SetLastError = true)]
        //private static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        //[StructLayout(LayoutKind.Sequential)]
        //public struct INPUT
        //{
        //    public int type;
        //    public MOUSEINPUT mi;
        //}

        //[StructLayout(LayoutKind.Sequential)]
        //public struct MOUSEINPUT
        //{
        //    public int dx;
        //    public int dy;
        //    public uint mouseData;
        //    public uint dwFlags;
        //    public uint time;
        //    public IntPtr dwExtraInfo;
        //}

        ////-------------------------------------------------------------------------------------------------------------------------------
        //public MainForm()
        //{
        //    InitializeComponent();
        //    CenterToScreen();
        //    DraggableControl draggablePanel = new DraggableControl(dragPanel);
        //    btnStartStop.BackColor = Color.Red;
        //    timerMouseJiggler = new Timer();
        //    timerMouseJiggler.Tick += TimerMouseJiggler_Tick;
        //    timerMouseJiggler.Interval = 60000; // Default interval
        //}

        //private void OpenSettingsForm(object sender, EventArgs e)
        //{
        //    if (settingsForm == null || settingsForm.IsDisposed)
        //    {
        //        settingsForm = new Settings(this);
        //        settingsForm.FormClosed += SettingsForm_FormClosed;
        //        settingsForm.Show();
        //    }
        //    else
        //    {
        //        settingsForm.Activate();
        //    }
        //}
        //private void SettingsForm_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    settingsForm = null;
        //}
        //private void MinimizeWindow(object sender, EventArgs e)
        //{
        //    this.ShowInTaskbar = true;
        //    this.WindowState = FormWindowState.Minimized;
        //}
        //private void FensterSchließen(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        ////_________________________________________________________________________________________________________________________________



        //private void btnStartStop_Click(object sender, EventArgs e)
        //{
        //    StartStopTimerMouseJiggler();
        //}

        //public void StartStopTimerMouseJiggler()
        //{
        //    if (isJiggling)
        //    {
        //        timerMouseJiggler.Stop();
        //        btnStartStop.BackColor = Color.Red;
        //    }
        //    else
        //    {
        //        timerMouseJiggler.Start();
        //        btnStartStop.BackColor = Color.Green;
        //    }
        //    isJiggling = !isJiggling;
        //}

        //private void TimerMouseJiggler_Tick(object sender, EventArgs e)
        //{
        //    int deltaX = moveRight ? distance : -distance;
        //    MoveMouse(deltaX, 0);
        //    moveRight = !moveRight;
        //}
        //public void SetTimerInterval(int interval)
        //{
        //    timerMouseJiggler.Interval = interval;
        //}

        //public int GetTimerInterval()
        //{
        //    return timerMouseJiggler.Interval;
        //}

        //private void MoveMouse(int deltaX, int deltaY)
        //{
        //    INPUT[] input = new INPUT[1];
        //    input[0].type = INPUT_MOUSE;
        //    input[0].mi.dx = deltaX;
        //    input[0].mi.dy = deltaY;
        //    input[0].mi.dwFlags = MOUSEEVENTF_MOVE;
        //    SendInput(1, input, Marshal.SizeOf(typeof(INPUT)));
        //}

        public MouseJiggler timerMouseJiggler;
        private Settings settingsForm;

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            DraggableControl draggablePanel = new DraggableControl(dragPanel);
            btnStartStop.BackColor = Color.Red;

            timerMouseJiggler = new MouseJiggler();
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

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            StartStopMouseJiggler();
        }

        public void StartStopMouseJiggler()
        {
            timerMouseJiggler.StartStop();
            UpdateStartStopButtonColor();
        }
        public void StartMouseJiggler()
        {
            timerMouseJiggler.Start();
            btnStartStop.Enabled = true;
            UpdateStartStopButtonColor();
        }
        public void StopMouseJiggler()
        {
            timerMouseJiggler.Stop();
            btnStartStop.Enabled = false;
            UpdateStartStopButtonColor();
        }
        public bool IsJiggling => timerMouseJiggler.IsJiggling;
        public void UpdateStartStopButtonColor()
        {
            btnStartStop.BackColor = timerMouseJiggler.IsJiggling ? Color.Green : Color.Red;
        }

        public void SetTimerInterval(int interval)
        {
            timerMouseJiggler.SetTimerInterval(interval);
        }

        public int GetTimerInterval()
        {
            return timerMouseJiggler.GetTimerInterval();
        }

    }
}