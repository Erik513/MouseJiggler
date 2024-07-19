using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MouseJiggler
{
    public partial class Settings : Form
    {
        private MainForm mainForm;
        private CustomCheckBox customCheckBox;
        private bool topMostState;
        private bool showInTaskbar;
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
            this.KeyPreview = true;
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
            new DraggableControl(lblWarning);
            new DraggableControl(cbTopMost);
            new DraggableControl(cbShowInTaskbar);
            //MouseJiggler (trackbar not included)
            new DraggableControl(panelMouseJiggler);
            new DraggableControl(lblMouseJiggler);
            new DraggableControl(lblMouseJigglerDuration);
            new DraggableControl(lblHotkeyMouseJiggler);
            new DraggableControl(btnMouseJiggler);
            //MouseAutoClicker (trackbar  not included)
            new DraggableControl(panelMouseAutoClicker);
            new DraggableControl(lblMouseAutoClicker);
            new DraggableControl(lblHotkeyMouseAutoClicker);
            new DraggableControl(lblMouseAutoClickerDuration);
            new DraggableControl(btnMouseAutoClicker);
            //ColorAutoClicker (combobox and textbox not included)
            new DraggableControl(panelColorAutoClicker);
            new DraggableControl(lblColorAutoClicker);
            new DraggableControl(lblCustomColor);
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
            lblCustomColor.Visible = false;
            txtCustomColor.Visible = false;
            txtCustomColor.Text = "#";
            txtCustomColor.KeyPress += TxtCustomColor_KeyPress;
            txtCustomColor.TextChanged += TxtCustomColor_TextChanged;
            txtCustomColor.KeyDown += TxtCustomColor_KeyDown;
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
            lblMouseAutoClickerDuration.Text = $"Clicks: \n{trackBarIntervalMouseAutoClicker.Value} \n(Per Minute)";
        }
        private void SetupColorAutoClicker()
        {
            colorAutoClicker = new ColorAutoClicker(UpdateColorStatusButton);
            cboxColor.Items.AddRange(new string[] { "Red", "Yellow", "Green", "Blue", "Pink", "Black", "Gray", "White", "Custom..." });
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
            if (selectedColor == "Custom...")
            {
                lblCustomColor.Visible = true;
                txtCustomColor.Visible = true;
                txtCustomColor.Focus();
            }
            else
            {
                lblCustomColor.Visible = false;
                txtCustomColor.Visible = false;
                Color color = Color.FromName(selectedColor);
                mainForm.SetColorAutoClickerTargetColor(color);
            }
        }
        private void TxtCustomColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Only allow valid hex characters
            if (!IsValidHexChar(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void TxtCustomColor_TextChanged(object sender, EventArgs e)
        {
            // Ensure the first character is always '#'
            if (!txtCustomColor.Text.StartsWith("#"))
            {
                txtCustomColor.Text = "#" + txtCustomColor.Text.TrimStart('#');
                txtCustomColor.SelectionStart = txtCustomColor.Text.Length; // Set cursor to end
            }
        }

        private bool IsValidHexChar(char c)
        {
            return (c >= '0' && c <= '9') ||
                   (c >= 'a' && c <= 'f') ||
                   (c >= 'A' && c <= 'F');
        }

        private void TxtCustomColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string hexColor = txtCustomColor.Text;
                if (hexColor.Length == 7 && Regex.IsMatch(hexColor, @"^#[0-9A-Fa-f]{6}$"))
                {
                    try
                    {
                        Color color = ColorTranslator.FromHtml(hexColor);
                        mainForm.SetColorAutoClickerTargetColor(color);
                        // Add the custom color to the ComboBox and select it
                        //if (!cboxColor.Items.Contains(hexColor))
                        //{
                        //    cboxColor.Items.Insert(cboxColor.Items.Count - 1, hexColor);
                        //}
                        cboxColor.SelectedItem = hexColor;
                        txtCustomColor.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Invalid color code. Please enter a valid hex color code (e.g., #RRGGBB).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCustomColor.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Hex color code must be 6 characters long.");
                }
            }
        }
    }
}
