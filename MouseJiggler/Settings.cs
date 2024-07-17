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
            //SetButtonColors();
            dragPanel.Dock = DockStyle.Fill;
            DraggableControl draggable_dragPanel = new DraggableControl(dragPanel);
            //General Settings
            DraggableControl draggable_panelGeneralSettings = new DraggableControl(panelGeneralSettings);
            DraggableControl draggable_lblGeneralSettings = new DraggableControl(lblGeneralSettings);
            DraggableControl draggable_cbTopMost = new DraggableControl(cbTopMost);
            DraggableControl draggable_cbShowInTaskbar = new DraggableControl(cbShowInTaskbar);

            cbTopMost.CheckStateChanged += CbTopMost_CheckStateChanged;
            cbTopMost.Checked = topMostState;
            cbShowInTaskbar.CheckStateChanged += CbShowInTaskbar_CheckStateChanged;
            cbShowInTaskbar.Checked = showInTaskbar;
            //MouseJiggler (trackbar nicht)
            DraggableControl draggable_panelMouseJiggler = new DraggableControl(panelMouseJiggler);
            DraggableControl draggable_lblMouseJiggler = new DraggableControl(lblMouseJiggler);
            DraggableControl draggable_lblMouseJigglerDuration = new DraggableControl(lblMouseJigglerDuration);
            DraggableControl draggable_lblHotkeyMouseJiggler = new DraggableControl(lblHotkeyMouseJiggler);
            DraggableControl draggable_btnMouseJiggler = new DraggableControl(btnMouseJiggler);
            //MouseAutoClicker (trackbar nicht)
            DraggableControl draggable_panelMouseAutoClicker = new DraggableControl(panelMouseAutoClicker);
            DraggableControl draggable_lblMouseAutoClicker = new DraggableControl(lblMouseAutoClicker);
            DraggableControl draggable_lblHotkeyMouseAutoClicker = new DraggableControl(lblHotkeyMouseAutoClicker);
            DraggableControl draggable_lblMouseAutoClickerDuration = new DraggableControl(lblMouseAutoClickerDuration);
            DraggableControl draggable_btnMouseAutoClicker = new DraggableControl(btnMouseAutoClicker);
            //ColorAutoClicker (combobox nicht)
            DraggableControl draggable_panelColorAutoClicker = new DraggableControl(panelColorAutoClicker);
            DraggableControl draggable_lblColorAutoClicker = new DraggableControl(lblColorAutoClicker);
            DraggableControl draggable_lblHotkeyColorAutoClicker = new DraggableControl(lblHotkeyColorAutoClicker);
            DraggableControl draggable_lblColorFound = new DraggableControl(lblColorFound);
            DraggableControl draggable_btnColorFoundStatus = new DraggableControl(btnColorFoundStatus);
            DraggableControl draggable_btnColorAutoClicker = new DraggableControl(btnColorAutoClicker);
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


        public Settings(MainForm form) : this()
        {
            mainForm = form;
            this.KeyPreview = true;
            //TopMost
            cbTopMost.Checked = form.TopMost;
            topMostState = form.TopMost;
            //ShowInTaskbar
            cbShowInTaskbar.Checked = form.ShowInTaskbar;
            showInTaskbar = form.ShowInTaskbar;
            //TrackbarIntervalMouseJiggler
            trackBarIntervalMouseJiggler.Minimum = 1; // Minimum 0,1 Sekunden
            trackBarIntervalMouseJiggler.Maximum = 600; // Maximum 60 Sekunden
            trackBarIntervalMouseJiggler.TickFrequency = 100;
            trackBarIntervalMouseJiggler.Value = mainForm.GetMouseJigglerInterval() / 100;
            lblMouseJigglerDuration.Text = $"Duration: \nevery {trackBarIntervalMouseJiggler.Value / 10.0} \nSecond(s)";
            //TrackbarIntervalAutoclicker
            trackBarIntervalMouseAutoClicker.Minimum = 1; // 1 Click per Minute
            trackBarIntervalMouseAutoClicker.Maximum = 6000; // 6000 Clicks per Minute
            trackBarIntervalMouseAutoClicker.TickFrequency = 1000;
            trackBarIntervalMouseAutoClicker.Value = mainForm.GetAutoclickerInterval();
            lblMouseAutoClickerDuration.Text = $"Clicks: \n{trackBarIntervalMouseAutoClicker.Value} \n(per Minute)";

            colorAutoClicker = new ColorAutoClicker(UpdateColorStatusButton);
            cboxColor.Items.AddRange(new string[] { "Red", "Yellow", "Green", "Blue", "Pink", "Black", "Gray", "White" });
            cboxColor.SelectedIndex = 0;
            cboxColor.SelectedIndexChanged += CboxColor_SelectedIndexChanged;
            SetButtonColors();
            SetNotVisibleControls();
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
            cbTopMost.Enabled = mainForm.IsJiggling ? false : true;
            cbShowInTaskbar.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalMouseJiggler.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalMouseAutoClicker.Enabled = mainForm.IsJiggling ? false : true;
            pboxWindowClose.Enabled = mainForm.IsJiggling ? false : true;
            btnMouseJiggler.BackColor = mainForm.IsJiggling ? Color.Green : Color.Red;
        }
        /// <summary>
        /// Depending on IsAutoclickerRunning
        /// </summary>
        public void UpdateSettingsOnIsAutoclickerRunning_Enabled()
        {
            cbTopMost.Enabled = mainForm.IsMouseAutoClickerRunning ? false : true;
            cbShowInTaskbar.Enabled = mainForm.IsMouseAutoClickerRunning ? false : true;
            trackBarIntervalMouseJiggler.Enabled = mainForm.IsMouseAutoClickerRunning ? false : true;
            trackBarIntervalMouseAutoClicker.Enabled = mainForm.IsMouseAutoClickerRunning ? false : true;
            pboxWindowClose.Enabled = mainForm.IsMouseAutoClickerRunning ? false : true;
        }
        /// <summary>
        /// Depending on IsJiggling
        /// </summary>
        public void UpdateSettingsOnIsColorAutoClickerRunning_Enabled()
        {
            cbTopMost.Enabled = mainForm.IsJiggling ? false : true;
            cbShowInTaskbar.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalMouseJiggler.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalMouseAutoClicker.Enabled = mainForm.IsJiggling ? false : true;
            pboxWindowClose.Enabled = mainForm.IsColorAutoClickerRunning ? false : true;
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

        private void trackBarInterval_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouseJigglerDuration.Text = $"Duration: \nevery {trackBarIntervalMouseJiggler.Value / 10.0} \nSecond(s)";
        }
        private void trackBarInterval_MouseUp(object sender, MouseEventArgs e)
        {
            int interval = (int)(trackBarIntervalMouseJiggler.Value * 100); // Wert in 100 Millisekunden
            mainForm.SetMouseJigglerrInterval(interval);
        }

        private void trackBarIntervalAutoclicker_MouseMove(object sender, MouseEventArgs e)
        {
            lblMouseAutoClickerDuration.Text = $"Clicks: \n{trackBarIntervalMouseAutoClicker.Value} \n(per Minute)";
        }

        private void trackBarIntervalAutoclicker_MouseUp(object sender, MouseEventArgs e)
        {
            int interval = 6000 / trackBarIntervalMouseAutoClicker.Value;
            mainForm.SetAutoclickerInterval(interval);
        }
    }
}
