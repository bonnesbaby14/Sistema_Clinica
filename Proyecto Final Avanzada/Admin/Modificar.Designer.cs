namespace Proyecto_Final_Avanzada
{
    partial class Modificar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.paneltoForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMiembros);
            this.panel1.Controls.Add(this.cbTipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 455);
            this.panel1.TabIndex = 9;
            // 
            // lbMiembros
            // 
            this.lbMiembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(0, 33);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(222, 422);
            this.lbMiembros.TabIndex = 10;
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.lbMiembros_SelectedIndexChanged);
            // 
            // cbTipo
            // 
            this.cbTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "ENFERMERA",
            "DOCTOR",
            "ADMIN"});
            this.cbTipo.Location = new System.Drawing.Point(0, 0);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(222, 33);
            this.cbTipo.TabIndex = 9;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged_1);
            // 
            // paneltoForm
            // 
            this.paneltoForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.paneltoForm.Location = new System.Drawing.Point(228, 0);
            this.paneltoForm.Name = "paneltoForm";
            this.paneltoForm.Size = new System.Drawing.Size(698, 455);
            this.paneltoForm.TabIndex = 10;
            this.paneltoForm.Paint += new System.Windows.Forms.PaintEventHandler(this.paneltoForm_Paint);
            // 
            // Modificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.paneltoForm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Modificar";
            this.Text = "Modificar";
            this.Load += new System.EventHandler(this.Modificar_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Panel paneltoForm;
    }
}