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
            this.lblMouseAutoClickerDuration = new System.Windows.Forms.Label();
            this.trackBarIntervalMouseAutoClicker = new System.Windows.Forms.TrackBar();
            this.btnMouseAutoClicker = new System.Windows.Forms.Button();
            this.lblHotkeyMouseAutoClicker = new System.Windows.Forms.Label();
            this.lblHotkeyMouseJiggler = new System.Windows.Forms.Label();
            this.lblMouseJigglerDuration = new System.Windows.Forms.Label();
            this.trackBarIntervalMouseJiggler = new System.Windows.Forms.TrackBar();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.panelGeneralSettings = new System.Windows.Forms.Panel();
            this.lblGeneralSettings = new System.Windows.Forms.Label();
            this.panelMouseJiggler = new System.Windows.Forms.Panel();
            this.lblMouseJiggler = new System.Windows.Forms.Label();
            this.panelMouseAutoClicker = new System.Windows.Forms.Panel();
            this.lblMouseAutoClicker = new System.Windows.Forms.Label();
            this.btnMouseJiggler = new System.Windows.Forms.Button();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseAutoClicker)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            this.panelGeneralSettings.SuspendLayout();
            this.panelMouseJiggler.SuspendLayout();
            this.panelMouseAutoClicker.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbTopMost
            // 
            this.cbTopMost.AutoSize = true;
            this.cbTopMost.ForeColor = System.Drawing.Color.White;
            this.cbTopMost.Location = new System.Drawing.Point(15, 38);
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
            this.cbShowInTaskbar.Location = new System.Drawing.Point(15, 61);
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
            this.dragPanel.Controls.Add(this.panelMouseAutoClicker);
            this.dragPanel.Controls.Add(this.panelMouseJiggler);
            this.dragPanel.Controls.Add(this.panelGeneralSettings);
            this.dragPanel.Location = new System.Drawing.Point(5, 5);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(413, 413);
            this.dragPanel.TabIndex = 10;
            // 
            // lblMouseAutoClickerDuration
            // 
            this.lblMouseAutoClickerDuration.BackColor = System.Drawing.Color.Black;
            this.lblMouseAutoClickerDuration.ForeColor = System.Drawing.Color.White;
            this.lblMouseAutoClickerDuration.Location = new System.Drawing.Point(206, 38);
            this.lblMouseAutoClickerDuration.Name = "lblMouseAutoClickerDuration";
            this.lblMouseAutoClickerDuration.Size = new System.Drawing.Size(85, 45);
            this.lblMouseAutoClickerDuration.TabIndex = 14;
            this.lblMouseAutoClickerDuration.Text = "Clicks per Minute";
            // 
            // trackBarIntervalMouseAutoClicker
            // 
            this.trackBarIntervalMouseAutoClicker.Location = new System.Drawing.Point(14, 38);
            this.trackBarIntervalMouseAutoClicker.Name = "trackBarIntervalMouseAutoClicker";
            this.trackBarIntervalMouseAutoClicker.Size = new System.Drawing.Size(186, 45);
            this.trackBarIntervalMouseAutoClicker.TabIndex = 13;
            this.trackBarIntervalMouseAutoClicker.TabStop = false;
            this.trackBarIntervalMouseAutoClicker.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBarIntervalAutoclicker_MouseMove);
            this.trackBarIntervalMouseAutoClicker.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarIntervalAutoclicker_MouseUp);
            // 
            // btnMouseAutoClicker
            // 
            this.btnMouseAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseAutoClicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnMouseAutoClicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouseAutoClicker.Location = new System.Drawing.Point(317, 64);
            this.btnMouseAutoClicker.Name = "btnMouseAutoClicker";
            this.btnMouseAutoClicker.Size = new System.Drawing.Size(65, 19);
            this.btnMouseAutoClicker.TabIndex = 12;
            this.btnMouseAutoClicker.UseVisualStyleBackColor = false;
            // 
            // lblHotkeyMouseAutoClicker
            // 
            this.lblHotkeyMouseAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyMouseAutoClicker.AutoSize = true;
            this.lblHotkeyMouseAutoClicker.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyMouseAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyMouseAutoClicker.Location = new System.Drawing.Point(261, 10);
            this.lblHotkeyMouseAutoClicker.Name = "lblHotkeyMouseAutoClicker";
            this.lblHotkeyMouseAutoClicker.Size = new System.Drawing.Size(121, 13);
            this.lblHotkeyMouseAutoClicker.TabIndex = 11;
            this.lblHotkeyMouseAutoClicker.Text = "HotKey: Cntrl + Shift + K";
            // 
            // lblHotkeyMouseJiggler
            // 
            this.lblHotkeyMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyMouseJiggler.AutoSize = true;
            this.lblHotkeyMouseJiggler.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyMouseJiggler.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyMouseJiggler.Location = new System.Drawing.Point(263, 10);
            this.lblHotkeyMouseJiggler.Name = "lblHotkeyMouseJiggler";
            this.lblHotkeyMouseJiggler.Size = new System.Drawing.Size(119, 13);
            this.lblHotkeyMouseJiggler.TabIndex = 10;
            this.lblHotkeyMouseJiggler.Text = "HotKey: Cntrl + Shift + J";
            // 
            // lblMouseJigglerDuration
            // 
            this.lblMouseJigglerDuration.BackColor = System.Drawing.Color.Black;
            this.lblMouseJigglerDuration.ForeColor = System.Drawing.Color.White;
            this.lblMouseJigglerDuration.Location = new System.Drawing.Point(207, 40);
            this.lblMouseJigglerDuration.Name = "lblMouseJigglerDuration";
            this.lblMouseJigglerDuration.Size = new System.Drawing.Size(85, 43);
            this.lblMouseJigglerDuration.TabIndex = 5;
            this.lblMouseJigglerDuration.Text = "Duration";
            // 
            // trackBarIntervalMouseJiggler
            // 
            this.trackBarIntervalMouseJiggler.Location = new System.Drawing.Point(15, 38);
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
            this.pboxWindowClose.Location = new System.Drawing.Point(358, 2);
            this.pboxWindowClose.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowClose.Name = "pboxWindowClose";
            this.pboxWindowClose.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowClose.TabIndex = 4;
            this.pboxWindowClose.TabStop = false;
            this.pboxWindowClose.Click += new System.EventHandler(this.pboxWindowClose_Click);
            // 
            // panelGeneralSettings
            // 
            this.panelGeneralSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeneralSettings.Controls.Add(this.lblGeneralSettings);
            this.panelGeneralSettings.Controls.Add(this.cbTopMost);
            this.panelGeneralSettings.Controls.Add(this.cbShowInTaskbar);
            this.panelGeneralSettings.Controls.Add(this.pboxWindowClose);
            this.panelGeneralSettings.Location = new System.Drawing.Point(5, 5);
            this.panelGeneralSettings.Name = "panelGeneralSettings";
            this.panelGeneralSettings.Size = new System.Drawing.Size(387, 100);
            this.panelGeneralSettings.TabIndex = 15;
            // 
            // lblGeneralSettings
            // 
            this.lblGeneralSettings.AutoSize = true;
            this.lblGeneralSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGeneralSettings.ForeColor = System.Drawing.Color.White;
            this.lblGeneralSettings.Location = new System.Drawing.Point(10, 10);
            this.lblGeneralSettings.Name = "lblGeneralSettings";
            this.lblGeneralSettings.Size = new System.Drawing.Size(178, 25);
            this.lblGeneralSettings.TabIndex = 0;
            this.lblGeneralSettings.Text = "General Settings:";
            // 
            // panelMouseJiggler
            // 
            this.panelMouseJiggler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMouseJiggler.Controls.Add(this.btnMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.lblMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.trackBarIntervalMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.lblMouseJigglerDuration);
            this.panelMouseJiggler.Controls.Add(this.lblHotkeyMouseJiggler);
            this.panelMouseJiggler.Location = new System.Drawing.Point(5, 111);
            this.panelMouseJiggler.Name = "panelMouseJiggler";
            this.panelMouseJiggler.Size = new System.Drawing.Size(387, 100);
            this.panelMouseJiggler.TabIndex = 16;
            // 
            // lblMouseJiggler
            // 
            this.lblMouseJiggler.AutoSize = true;
            this.lblMouseJiggler.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseJiggler.ForeColor = System.Drawing.Color.White;
            this.lblMouseJiggler.Location = new System.Drawing.Point(10, 10);
            this.lblMouseJiggler.Name = "lblMouseJiggler";
            this.lblMouseJiggler.Size = new System.Drawing.Size(147, 25);
            this.lblMouseJiggler.TabIndex = 0;
            this.lblMouseJiggler.Text = "MouseJiggler:";
            // 
            // panelMouseAutoClicker
            // 
            this.panelMouseAutoClicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMouseAutoClicker.Controls.Add(this.lblMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.trackBarIntervalMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.lblHotkeyMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.lblMouseAutoClickerDuration);
            this.panelMouseAutoClicker.Controls.Add(this.btnMouseAutoClicker);
            this.panelMouseAutoClicker.Location = new System.Drawing.Point(5, 217);
            this.panelMouseAutoClicker.Name = "panelMouseAutoClicker";
            this.panelMouseAutoClicker.Size = new System.Drawing.Size(387, 100);
            this.panelMouseAutoClicker.TabIndex = 17;
            // 
            // lblMouseAutoClicker
            // 
            this.lblMouseAutoClicker.AutoSize = true;
            this.lblMouseAutoClicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMouseAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblMouseAutoClicker.Location = new System.Drawing.Point(10, 10);
            this.lblMouseAutoClicker.Name = "lblMouseAutoClicker";
            this.lblMouseAutoClicker.Size = new System.Drawing.Size(193, 25);
            this.lblMouseAutoClicker.TabIndex = 0;
            this.lblMouseAutoClicker.Text = "MouseAutoClicker:";
            // 
            // btnMouseJiggler
            // 
            this.btnMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseJiggler.BackColor = System.Drawing.SystemColors.Control;
            this.btnMouseJiggler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouseJiggler.Location = new System.Drawing.Point(317, 64);
            this.btnMouseJiggler.Name = "btnMouseJiggler";
            this.btnMouseJiggler.Size = new System.Drawing.Size(65, 19);
            this.btnMouseJiggler.TabIndex = 15;
            this.btnMouseJiggler.UseVisualStyleBackColor = false;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(431, 427);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseAutoClicker)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.panelGeneralSettings.ResumeLayout(false);
            this.panelGeneralSettings.PerformLayout();
            this.panelMouseJiggler.ResumeLayout(false);
            this.panelMouseJiggler.PerformLayout();
            this.panelMouseAutoClicker.ResumeLayout(false);
            this.panelMouseAutoClicker.PerformLayout();
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
        private System.Windows.Forms.Label lblHotkeyMouseAutoClicker;
        private System.Windows.Forms.Button btnMouseAutoClicker;
        private System.Windows.Forms.Label lblMouseAutoClickerDuration;
        private System.Windows.Forms.TrackBar trackBarIntervalMouseAutoClicker;
        private System.Windows.Forms.Panel panelGeneralSettings;
        private System.Windows.Forms.Label lblGeneralSettings;
        private System.Windows.Forms.Panel panelMouseJiggler;
        private System.Windows.Forms.Label lblMouseJiggler;
        private System.Windows.Forms.Panel panelMouseAutoClicker;
        private System.Windows.Forms.Label lblMouseAutoClicker;
        private System.Windows.Forms.Button btnMouseJiggler;
    }
}