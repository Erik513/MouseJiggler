namespace MouseJiggler
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.cbShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.lblAutoclickerDuration = new System.Windows.Forms.Label();
            this.trackBarIntervalAutoclicker = new System.Windows.Forms.TrackBar();
            this.btnAutoclicker = new System.Windows.Forms.Button();
            this.lblHotkeyAutoclicker = new System.Windows.Forms.Label();
            this.lblHotkeyMouseJiggler = new System.Windows.Forms.Label();
            this.lblMouseJigglerDuration = new System.Windows.Forms.Label();
            this.trackBarIntervalMouseJiggler = new System.Windows.Forms.TrackBar();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalAutoclicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.ForeColor = System.Drawing.Color.White;
            this.cbTopMost.Location = new System.Drawing.Point(11, 11);
            this.cbTopMost.Name = "cbTopMost";
            this.cbTopMost.Size = new System.Drawing.Size(98, 17);
            this.cbTopMost.TabIndex = 1;
            this.cbTopMost.Text = "Always On Top";
            this.cbTopMost.UseVisualStyleBackColor = true;
            // 
            // cbShowInTaskbar
            // 
            this.cbShowInTaskbar.AutoSize = true;
            this.cbShowInTaskbar.ForeColor = System.Drawing.Color.White;
            this.cbShowInTaskbar.Location = new System.Drawing.Point(11, 34);
            this.cbShowInTaskbar.Name = "cbShowInTaskbar";
            this.cbShowInTaskbar.Size = new System.Drawing.Size(107, 17);
            this.cbShowInTaskbar.TabIndex = 2;
            this.cbShowInTaskbar.Text = "Show In Taskbar";
            this.cbShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Black;
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.lblAutoclickerDuration);
            this.dragPanel.Controls.Add(this.trackBarIntervalAutoclicker);
            this.dragPanel.Controls.Add(this.btnAutoclicker);
            this.dragPanel.Controls.Add(this.lblHotkeyAutoclicker);
            this.dragPanel.Controls.Add(this.lblHotkeyMouseJiggler);
            this.dragPanel.Controls.Add(this.lblMouseJigglerDuration);
            this.dragPanel.Controls.Add(this.trackBarIntervalMouseJiggler);
            this.dragPanel.Controls.Add(this.pboxWindowClose);
            this.dragPanel.Controls.Add(this.cbTopMost);
            this.dragPanel.Controls.Add(this.cbShowInTaskbar);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(290, 181);
            this.dragPanel.TabIndex = 10;
            // 
            // lblAutoclickerDuration
            // 
            this.lblAutoclickerDuration.BackColor = System.Drawing.Color.Black;
            this.lblAutoclickerDuration.ForeColor = System.Drawing.Color.White;
            this.lblAutoclickerDuration.Location = new System.Drawing.Point(195, 130);
            this.lblAutoclickerDuration.Name = "lblAutoclickerDuration";
            this.lblAutoclickerDuration.Size = new System.Drawing.Size(85, 45);
            this.lblAutoclickerDuration.TabIndex = 14;
            this.lblAutoclickerDuration.Text = "Clicks per Minute";
            // 
            // trackBarIntervalAutoclicker
            // 
            this.trackBarIntervalAutoclicker.Location = new System.Drawing.Point(3, 130);
            this.trackBarIntervalAutoclicker.Name = "trackBarIntervalAutoclicker";
            this.trackBarIntervalAutoclicker.Size = new System.Drawing.Size(186, 45);
            this.trackBarIntervalAutoclicker.TabIndex = 13;
            this.trackBarIntervalAutoclicker.TabStop = false;
            this.trackBarIntervalAutoclicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBarIntervalAutoclicker_MouseMove);
            this.trackBarIntervalAutoclicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarIntervalAutoclicker_MouseUp);
            // 
            // btnAutoclicker
            // 
            this.btnAutoclicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAutoclicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnAutoclicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoclicker.Location = new System.Drawing.Point(11, 108);
            this.btnAutoclicker.Name = "btnAutoclicker";
            this.btnAutoclicker.Size = new System.Drawing.Size(65, 19);
            this.btnAutoclicker.TabIndex = 12;
            this.btnAutoclicker.UseVisualStyleBackColor = false;
            // 
            // lblHotkeyAutoclicker
            // 
            this.lblHotkeyAutoclicker.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblHotkeyAutoclicker.AutoSize = true;
            this.lblHotkeyAutoclicker.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyAutoclicker.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyAutoclicker.Location = new System.Drawing.Point(82, 110);
            this.lblHotkeyAutoclicker.Name = "lblHotkeyAutoclicker";
            this.lblHotkeyAutoclicker.Size = new System.Drawing.Size(177, 13);
            this.lblHotkeyAutoclicker.TabIndex = 11;
            this.lblHotkeyAutoclicker.Text = "Autoclicker HotKey: Cntrl + Shift + K";
            // 
            // lblHotkeyMouseJiggler
            // 
            this.lblHotkeyMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyMouseJiggler.AutoSize = true;
            this.lblHotkeyMouseJiggler.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyMouseJiggler.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyMouseJiggler.Location = new System.Drawing.Point(140, 8);
            this.lblHotkeyMouseJiggler.Name = "lblHotkeyMouseJiggler";
            this.lblHotkeyMouseJiggler.Size = new System.Drawing.Size(119, 13);
            this.lblHotkeyMouseJiggler.TabIndex = 10;
            this.lblHotkeyMouseJiggler.Text = "HotKey: Cntrl + Shift + J";
            // 
            // lblMouseJigglerDuration
            // 
            this.lblMouseJigglerDuration.BackColor = System.Drawing.Color.Black;
            this.lblMouseJigglerDuration.ForeColor = System.Drawing.Color.White;
            this.lblMouseJigglerDuration.Location = new System.Drawing.Point(195, 59);
            this.lblMouseJigglerDuration.Name = "lblMouseJigglerDuration";
            this.lblMouseJigglerDuration.Size = new System.Drawing.Size(85, 43);
            this.lblMouseJigglerDuration.TabIndex = 5;
            this.lblMouseJigglerDuration.Text = "Duration";
            // 
            // trackBarIntervalMouseJiggler
            // 
            this.trackBarIntervalMouseJiggler.Location = new System.Drawing.Point(3, 57);
            this.trackBarIntervalMouseJiggler.Name = "trackBarIntervalMouseJiggler";
            this.trackBarIntervalMouseJiggler.Size = new System.Drawing.Size(186, 45);
            this.trackBarIntervalMouseJiggler.TabIndex = 3;
            this.trackBarIntervalMouseJiggler.TabStop = false;
            this.trackBarIntervalMouseJiggler.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBarInterval_MouseMove);
            this.trackBarIntervalMouseJiggler.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarInterval_MouseUp);
            // 
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxWindowClose.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(264, -1);
            this.pboxWindowClose.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowClose.Name = "pboxWindowClose";
            this.pboxWindowClose.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowClose.TabIndex = 4;
            this.pboxWindowClose.TabStop = false;
            this.pboxWindowClose.Click += new System.EventHandler(this.pboxWindowClose_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(297, 193);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalAutoclicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.CheckBox cbShowInTaskbar;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.PictureBox pboxWindowClose;
        private System.Windows.Forms.TrackBar trackBarIntervalMouseJiggler;
        private System.Windows.Forms.Label lblMouseJigglerDuration;
        private System.Windows.Forms.Label lblHotkeyMouseJiggler;
        private System.Windows.Forms.Label lblHotkeyAutoclicker;
        private System.Windows.Forms.Button btnAutoclicker;
        private System.Windows.Forms.Label lblAutoclickerDuration;
        private System.Windows.Forms.TrackBar trackBarIntervalAutoclicker;
    }
}