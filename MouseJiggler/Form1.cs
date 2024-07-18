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
        private CustomCheckBox CustomCheckBox;
        private const int HOTKEY_ID_MOUSEJIGGLER = 1;
        private const int HOTKEY_ID_MOUSEAUTOCLICKER = 2;
        private const int HOTKEY_ID_COLORAUTOCLICKER = 3;

        public MouseJiggler timerMouseJiggler = null;
        public MouseAutoClicker mouseAutoClicker = null;
        public ColorAutoClicker colorAutoClicker = null;

        private bool isMouseAutoClickerRunning = false;
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
            InitializeComponents();
            RegisterHotKeys();
        }

        private void InitializeComponents()
        {
            DraggableControl draggablePanel = new DraggableControl(dragPanel);
            btnStartStop.BackColor = Color.Red;

            timerMouseJiggler = new MouseJiggler();
            mouseAutoClicker = new MouseAutoClicker();
            colorAutoClicker = new ColorAutoClicker(UpdateColorStatusButton);
        }

        private void RegisterHotKeys()
        {
            RegisterHotKey(this.Handle, HOTKEY_ID_MOUSEJIGGLER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.J);
            RegisterHotKey(this.Handle, HOTKEY_ID_MOUSEAUTOCLICKER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.K);
            RegisterHotKey(this.Handle, HOTKEY_ID_COLORAUTOCLICKER, (uint)KeyModifiers.Ctrl | (uint)KeyModifiers.Shift, (uint)Keys.L);
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_HOTKEY = 0x0312;

            if (m.Msg == WM_HOTKEY)
            {
                int id = m.WParam.ToInt32();
                HandleHotKey(id);
            }

            base.WndProc(ref m);
        }

        private void HandleHotKey(int id)
        {
            if (id == HOTKEY_ID_MOUSEJIGGLER)
            {
                if (!isMouseAutoClickerRunning && !isColorAutoClickerRunning)
                    StartStopMouseJiggler();
            }
            else if (id == HOTKEY_ID_MOUSEAUTOCLICKER)
            {
                if (settingsForm != null && !IsJiggling && !isColorAutoClickerRunning)
                    StartStopMouseAutoClicker();
            }
            else if (id == HOTKEY_ID_COLORAUTOCLICKER)
            {
                if (settingsForm != null && !IsJiggling && !isMouseAutoClickerRunning)
                    StartStopColorAutoClicker();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID_MOUSEJIGGLER);
            UnregisterHotKey(this.Handle, HOTKEY_ID_MOUSEAUTOCLICKER);
            UnregisterHotKey(this.Handle, HOTKEY_ID_COLORAUTOCLICKER);

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

        //MouseJiggler
        private void StartStopMouseJiggler()
        {
            timerMouseJiggler.StartStop();
            UpdateStartStopButtonColor();
            settingsForm?.UpdateSettingsOnIsJiggling_Enabled();
        }
        public bool IsJiggling => timerMouseJiggler.IsJiggling;
        public void UpdateStartStopButtonColor()
        {
            btnStartStop.BackColor = timerMouseJiggler.IsJiggling ? Color.Green : Color.Red;
        }
        private void BtnStartStop_Enabled()
        {
            btnStartStop.Enabled = !IsMouseAutoClickerRunning && !IsColorAutoClickerRunning;
        }

        public void SetMouseJigglerInterval(int interval)
        {
            timerMouseJiggler.SetTimerInterval(interval);
        }
        public int GetMouseJigglerInterval()
        {
            return timerMouseJiggler.GetMouseJigglerInterval();
        }
        //MouseAutoClicker
        private void StartStopMouseAutoClicker()
        {
            if (isMouseAutoClickerRunning)
            {
                mouseAutoClicker.Stop();
                isMouseAutoClickerRunning = false;
            }
            else
            {
                if (IsJiggling) StartStopMouseJiggler();
                mouseAutoClicker.Start();
                isMouseAutoClickerRunning = true;
            }
            BtnStartStop_Enabled();
            settingsForm?.UpdateMouseAutoClickerButtonColor();
            settingsForm?.UpdateSettingsOnIsAutoClickerRunning_Enabled();
        }
        public bool IsMouseAutoClickerRunning => isMouseAutoClickerRunning;
        
        public void SetAutoclickerInterval(int interval)
        {
            mouseAutoClicker.SetClickInterval(interval);
        }
        public int GetAutoclickerInterval()
        {
            return mouseAutoClicker.GetAutoclickerInterval();
        }
        //ColorAutoClicker
        private void StartStopColorAutoClicker()
        {
            if (isColorAutoClickerRunning)
            {
                colorAutoClicker.Stop();
                isColorAutoClickerRunning = false;
            }
            else
            {
                if (IsJiggling) StartStopMouseJiggler();
                colorAutoClicker.Start();
                isColorAutoClickerRunning = true;
            }
            BtnStartStop_Enabled();
            settingsForm?.UpdateColorAutoClickerButtonColor();
            settingsForm?.UpdateSettingsOnIsColorAutoClickerRunning_Enabled();
        }
        public bool IsColorAutoClickerRunning => colorAutoClicker.IsColorAutoClickerRunning;

        public void SetColorAutoClickerTargetColor(Color color)
        {
            colorAutoClicker.SetTargetColor(color);
        }
        private void UpdateColorStatusButton(Color targetColor, bool isMouseOverTargetColor)
        {
            settingsForm?.UpdateColorStatusButton(targetColor, isMouseOverTargetColor);
        }
    }
}