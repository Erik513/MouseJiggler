using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Timers;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class MainForm : Form
    {
        public MouseJiggler timerMouseJiggler = null;
        private Settings settingsForm;

        private const int HOTKEY_ID_STARTSTOP = 1;
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        private enum KeyModifiers
        {
            None = 0,
            Alt = 1,
            Ctrl = 2,
            Shift = 4,
            WinKey = 8
        }

        public MainForm()
        {
            InitializeComponent();
            CenterToScreen();
            DraggableControl draggablePanel = new DraggableControl(dragPanel);
            btnStartStop.BackColor = Color.Red;

            timerMouseJiggler = new MouseJiggler();

            RegisterHotKey(this.Handle, HOTKEY_ID_STARTSTOP, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.J);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_STARTSTOP)
                {
                    StartStopMouseJiggler();
                }
            }

            base.WndProc(ref m);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_STARTSTOP);
            base.OnFormClosing(e);
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
            if (timerMouseJiggler != null)
            {
                timerMouseJiggler.Start(); 
                UpdateStartStopButtonColor(); 
            }
        }
        public void StopMouseJiggler()
        {
            if (timerMouseJiggler != null)
            {
                timerMouseJiggler.Stop(); 
                UpdateStartStopButtonColor();
            }
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