namespace Proyecto_Final_Avanzada.Enfermera
{
    partial class sistemaCitas
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbDoctor = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(541, 108);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(109, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(680, 32);
            this.button1.TabIndex = 20;
            this.button1.Text = "AGENDAR CITAS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMiembros);
            this.panel1.Location = new System.Drawing.Point(109, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(186, 162);
            this.panel1.TabIndex = 21;
            // 
            // lbMiembros
            // 
            this.lbMiembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(0, 0);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(186, 162);
            this.lbMiembros.TabIndex = 11;
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.lbMiembros_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbDoctor);
            this.panel2.Location = new System.Drawing.Point(323, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(186, 162);
            this.panel2.TabIndex = 22;
            // 
            // lbDoctor
            // 
            this.lbDoctor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbDoctor.FormattingEnabled = true;
            this.lbDoctor.Location = new System.Drawing.Point(0, 0);
            this.lbDoctor.Name = "lbDoctor";
            this.lbDoctor.Size = new System.Drawing.Size(186, 162);
            this.lbDoctor.TabIndex = 11;
            this.lbDoctor.SelectedIndexChanged += new System.EventHandler(this.lbDoctor_SelectedIndexChanged);
            // 
            // sistemaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthCalendar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sistemaCitas";
            this.ShowIcon = false;
            this.Text = "sistemaCitas";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbDoctor;
    }
}