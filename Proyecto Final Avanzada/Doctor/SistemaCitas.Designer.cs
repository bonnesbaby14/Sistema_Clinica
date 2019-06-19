namespace Proyecto_Final_Avanzada
{
    partial class SistemaCitas
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbObservaciones = new System.Windows.Forms.TextBox();
            this.tbDiagnostico = new System.Windows.Forms.TextBox();
            this.diagnostico = new System.Windows.Forms.Label();
            this.tbReceta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tbPaciente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbPacientes = new System.Windows.Forms.ListBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(361, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Observaciones";
            // 
            // tbObservaciones
            // 
            this.tbObservaciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbObservaciones.ForeColor = System.Drawing.Color.White;
            this.tbObservaciones.Location = new System.Drawing.Point(364, 279);
            this.tbObservaciones.Multiline = true;
            this.tbObservaciones.Name = "tbObservaciones";
            this.tbObservaciones.Size = new System.Drawing.Size(550, 114);
            this.tbObservaciones.TabIndex = 3;
            // 
            // tbDiagnostico
            // 
            this.tbDiagnostico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbDiagnostico.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDiagnostico.ForeColor = System.Drawing.Color.White;
            this.tbDiagnostico.Location = new System.Drawing.Point(364, 192);
            this.tbDiagnostico.Multiline = true;
            this.tbDiagnostico.Name = "tbDiagnostico";
            this.tbDiagnostico.Size = new System.Drawing.Size(550, 68);
            this.tbDiagnostico.TabIndex = 5;
            // 
            // diagnostico
            // 
            this.diagnostico.AutoSize = true;
            this.diagnostico.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.diagnostico.Location = new System.Drawing.Point(361, 176);
            this.diagnostico.Name = "diagnostico";
            this.diagnostico.Size = new System.Drawing.Size(63, 13);
            this.diagnostico.TabIndex = 4;
            this.diagnostico.Text = "Diagnostico";
            // 
            // tbReceta
            // 
            this.tbReceta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbReceta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbReceta.ForeColor = System.Drawing.Color.White;
            this.tbReceta.Location = new System.Drawing.Point(364, 95);
            this.tbReceta.Multiline = true;
            this.tbReceta.Name = "tbReceta";
            this.tbReceta.Size = new System.Drawing.Size(550, 68);
            this.tbReceta.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(361, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Receta Medica";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnActualizar.FlatAppearance.BorderSize = 0;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(364, 399);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(550, 40);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "Terminar Consulta";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tbPaciente
            // 
            this.tbPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPaciente.ForeColor = System.Drawing.Color.White;
            this.tbPaciente.Location = new System.Drawing.Point(364, 36);
            this.tbPaciente.Name = "tbPaciente";
            this.tbPaciente.ReadOnly = true;
            this.tbPaciente.Size = new System.Drawing.Size(550, 13);
            this.tbPaciente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(361, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Paciente";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbPacientes
            // 
            this.lbPacientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.lbPacientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbPacientes.ForeColor = System.Drawing.SystemColors.Window;
            this.lbPacientes.FormattingEnabled = true;
            this.lbPacientes.Location = new System.Drawing.Point(12, 12);
            this.lbPacientes.Name = "lbPacientes";
            this.lbPacientes.Size = new System.Drawing.Size(343, 377);
            this.lbPacientes.TabIndex = 12;
            this.lbPacientes.SelectedIndexChanged += new System.EventHandler(this.lbPacientes_SelectedIndexChanged);
            // 
            // btnHistorial
            // 
            this.btnHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorial.FlatAppearance.BorderSize = 0;
            this.btnHistorial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHistorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHistorial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHistorial.Location = new System.Drawing.Point(12, 399);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(343, 40);
            this.btnHistorial.TabIndex = 13;
            this.btnHistorial.Text = "Historial Medico";
            this.btnHistorial.UseVisualStyleBackColor = false;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // SistemaCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.lbPacientes);
            this.Controls.Add(this.tbPaciente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbReceta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDiagnostico);
            this.Controls.Add(this.diagnostico);
            this.Controls.Add(this.tbObservaciones);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SistemaCitas";
            this.Text = "Sistema Doctor";
            this.Load += new System.EventHandler(this.SistemaDoctor_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbObservaciones;
        private System.Windows.Forms.TextBox tbDiagnostico;
        private System.Windows.Forms.Label diagnostico;
        private System.Windows.Forms.TextBox tbReceta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TextBox tbPaciente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbPacientes;
        private System.Windows.Forms.Button btnHistorial;
    }
}