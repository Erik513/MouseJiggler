﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static MouseJiggler.RandomMovement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MouseJiggler
{
    public partial class Settings : Form
    {
        private MainForm mainForm;
        private bool topMostState;
        private bool showInTaskbar;

        private void pboxWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.Show();
        }

        public Settings()
        {
            InitializeComponent();
            CenterToScreen();
            BringToFront();
            DraggableControl draggablePanel = new DraggableControl(dragPanel);
            cbTopMost.CheckStateChanged += CbTopMost_CheckStateChanged;
            cbTopMost.Checked = topMostState;
            cbShowInTaskbar.CheckStateChanged += CbShowInTaskbar_CheckStateChanged;
            cbShowInTaskbar.Checked = showInTaskbar;
        }

        public Settings(MainForm form) : this()
        {
            mainForm = form;
            lblESC.Visible = false;
            this.KeyPreview = true;
            //TopMost
            cbTopMost.Checked = form.TopMost;
            topMostState = form.TopMost;
            //ShowInTaskbar
            cbShowInTaskbar.Checked = form.ShowInTaskbar;
            showInTaskbar = form.ShowInTaskbar;
            //TrackbarInterval
            trackBarInterval.Minimum = 1; // Minimum 0,1 Sekunden
            trackBarInterval.Maximum = 600; // Maximum 60 Sekunden
            trackBarInterval.TickFrequency = 100;
            trackBarInterval.Value = mainForm.GetTimerInterval() / 100;
            lblDuration.Text = $"Duration: {trackBarInterval.Value / 10.0} Second(s)";

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
            lblDuration.Text = $"Duration: {trackBarInterval.Value / 10.0} Second(s)";
            //ttIntervalValue.SetToolTip(trackBarInterval, $"{trackBarInterval.Value / 10.0} Second(s)");
        }
        private void trackBarInterval_MouseUp(object sender, MouseEventArgs e)
        {
            int interval = (int)(trackBarInterval.Value * 100); // Wert in 100 Millisekunden
            mainForm.SetTimerInterval(interval);
        }

        private void lblRandom_Click(object sender, EventArgs e)
        {
                    
        }
    }
}
