namespace Proyecto_Final_Avanzada
{
    partial class Baja
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
            this.cbTipo = new System.Windows.Forms.ComboBox();
            this.lbMiembros = new System.Windows.Forms.ListBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.cbTipo.Size = new System.Drawing.Size(926, 33);
            this.cbTipo.TabIndex = 1;
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // lbMiembros
            // 
            this.lbMiembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Location = new System.Drawing.Point(0, 33);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(926, 422);
            this.lbMiembros.TabIndex = 2;
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.lbMiembros_SelectedIndexChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnEliminar.Location = new System.Drawing.Point(0, 379);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(926, 76);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Baja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbMiembros);
            this.Controls.Add(this.cbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Baja";
            this.Text = "Baja";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.Button btnEliminar;
    }
}