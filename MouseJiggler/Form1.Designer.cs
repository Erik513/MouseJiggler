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
            this.timerMouseJiggler = new System.Windows.Forms.Timer(this.components);
            this.btnStartStop = new System.Windows.Forms.Button();
            this.pboxWindowClose = new System.Windows.Forms.PictureBox();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.pboxWindowMinimize = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).BeginInit();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // timerMouseJiggler
            // 
            this.timerMouseJiggler.Interval = 1000;
            this.timerMouseJiggler.Tick += new System.EventHandler(this.timerMouseJiggler_Tick);
            // 
            // btnStartStop
            // 
            this.btnStartStop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnStartStop.BackColor = System.Drawing.SystemColors.Control;
            this.btnStartStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartStop.Location = new System.Drawing.Point(-1, -1);
            this.btnStartStop.Name = "btnStartStop";
            this.btnStartStop.Size = new System.Drawing.Size(54, 25);
            this.btnStartStop.TabIndex = 0;
            this.btnStartStop.UseVisualStyleBackColor = false;
            this.btnStartStop.Click += new System.EventHandler(this.btnStartStop_Click);
            // 
            // pboxWindowClose
            // 
            this.pboxWindowClose.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxWindowClose.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowClose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowClose.Image")));
            this.pboxWindowClose.Location = new System.Drawing.Point(122, -1);
            this.pboxWindowClose.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowClose.Name = "pboxWindowClose";
            this.pboxWindowClose.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowClose.TabIndex = 4;
            this.pboxWindowClose.TabStop = false;
            this.pboxWindowClose.Click += new System.EventHandler(this.FensterSchließen);
            // 
            // dragPanel
            // 
            this.dragPanel.BackColor = System.Drawing.Color.Black;
            this.dragPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dragPanel.Controls.Add(this.pboxWindowMinimize);
            this.dragPanel.Controls.Add(this.btnStartStop);
            this.dragPanel.Controls.Add(this.pboxWindowClose);
            this.dragPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dragPanel.Location = new System.Drawing.Point(0, 0);
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Size = new System.Drawing.Size(150, 27);
            this.dragPanel.TabIndex = 5;
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.dragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // pboxWindowMinimize
            // 
            this.pboxWindowMinimize.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pboxWindowMinimize.BackColor = System.Drawing.SystemColors.Control;
            this.pboxWindowMinimize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pboxWindowMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pboxWindowMinimize.Image")));
            this.pboxWindowMinimize.Location = new System.Drawing.Point(97, -1);
            this.pboxWindowMinimize.Margin = new System.Windows.Forms.Padding(2);
            this.pboxWindowMinimize.Name = "pboxWindowMinimize";
            this.pboxWindowMinimize.Size = new System.Drawing.Size(25, 25);
            this.pboxWindowMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pboxWindowMinimize.TabIndex = 6;
            this.pboxWindowMinimize.TabStop = false;
            this.pboxWindowMinimize.Click += new System.EventHandler(this.WindowMinimize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(150, 27);
            this.Controls.Add(this.dragPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowClose)).EndInit();
            this.dragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWindowMinimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerMouseJiggler;
        private System.Windows.Forms.Button btnStartStop;
        private System.Windows.Forms.PictureBox pboxWindowClose;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.PictureBox pboxWindowMinimize;
    }
}

