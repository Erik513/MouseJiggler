using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseJiggler
{
    public partial class Settings : Form
    {
        private MainForm mainForm;
        private bool topMostState;
        private bool showInTaskbar;
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
            //TopMost
            cbTopMost.Checked = form.TopMost;
            topMostState = form.TopMost;
            //ShowInTaskbar
            cbShowInTaskbar.Checked = form.ShowInTaskbar;
            showInTaskbar = form.ShowInTaskbar;
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

        private void pboxWindowClose_Click(object sender, EventArgs e)
        {
            this.Close();
            mainForm.WindowState = FormWindowState.Normal;
            mainForm.Show();
        }
    }
}
