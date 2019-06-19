namespace Proyecto_Final_Avanzada
{
    partial class carga
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbClose = new System.Windows.Forms.PictureBox();
            this.pbMiximize = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label = new iTalk.iTalk_Label();
            this.bar = new iTalk.iTalk_ProgressBar();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiximize)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(132)))), ((int)(((byte)(212)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 264);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pbClose);
            this.panel2.Controls.Add(this.pbMiximize);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(241, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(413, 47);
            this.panel2.TabIndex = 8;
            // 
            // pbClose
            // 
            this.pbClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbClose.Image = global::Proyecto_Final_Avanzada.Properties.Resources.close_window_24;
            this.pbClose.Location = new System.Drawing.Point(395, 3);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(15, 15);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 1;
            this.pbClose.TabStop = false;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMiximize
            // 
            this.pbMiximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMiximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbMiximize.Image = global::Proyecto_Final_Avanzada.Properties.Resources.minimize_window_24;
            this.pbMiximize.Location = new System.Drawing.Point(374, 3);
            this.pbMiximize.Name = "pbMiximize";
            this.pbMiximize.Size = new System.Drawing.Size(15, 15);
            this.pbMiximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbMiximize.TabIndex = 0;
            this.pbMiximize.TabStop = false;
            this.pbMiximize.Click += new System.EventHandler(this.pbMiximize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Controls.Add(this.label);
            this.panel3.Controls.Add(this.bar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(241, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(413, 217);
            this.panel3.TabIndex = 9;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label.ForeColor = System.Drawing.Color.White;
            this.label.Location = new System.Drawing.Point(0, 135);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(410, 34);
            this.label.TabIndex = 1;
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label.UseCompatibleTextRendering = true;
            // 
            // bar
            // 
            this.bar.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.bar.Location = new System.Drawing.Point(133, 3);
            this.bar.Maximum = ((long)(100));
            this.bar.MinimumSize = new System.Drawing.Size(100, 100);
            this.bar.Name = "bar";
            this.bar.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(153)))), ((int)(((byte)(238)))));
            this.bar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(141)))), ((int)(((byte)(238)))));
            this.bar.ProgressShape = iTalk.iTalk_ProgressBar._ProgressShape.Round;
            this.bar.Size = new System.Drawing.Size(130, 130);
            this.bar.TabIndex = 0;
            this.bar.Text = "iTalk_ProgressBar1";
            this.bar.Value = ((long)(0));
            // 
            // carga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 264);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "carga";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "carga";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMiximize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private iTalk.iTalk_ProgressBar bar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbClose;
        private System.Windows.Forms.PictureBox pbMiximize;
        private System.Windows.Forms.Panel panel3;
        private iTalk.iTalk_Label label;
    }
}