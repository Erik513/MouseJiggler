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
            dragPanel.Dock = DockStyle.Fill;
            DraggableControl draggableDragPanel = new DraggableControl(dragPanel);
            DraggableControl draggableLblHotkeyMouseJiggler = new DraggableControl(lblHotkeyMouseJiggler);
            DraggableControl draggableBtnAutoclicker = new DraggableControl(btnAutoclicker);
            DraggableControl draggableLblHotkeyAutoclicker = new DraggableControl(lblHotkeyAutoclicker);
            DraggableControl draggableLblDuration = new DraggableControl(lblMouseJigglerDuration);
            DraggableControl draggableCbTopMost = new DraggableControl(cbTopMost);
            DraggableControl draggableCbShowInTaskbar = new DraggableControl(cbShowInTaskbar);

            cbTopMost.CheckStateChanged += CbTopMost_CheckStateChanged;
            cbTopMost.Checked = topMostState;
            cbShowInTaskbar.CheckStateChanged += CbShowInTaskbar_CheckStateChanged;
            cbShowInTaskbar.Checked = showInTaskbar;
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
            trackBarIntervalAutoclicker.Minimum = 1; // 1 Click per Minute
            trackBarIntervalAutoclicker.Maximum = 6000; // 6000 Clicks per Minute
            trackBarIntervalAutoclicker.TickFrequency = 1000;
            trackBarIntervalAutoclicker.Value = mainForm.GetAutoclickerInterval();
            lblAutoclickerDuration.Text = $"Clicks: \n{trackBarIntervalAutoclicker.Value} \n(per Minute)";

            UpdateAutoclickerButtonColor();
        }
        public void UpdateAutoclickerButtonColor()
        {
            btnAutoclicker.BackColor = mainForm.IsAutoclickerRunning ? Color.Green : Color.Red;
        }
        /// <summary>
        /// Depending on IsAutoclickerRunning
        /// </summary>
        public void UpdateSettingsOnIsAutoclickerRunning_Enabled()
        {
            cbTopMost.Enabled = mainForm.IsAutoclickerRunning ? false : true;
            cbShowInTaskbar.Enabled = mainForm.IsAutoclickerRunning ? false : true;
            trackBarIntervalMouseJiggler.Enabled = mainForm.IsAutoclickerRunning ? false : true;
            trackBarIntervalAutoclicker.Enabled = mainForm.IsAutoclickerRunning ? false : true;
            pboxWindowClose.Enabled = mainForm.IsAutoclickerRunning ? false : true;
        }
        /// <summary>
        /// Depending on IsJiggling
        /// </summary>
        public void UpdateSettingsOnIsJiggling_Enabled()
        {
            cbTopMost.Enabled = mainForm.IsJiggling ? false : true;
            cbShowInTaskbar.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalMouseJiggler.Enabled = mainForm.IsJiggling ? false : true;
            trackBarIntervalAutoclicker.Enabled = mainForm.IsJiggling ? false : true;
            pboxWindowClose.Enabled = mainForm.IsJiggling ? false : true;
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
            lblAutoclickerDuration.Text = $"Clicks: \n{trackBarIntervalAutoclicker.Value} \n(per Minute)";
        }

        private void trackBarIntervalAutoclicker_MouseUp(object sender, MouseEventArgs e)
        {
            //int interval = (int)(trackBarIntervalAutoclicker.Value);
            int interval = 6000 / trackBarIntervalAutoclicker.Value;
            mainForm.SetAutoclickerInterval(interval);
        }
    }
}
