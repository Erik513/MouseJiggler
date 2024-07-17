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
        private Settings settingsForm;

        public MouseJiggler timerMouseJiggler = null;
        private const int HOTKEY_ID_MOUSEJIGGLER = 1;

        public MouseAutoClicker mouseAutoClicker = null;
        private const int HOTKEY_ID_MOUSEAUTOCLICKER = 2;
        private bool isMouseAutoClickerRunning = false;


        public ColorAutoClicker colorAutoClicker = null;
        private const int HOTKEY_ID_COLORAUTOCLICKER = 3;
        private bool isColorAutoClickerRunning = false;

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
            mouseAutoClicker = new MouseAutoClicker();
            colorAutoClicker = new ColorAutoClicker();

            RegisterHotKey(this.Handle, HOTKEY_ID_MOUSEJIGGLER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.J);
            RegisterHotKey(this.Handle, HOTKEY_ID_MOUSEAUTOCLICKER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.K);
            //Hotkey Für ColorAutoClicker festlegen
            //RegisterHotKey(this.Handle, HOTKEY_ID_COLORAUTOCLICKER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.L);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                if (id == HOTKEY_ID_MOUSEJIGGLER)
                {
                    if (!isMouseAutoClickerRunning) StartStopMouseJiggler();
                }
                else if (id == HOTKEY_ID_MOUSEAUTOCLICKER)
                {
                    if (settingsForm != null && !IsJiggling) StartStopMouseAutoClicker();
                }
            }

            base.WndProc(ref m);
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_MOUSEJIGGLER);
            UnregisterHotKey(this.Handle, HOTKEY_ID_MOUSEAUTOCLICKER);
            //UnregisterHotKey(this.Handle, HOTKEY_ID_COLORAUTOCLICKER);
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

        private void StartStopMouseAutoClicker()
        {
            BtnStartStop_Enabled();
            if (isMouseAutoClickerRunning)
            {
                mouseAutoClicker.Stop();
                isMouseAutoClickerRunning = false;
            }
            else
            {
                timerMouseJiggler.ForceStop();
                UpdateStartStopButtonColor();
                mouseAutoClicker.Start();
                isMouseAutoClickerRunning = true;
            }
            if (settingsForm != null)
            {
                settingsForm.UpdateAutoclickerButtonColor();
                settingsForm.UpdateSettingsOnIsAutoclickerRunning_Enabled();
            }

        }
        public bool IsMouseAutoClickerRunning => isMouseAutoClickerRunning;
        public void StartStopMouseJiggler()
        {
            timerMouseJiggler.StartStop();
            UpdateStartStopButtonColor();
            if (settingsForm != null) settingsForm.UpdateSettingsOnIsJiggling_Enabled();
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
        private void BtnStartStop_Enabled()
        {
            btnStartStop.Enabled = IsMouseAutoClickerRunning ? false : true;
        }

        public void SetMouseJigglerrInterval(int interval)
        {
            timerMouseJiggler.SetTimerInterval(interval);
        }
        public int GetMouseJigglerInterval()
        {
            return timerMouseJiggler.GetMouseJigglerInterval();
        }
        public void SetAutoclickerInterval(int interval)
        {
            mouseAutoClicker.SetClickInterval(interval);
        }
        public int GetAutoclickerInterval()
        {
            return mouseAutoClicker.GetAutoclickerInterval();
        }

    }
}