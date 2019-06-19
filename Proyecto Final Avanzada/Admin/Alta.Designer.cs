namespace Proyecto_Final_Avanzada
{
    partial class Alta
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
            this.panelform = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbTipo
            // 
            this.cbTipo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cbTipo.DisplayMember = "1";
            this.cbTipo.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipo.FormattingEnabled = true;
            this.cbTipo.Items.AddRange(new object[] {
            "ADMIN",
            "DOCTOR",
            "ENFERMERA"});
            this.cbTipo.Location = new System.Drawing.Point(0, 0);
            this.cbTipo.Name = "cbTipo";
            this.cbTipo.Size = new System.Drawing.Size(926, 33);
            this.cbTipo.Sorted = true;
            this.cbTipo.TabIndex = 0;
            this.cbTipo.ValueMember = "1";
            this.cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            // 
            // panelform
            // 
            this.panelform.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelform.Location = new System.Drawing.Point(0, 33);
            this.panelform.Name = "panelform";
            this.panelform.Size = new System.Drawing.Size(926, 422);
            this.panelform.TabIndex = 1;
            this.panelform.Paint += new System.Windows.Forms.PaintEventHandler(this.panelform_Paint);
            // 
            // Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.panelform);
            this.Controls.Add(this.cbTipo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Alta";
            this.Text = "Alta";
            this.Load += new System.EventHandler(this.Alta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbTipo;
        private System.Windows.Forms.Panel panelform;
    }
}