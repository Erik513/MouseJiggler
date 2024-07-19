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
            this.cbTopMost = new MouseJiggler.CustomCheckBox();
            this.cbShowInTaskbar = new MouseJiggler.CustomCheckBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.panelColorAutoClicker = new System.Windows.Forms.Panel();
            this.txtColorToReact = new System.Windows.Forms.TextBox();
            this.lblCustomColor = new System.Windows.Forms.Label();
            this.txtCustomColor = new System.Windows.Forms.TextBox();
            this.lblColorFound = new System.Windows.Forms.Label();
            this.btnColorFoundStatus = new System.Windows.Forms.Button();
            this.cboxColor = new System.Windows.Forms.ComboBox();
            this.lblColorAutoClicker = new System.Windows.Forms.Label();
            this.lblHotkeyColorAutoClicker = new System.Windows.Forms.Label();
            this.btnColorAutoClicker = new System.Windows.Forms.Button();
            this.panelMouseAutoClicker = new System.Windows.Forms.Panel();
            this.lblMouseAutoClicker = new System.Windows.Forms.Label();
            this.trackBarIntervalMouseAutoClicker = new System.Windows.Forms.TrackBar();
            this.lblHotkeyMouseAutoClicker = new System.Windows.Forms.Label();
            this.lblMouseAutoClickerDuration = new System.Windows.Forms.Label();
            this.btnMouseAutoClicker = new System.Windows.Forms.Button();
            this.panelMouseJiggler = new System.Windows.Forms.Panel();
            this.btnMouseJiggler = new System.Windows.Forms.Button();
            this.lblMouseJiggler = new System.Windows.Forms.Label();
            this.trackBarIntervalMouseJiggler = new System.Windows.Forms.TrackBar();
            this.lblMouseJigglerDuration = new System.Windows.Forms.Label();
            this.lblHotkeyMouseJiggler = new System.Windows.Forms.Label();
            this.panelGeneralSettings = new System.Windows.Forms.Panel();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblGeneralSettings = new System.Windows.Forms.Label();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.dragPanel.SuspendLayout();
            this.panelColorAutoClicker.SuspendLayout();
            this.panelMouseAutoClicker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseAutoClicker)).BeginInit();
            this.panelMouseJiggler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).BeginInit();
            this.panelGeneralSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
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
            this.cbTopMost.TabStop = false;
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
            this.cbShowInTaskbar.TabStop = false;
            this.cbShowInTaskbar.Text = "Show In Taskbar";
            this.cbShowInTaskbar.UseVisualStyleBackColor = true;
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Black;
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.panelColorAutoClicker);
            this.dragPanel.Controls.Add(this.panelMouseAutoClicker);
            this.dragPanel.Controls.Add(this.panelMouseJiggler);
            this.dragPanel.Controls.Add(this.panelGeneralSettings);
            this.dragPanel.Location = new System.Drawing.Point(5, 5);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(410, 445);
            this.dragPanel.TabIndex = 10;
            // 
            // panelColorAutoClicker
            // 
            this.panelColorAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelColorAutoClicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelColorAutoClicker.Controls.Add(this.txtColorToReact);
            this.panelColorAutoClicker.Controls.Add(this.lblCustomColor);
            this.panelColorAutoClicker.Controls.Add(this.txtCustomColor);
            this.panelColorAutoClicker.Controls.Add(this.lblColorFound);
            this.panelColorAutoClicker.Controls.Add(this.btnColorFoundStatus);
            this.panelColorAutoClicker.Controls.Add(this.cboxColor);
            this.panelColorAutoClicker.Controls.Add(this.lblColorAutoClicker);
            this.panelColorAutoClicker.Controls.Add(this.lblHotkeyColorAutoClicker);
            this.panelColorAutoClicker.Controls.Add(this.btnColorAutoClicker);
            this.panelColorAutoClicker.Location = new System.Drawing.Point(5, 320);
            this.panelColorAutoClicker.Name = "panelColorAutoClicker";
            this.panelColorAutoClicker.Size = new System.Drawing.Size(400, 120);
            this.panelColorAutoClicker.TabIndex = 18;
            // 
            // txtColorToReact
            // 
            this.txtColorToReact.Location = new System.Drawing.Point(254, 90);
            this.txtColorToReact.MaxLength = 7;
            this.txtColorToReact.Name = "txtColorToReact";
            this.txtColorToReact.ReadOnly = true;
            this.txtColorToReact.Size = new System.Drawing.Size(69, 20);
            this.txtColorToReact.TabIndex = 18;
            this.txtColorToReact.TabStop = false;
            // 
            // lblCustomColor
            // 
            this.lblCustomColor.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblCustomColor.AutoSize = true;
            this.lblCustomColor.BackColor = System.Drawing.Color.Black;
            this.lblCustomColor.ForeColor = System.Drawing.Color.White;
            this.lblCustomColor.Location = new System.Drawing.Point(12, 75);
            this.lblCustomColor.Name = "lblCustomColor";
            this.lblCustomColor.Size = new System.Drawing.Size(72, 13);
            this.lblCustomColor.TabIndex = 17;
            this.lblCustomColor.Text = "Custom Color:";
            // 
            // txtCustomColor
            // 
            this.txtCustomColor.Location = new System.Drawing.Point(15, 91);
            this.txtCustomColor.MaxLength = 7;
            this.txtCustomColor.Name = "txtCustomColor";
            this.txtCustomColor.Size = new System.Drawing.Size(69, 20);
            this.txtCustomColor.TabIndex = 16;
            // 
            // lblColorFound
            // 
            this.lblColorFound.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblColorFound.AutoSize = true;
            this.lblColorFound.BackColor = System.Drawing.Color.Black;
            this.lblColorFound.ForeColor = System.Drawing.Color.White;
            this.lblColorFound.Location = new System.Drawing.Point(330, 75);
            this.lblColorFound.Name = "lblColorFound";
            this.lblColorFound.Size = new System.Drawing.Size(64, 13);
            this.lblColorFound.TabIndex = 15;
            this.lblColorFound.Text = "Color Found";
            // 
            // btnColorFoundStatus
            // 
            this.btnColorFoundStatus.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColorFoundStatus.BackColor = System.Drawing.SystemColors.Control;
            this.btnColorFoundStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorFoundStatus.Location = new System.Drawing.Point(329, 91);
            this.btnColorFoundStatus.Name = "btnColorFoundStatus";
            this.btnColorFoundStatus.Size = new System.Drawing.Size(65, 19);
            this.btnColorFoundStatus.TabIndex = 14;
            this.btnColorFoundStatus.TabStop = false;
            this.btnColorFoundStatus.UseVisualStyleBackColor = false;
            // 
            // cboxColor
            // 
            this.cboxColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxColor.FormattingEnabled = true;
            this.cboxColor.Location = new System.Drawing.Point(14, 42);
            this.cboxColor.Name = "cboxColor";
            this.cboxColor.Size = new System.Drawing.Size(155, 21);
            this.cboxColor.TabIndex = 13;
            this.cboxColor.TabStop = false;
            // 
            // lblColorAutoClicker
            // 
            this.lblColorAutoClicker.AutoSize = true;
            this.lblColorAutoClicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblColorAutoClicker.Location = new System.Drawing.Point(10, 10);
            this.lblColorAutoClicker.Name = "lblColorAutoClicker";
            this.lblColorAutoClicker.Size = new System.Drawing.Size(179, 25);
            this.lblColorAutoClicker.TabIndex = 0;
            this.lblColorAutoClicker.Text = "ColorAutoClicker:";
            // 
            // lblHotkeyColorAutoClicker
            // 
            this.lblHotkeyColorAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyColorAutoClicker.AutoSize = true;
            this.lblHotkeyColorAutoClicker.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyColorAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyColorAutoClicker.Location = new System.Drawing.Point(274, 10);
            this.lblHotkeyColorAutoClicker.Name = "lblHotkeyColorAutoClicker";
            this.lblHotkeyColorAutoClicker.Size = new System.Drawing.Size(120, 13);
            this.lblHotkeyColorAutoClicker.TabIndex = 11;
            this.lblHotkeyColorAutoClicker.Text = "HotKey: Cntrl + Shift + L";
            // 
            // btnColorAutoClicker
            // 
            this.btnColorAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnColorAutoClicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnColorAutoClicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColorAutoClicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColorAutoClicker.Location = new System.Drawing.Point(330, 26);
            this.btnColorAutoClicker.Name = "btnColorAutoClicker";
            this.btnColorAutoClicker.Size = new System.Drawing.Size(65, 19);
            this.btnColorAutoClicker.TabIndex = 12;
            this.btnColorAutoClicker.TabStop = false;
            this.btnColorAutoClicker.UseVisualStyleBackColor = false;
            // 
            // panelMouseAutoClicker
            // 
            this.panelMouseAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMouseAutoClicker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMouseAutoClicker.Controls.Add(this.lblMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.trackBarIntervalMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.lblHotkeyMouseAutoClicker);
            this.panelMouseAutoClicker.Controls.Add(this.lblMouseAutoClickerDuration);
            this.panelMouseAutoClicker.Controls.Add(this.btnMouseAutoClicker);
            this.panelMouseAutoClicker.Location = new System.Drawing.Point(5, 215);
            this.panelMouseAutoClicker.Name = "panelMouseAutoClicker";
            this.panelMouseAutoClicker.Size = new System.Drawing.Size(400, 100);
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
            // trackBarIntervalMouseAutoClicker
            // 
            this.trackBarIntervalMouseAutoClicker.Location = new System.Drawing.Point(14, 38);
            this.trackBarIntervalMouseAutoClicker.Name = "trackBarIntervalMouseAutoClicker";
            this.trackBarIntervalMouseAutoClicker.Size = new System.Drawing.Size(186, 45);
            this.trackBarIntervalMouseAutoClicker.TabIndex = 13;
            this.trackBarIntervalMouseAutoClicker.TabStop = false;
            // 
            // lblHotkeyMouseAutoClicker
            // 
            this.lblHotkeyMouseAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyMouseAutoClicker.AutoSize = true;
            this.lblHotkeyMouseAutoClicker.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyMouseAutoClicker.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyMouseAutoClicker.Location = new System.Drawing.Point(274, 10);
            this.lblHotkeyMouseAutoClicker.Name = "lblHotkeyMouseAutoClicker";
            this.lblHotkeyMouseAutoClicker.Size = new System.Drawing.Size(121, 13);
            this.lblHotkeyMouseAutoClicker.TabIndex = 11;
            this.lblHotkeyMouseAutoClicker.Text = "HotKey: Cntrl + Shift + K";
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
            // btnMouseAutoClicker
            // 
            this.btnMouseAutoClicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseAutoClicker.BackColor = System.Drawing.SystemColors.Control;
            this.btnMouseAutoClicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouseAutoClicker.Location = new System.Drawing.Point(330, 26);
            this.btnMouseAutoClicker.Name = "btnMouseAutoClicker";
            this.btnMouseAutoClicker.Size = new System.Drawing.Size(65, 19);
            this.btnMouseAutoClicker.TabIndex = 12;
            this.btnMouseAutoClicker.TabStop = false;
            this.btnMouseAutoClicker.UseVisualStyleBackColor = false;
            // 
            // panelMouseJiggler
            // 
            this.panelMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMouseJiggler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMouseJiggler.Controls.Add(this.btnMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.lblMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.trackBarIntervalMouseJiggler);
            this.panelMouseJiggler.Controls.Add(this.lblMouseJigglerDuration);
            this.panelMouseJiggler.Controls.Add(this.lblHotkeyMouseJiggler);
            this.panelMouseJiggler.Location = new System.Drawing.Point(5, 110);
            this.panelMouseJiggler.Name = "panelMouseJiggler";
            this.panelMouseJiggler.Size = new System.Drawing.Size(400, 100);
            this.panelMouseJiggler.TabIndex = 16;
            // 
            // btnMouseJiggler
            // 
            this.btnMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMouseJiggler.BackColor = System.Drawing.SystemColors.Control;
            this.btnMouseJiggler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMouseJiggler.Location = new System.Drawing.Point(330, 26);
            this.btnMouseJiggler.Name = "btnMouseJiggler";
            this.btnMouseJiggler.Size = new System.Drawing.Size(65, 19);
            this.btnMouseJiggler.TabIndex = 15;
            this.btnMouseJiggler.TabStop = false;
            this.btnMouseJiggler.UseVisualStyleBackColor = false;
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
            // trackBarIntervalMouseJiggler
            // 
            this.trackBarIntervalMouseJiggler.Location = new System.Drawing.Point(15, 38);
            this.trackBarIntervalMouseJiggler.Name = "trackBarIntervalMouseJiggler";
            this.trackBarIntervalMouseJiggler.Size = new System.Drawing.Size(186, 45);
            this.trackBarIntervalMouseJiggler.TabIndex = 3;
            this.trackBarIntervalMouseJiggler.TabStop = false;
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
            // lblHotkeyMouseJiggler
            // 
            this.lblHotkeyMouseJiggler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHotkeyMouseJiggler.AutoSize = true;
            this.lblHotkeyMouseJiggler.BackColor = System.Drawing.Color.Black;
            this.lblHotkeyMouseJiggler.ForeColor = System.Drawing.Color.White;
            this.lblHotkeyMouseJiggler.Location = new System.Drawing.Point(276, 10);
            this.lblHotkeyMouseJiggler.Name = "lblHotkeyMouseJiggler";
            this.lblHotkeyMouseJiggler.Size = new System.Drawing.Size(119, 13);
            this.lblHotkeyMouseJiggler.TabIndex = 10;
            this.lblHotkeyMouseJiggler.Text = "HotKey: Cntrl + Shift + J";
            // 
            // panelGeneralSettings
            // 
            this.panelGeneralSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelGeneralSettings.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGeneralSettings.Controls.Add(this.lblWarning);
            this.panelGeneralSettings.Controls.Add(this.lblGeneralSettings);
            this.panelGeneralSettings.Controls.Add(this.cbTopMost);
            this.panelGeneralSettings.Controls.Add(this.cbShowInTaskbar);
            this.panelGeneralSettings.Controls.Add(this.pboxWindowClose);
            this.panelGeneralSettings.Location = new System.Drawing.Point(5, 5);
            this.panelGeneralSettings.Name = "panelGeneralSettings";
            this.panelGeneralSettings.Size = new System.Drawing.Size(400, 100);
            this.panelGeneralSettings.TabIndex = 15;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Black;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(250, 10);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(116, 13);
            this.lblWarning.TabIndex = 16;
            this.lblWarning.Text = "Use At Your Own Risk!";
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
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxWindowClose.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(371, 2);
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
            this.ClientSize = new System.Drawing.Size(420, 450);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.dragPanel.ResumeLayout(false);
            this.panelColorAutoClicker.ResumeLayout(false);
            this.panelColorAutoClicker.PerformLayout();
            this.panelMouseAutoClicker.ResumeLayout(false);
            this.panelMouseAutoClicker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseAutoClicker)).EndInit();
            this.panelMouseJiggler.ResumeLayout(false);
            this.panelMouseJiggler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarIntervalMouseJiggler)).EndInit();
            this.panelGeneralSettings.ResumeLayout(false);
            this.panelGeneralSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Panel panelColorAutoClicker;
        private System.Windows.Forms.Label lblColorAutoClicker;
        private System.Windows.Forms.Label lblHotkeyColorAutoClicker;
        private System.Windows.Forms.Button btnColorAutoClicker;
        private System.Windows.Forms.ComboBox cboxColor;
        private System.Windows.Forms.Button btnColorFoundStatus;
        private System.Windows.Forms.Label lblColorFound;
        private System.Windows.Forms.Label lblWarning;
        private CustomCheckBox cbTopMost;
        private CustomCheckBox cbShowInTaskbar;
        private System.Windows.Forms.Label lblCustomColor;
        private System.Windows.Forms.TextBox txtCustomColor;
        private System.Windows.Forms.TextBox txtColorToReact;
    }
}