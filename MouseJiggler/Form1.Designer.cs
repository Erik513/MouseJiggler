namespace MouseJiggler
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.btnStartStop = new System.Windows.Forms.Button();
            this.pboxWindowMinimize = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.pboxSettings = new System.Windows.Forms.PictureBox();
            this.ttOnOff = new System.Windows.Forms.ToolTip(this.components);
            this.ttMinimize = new System.Windows.Forms.ToolTip(this.components);
            this.ttClose = new System.Windows.Forms.ToolTip(this.components);
            this.ttSettings = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).BeginInit();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxWindowClose.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(145, -1);
            this.pboxWindowClose.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowClose.Name = "pboxWindowClose";
            this.pboxWindowClose.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowClose.TabIndex = 4;
            this.pboxWindowClose.TabStop = false;
            this.ttClose.SetToolTip(this.pboxWindowClose, "End");
            this.pboxWindowClose.Click += new System.EventHandler(this.FensterSchließen);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Location = new System.Drawing.Point(3, -1);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(54, 25);
            this.btnStartStop.TabIndex = 0;
            this.ttOnOff.SetToolTip(this.btnStartStop, "On/Off");
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // pboxWindowMinimize
            // 
            this.pboxWindowMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxWindowMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowMinimize.Image")));
            this.pboxWindowMinimize.Location = new System.Drawing.Point(116, -1);
            this.pboxWindowMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowMinimize.Name = "pboxWindowMinimize";
            this.pboxWindowMinimize.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowMinimize.TabIndex = 6;
            this.pboxWindowMinimize.TabStop = false;
            this.ttMinimize.SetToolTip(this.pboxWindowMinimize, "Minimize");
            this.pboxWindowMinimize.Click += new System.EventHandler(this.MinimizeWindow);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Black;
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.pboxSettings);
            this.dragPanel.Controls.Add(this.pboxWindowMinimize);
            this.dragPanel.Controls.Add(this.btnStartStop);
            this.dragPanel.Controls.Add(this.pboxWindowClose);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(175, 27);
            this.dragPanel.TabIndex = 5;
            // 
            // pboxSettings
            // 
            this.pboxSettings.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.pboxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pboxSettings.Image")));
            this.pboxSettings.Location = new System.Drawing.Point(90, -1);
            this.pboxSettings.Name = "pboxSettings";
            this.pboxSettings.Size = new System.Drawing.Size(21, 27);
            this.pboxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxSettings.TabIndex = 8;
            this.pboxSettings.TabStop = false;
            this.ttSettings.SetToolTip(this.pboxSettings, "Settings");
            this.pboxSettings.Click += new System.EventHandler(this.OpenSettingsForm);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(175, 27);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).EndInit();
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pboxWindowClose;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.PictureBox pboxWindowMinimize;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.ToolTip ttOnOff;
        private System.Windows.Forms.ToolTip ttMinimize;
        private System.Windows.Forms.ToolTip ttClose;
        private System.Windows.Forms.PictureBox pboxSettings;
        private System.Windows.Forms.ToolTip ttSettings;
    }
}

