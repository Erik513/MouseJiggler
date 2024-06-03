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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.cbTopMost = new System.Windows.Forms.CheckBox();
            this.cbShowInTaskbar = new System.Windows.Forms.CheckBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.lblESC = new System.Windows.Forms.Label();
            this.lblDuration = new System.Windows.Forms.Label();
            this.trackBarInterval = new System.Windows.Forms.TrackBar();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.ttIntervalValue = new System.Windows.Forms.ToolTip(this.components);
            this.ttDistance = new System.Windows.Forms.ToolTip(this.components);
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTopMost
            // 
            this.cbTopMost.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.cbShowInTaskbar.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.dragPanel.Controls.Add(this.lblESC);
            this.dragPanel.Controls.Add(this.lblDuration);
            this.dragPanel.Controls.Add(this.trackBarInterval);
            this.dragPanel.Controls.Add(this.pboxWindowClose);
            this.dragPanel.Controls.Add(this.cbTopMost);
            this.dragPanel.Controls.Add(this.cbShowInTaskbar);
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(362, 216);
            this.dragPanel.TabIndex = 10;
            // 
            // lblESC
            // 
            this.lblESC.AutoSize = true;
            this.lblESC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblESC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblESC.Location = new System.Drawing.Point(162, 11);
            this.lblESC.Name = "lblESC";
            this.lblESC.Size = new System.Drawing.Size(136, 25);
            this.lblESC.TabIndex = 9;
            this.lblESC.Text = "ESC To Stop";
            this.lblESC.Visible = false;
            // 
            // lblDuration
            // 
            this.lblDuration.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDuration.AutoSize = true;
            this.lblDuration.BackColor = System.Drawing.Color.White;
            this.lblDuration.Location = new System.Drawing.Point(216, 66);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 5;
            this.lblDuration.Text = "Duration";
            // 
            // trackBarInterval
            // 
            this.trackBarInterval.Location = new System.Drawing.Point(3, 57);
            this.trackBarInterval.Name = "trackBarInterval";
            this.trackBarInterval.Size = new System.Drawing.Size(186, 45);
            this.trackBarInterval.TabIndex = 3;
            this.trackBarInterval.MouseMove += new System.Windows.Forms.MouseEventHandler(this.trackBarInterval_MouseMove);
            this.trackBarInterval.MouseUp += new System.Windows.Forms.MouseEventHandler(this.trackBarInterval_MouseUp);
            // 
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pboxWindowClose.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(336, -1);
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
            this.ClientSize = new System.Drawing.Size(374, 228);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox cbTopMost;
        private System.Windows.Forms.CheckBox cbShowInTaskbar;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.PictureBox pboxWindowClose;
        private System.Windows.Forms.TrackBar trackBarInterval;
        private System.Windows.Forms.ToolTip ttIntervalValue;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.ToolTip ttDistance;
        private System.Windows.Forms.Label lblESC;
    }
}