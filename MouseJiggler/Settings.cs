using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MouseJiggler
{
    public partial class Settings : Form
    {
        private MainForm mainForm;
        private bool topMostState;
        private bool showInTaskbar;
        private TimeSpan startTime;
        private TimeSpan stopTime;
        private ColorAutoClicker colorAutoClicker;

        private void pboxWindowClose_Click(object sender, EventArgs e)
        {
            Close();
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.Show();
        }

        public Settings()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            SetupDragControls();
            InitializeGeneralSettings();
            InitializeMouseJigglerSettings();
            InitializeMouseAutoClickerSettings();
            InitializeColorAutoClickerSettings();

            cbTopMost.Checked = topMostState;
            cbShowInTaskbar.Checked = showInTaskbar;
        }

        private void SetupDragControls()
        {
            dragPanel.Dock = DockStyle.Fill;
            new DraggableControl(dragPanel);
            //General
            new DraggableControl(panelGeneralSettings);
            new DraggableControl(lblGeneralSettings);
            new DraggableControl(cbTopMost);
            new DraggableControl(cbShowInTaskbar);
            //MouseJiggler (trackbar nicht)
            new DraggableControl(panelMouseJiggler);
            new DraggableControl(lblMouseJiggler);
            new DraggableControl(lblMouseJigglerDuration);
            new DraggableControl(lblHotkeyMouseJiggler);
            new DraggableControl(btnMouseJiggler);
            //MouseAutoClicker (trackbar nicht)
            new DraggableControl(panelMouseAutoClicker);
            new DraggableControl(lblMouseAutoClicker);
            new DraggableControl(lblHotkeyMouseAutoClicker);
            new DraggableControl(lblMouseAutoClickerDuration);
            new DraggableControl(btnMouseAutoClicker);
            //ColorAutoClicker (combobox nicht)
            new DraggableControl(panelColorAutoClicker);
            new DraggableControl(lblColorAutoClicker);
            new DraggableControl(lblHotkeyColorAutoClicker);
            new DraggableControl(lblColorFound);
            new DraggableControl(btnColorFoundStatus);
            new DraggableControl(btnColorAutoClicker);
        }
        private void InitializeGeneralSettings()
        {
            cbTopMost.CheckStateChanged += CbTopMost_CheckStateChanged;
            cbShowInTaskbar.CheckStateChanged += CbShowInTaskbar_CheckStateChanged;
        }
        private void InitializeMouseJigglerSettings()
        {
            trackBarIntervalMouseJiggler.MouseMove += TrackBarInterval_MouseMove;
            trackBarIntervalMouseJiggler.MouseUp += TrackBarInterval_MouseUp;
        }

        private void InitializeMouseAutoClickerSettings()
        {
            trackBarIntervalMouseAutoClicker.MouseMove += TrackBarIntervalAutoclicker_MouseMove;
            trackBarIntervalMouseAutoClicker.MouseUp += TrackBarIntervalAutoclicker_MouseUp;
        }

        private void InitializeColorAutoClickerSettings()
        {
            cboxColor.SelectedIndexChanged += CboxColor_SelectedIndexChanged;
        }
        public Settings(MainForm form) : this()
        {
            mainForm = form;
            this.KeyPreview = true;
            InitializeMainFormSettings();
        }

        private void InitializeMainFormSettings()
        {
            cbTopMost.Checked = mainForm.TopMost;
            topMostState = mainForm.TopMost;

            cbShowInTaskbar.Checked = mainForm.ShowInTaskbar;
            showInTaskbar = mainForm.ShowInTaskbar;

            SetupTrackBars();
            SetupColorAutoClicker();
            SetButtonColors();
            SetNotVisibleControls();
        }

        private void SetupTrackBars()
        {
            trackBarIntervalMouseJiggler.Minimum = 1;
            trackBarIntervalMouseJiggler.Maximum = 600;
            trackBarIntervalMouseJiggler.TickFrequency = 100;
            trackBarIntervalMouseJiggler.Value = mainForm.GetMouseJigglerInterval() / 100;
            lblMouseJigglerDuration.Text = $"Duration: \nevery {trackBarIntervalMouseJiggler.Value / 10.0} \nSecond(s)";

            trackBarIntervalMouseAutoClicker.Minimum = 1;
            trackBarIntervalMouseAutoClicker.Maximum = 6000;
            trackBarIntervalMouseAutoClicker.TickFrequency = 1000;
            trackBarIntervalMouseAutoClicker.Value = mainForm.GetAutoclickerInterval();
            lblMouseAutoClickerDuration.Text = $"Clicks: \n{trackBarIntervalMouseAutoClicker.Value} \n(per Minute)";
        }

        private void SetupColorAutoClicker()
        {
            colorAutoClicker = new ColorAutoClicker(UpdateColorStatusButton);
            cboxColor.Items.AddRange(new string[] { "Red", "Yellow", "Green", "Blue", "Pink", "Black", "Gray", "White" });
            cboxColor.SelectedIndex = 0;
            cboxColor.SelectedIndexChanged += CboxColor_SelectedIndexChanged;
        }
        private void SetButtonColors()
        {
            btnMouseAutoClicker.BackColor = mainForm.IsMouseAutoClickerRunning ? Color.Green : Color.Red;
            btnMouseJiggler.BackColor = mainForm.IsJiggling ? Color.Green : Color.Red;
            btnColorAutoClicker.BackColor = mainForm.IsColorAutoClickerRunning ? Color.Green : Color.Red;
        }
        private void SetNotVisibleControls()
        {
            lblColorFound.Visible = mainForm.IsColorAutoClickerRunning ? true : false;
            btnColorFoundStatus.Visible = mainForm.IsColorAutoClickerRunning ? true : false;
        }

        //UPDATE
        public void UpdateMouseAutoClickerButtonColor()
        {
            btnMouseAutoClicker.BackColor = mainForm.IsMouseAutoClickerRunning ? Color.Green : Color.Red;
        }
        public void UpdateColorAutoClickerButtonColor()
        {
            btnColorAutoClicker.BackColor = mainForm.IsColorAutoClickerRunning ? Color.Green : Color.Red;
            lblColorFound.Visible = mainForm.IsColorAutoClickerRunning ? true : false;
            btnColorFoundStatus.Visible = mainForm.IsColorAutoClickerRunning ? true : false;
        }
        public void UpdateColorStatusButton(Color targetColor, bool isMouseOverTargetColor)
        {
            btnColorFoundStatus.BackColor = isMouseOverTargetColor ? Color.Green : Color.Red;
        }

        /// <summary>
        /// Depending on IsJiggling
        /// </summary>
        public void UpdateSettingsOnIsJiggling_Enabled()
        {
            bool isEnabled = !mainForm.IsJiggling;

            cbTopMost.Enabled = isEnabled;
            cbShowInTaskbar.Enabled = isEnabled;
            trackBarIntervalMouseJiggler.Enabled = isEnabled;
            trackBarIntervalMouseAutoClicker.Enabled = isEnabled;

            btnMouseJiggler.BackColor = mainForm.IsJiggling ? Color.Green : Color.Red;

            cbTopMost.ForeColor = isEnabled ? Color.White : Color.White;
            cbShowInTaskbar.ForeColor = isEnabled ? Color.White : Color.White;
        }
        /// <summary>
        /// Depending on IsAutoclickerRunning
        /// </summary>
        public void UpdateSettingsOnIsAutoClickerRunning_Enabled()
        {
            bool isEnabled = !mainForm.IsMouseAutoClickerRunning;

            cbTopMost.Enabled = isEnabled;
            cbShowInTaskbar.Enabled = isEnabled;
            trackBarIntervalMouseJiggler.Enabled = isEnabled;
            trackBarIntervalMouseAutoClicker.Enabled = isEnabled;
            pboxWindowClose.Enabled = isEnabled;

            cbTopMost.ForeColor = isEnabled ? Color.White : Color.White;
            cbShowInTaskbar.ForeColor = isEnabled ? Color.White : Color.White;
        }
        /// <summary>
        /// Depending on IsColorAutoClickerRunning
        /// </summary>
        public void UpdateSettingsOnIsColorAutoClickerRunning_Enabled()
        {
            bool isEnabled = !mainForm.IsColorAutoClickerRunning;

            cbTopMost.Enabled = isEnabled;
            cbShowInTaskbar.Enabled = isEnabled;
            trackBarIntervalMouseJiggler.Enabled = isEnabled;
            trackBarIntervalMouseAutoClicker.Enabled = isEnabled;
            pboxWindowClose.Enabled = isEnabled;

            cbTopMost.ForeColor = isEnabled ? Color.White : Color.White;
            cbShowInTaskbar.ForeColor = isEnabled ? Color.White : Color.White;
        }

        private void CbTopMost_CheckStateChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.TopMost = cbTopMost.Checked;
                topMostState = cbTopMost.Checked;
                this.TopMost = true;
            }
        }

        private void CbShowInTaskbar_CheckStateChanged(object sender, EventArgs e)
        {
            if (mainForm != null)
            {
                mainForm.ShowInTaskbar = cbShowInTaskbar.Checked;
                showInTaskbar = cbShowInTaskbar.Checked;
                this.TopMost = true;
            }
        }

        private void TrackBarInterval_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouseJigglerDuration.Text = $"Duration: \nevery {trackBarIntervalMouseJiggler.Value / 10.0} \nSecond(s)";
        }

        private void TrackBarInterval_MouseUp(object sender, MouseEventArgs e)
        {
            int interval = (int)(trackBarIntervalMouseJiggler.Value * 100);
            mainForm.SetMouseJigglerInterval(interval);
        }

        private void TrackBarIntervalAutoclicker_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouseAutoClickerDuration.Text = $"Clicks: \n{trackBarIntervalMouseAutoClicker.Value} \n(per Minute)";
        }

        private void TrackBarIntervalAutoclicker_MouseUp(object sender, MouseEventArgs e)
        {
            int interval = 6000 / trackBarIntervalMouseAutoClicker.Value;
            mainForm.SetAutoclickerInterval(interval);
        }

        private void CboxColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedColor = cboxColor.SelectedItem.ToString();
            Color color = Color.FromName(selectedColor);
            if (selectedColor != null)
            {
                mainForm.SetColorAutoClickerTargetColor(color);
            }
        }
    }
}
