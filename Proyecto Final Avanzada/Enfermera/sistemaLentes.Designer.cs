namespace Proyecto_Final_Avanzada.Enfermera
{
    partial class sistemaLentes
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbDescuento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCarrito = new System.Windows.Forms.ListBox();
            this.tbTarjeta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.tbDisponible = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.lbLentes = new System.Windows.Forms.ListBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbMiembros);
            this.panel1.Location = new System.Drawing.Point(33, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 201);
            this.panel1.TabIndex = 0;
            // 
            // lbMiembros
            // 
            this.lbMiembros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMiembros.FormattingEnabled = true;
            this.lbMiembros.Items.AddRange(new object[] {
            "uno",
            "dos",
            "tres"});
            this.lbMiembros.Location = new System.Drawing.Point(0, 0);
            this.lbMiembros.Name = "lbMiembros";
            this.lbMiembros.Size = new System.Drawing.Size(278, 201);
            this.lbMiembros.TabIndex = 12;
            this.lbMiembros.SelectedIndexChanged += new System.EventHandler(this.lbMiembros_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.tbSubtotal);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.tbTotal);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.tbCantidad);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tbDescuento);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lbCarrito);
            this.panel3.Controls.Add(this.tbTarjeta);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 243);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(926, 212);
            this.panel3.TabIndex = 2;
            // 
            // tbCantidad
            // 
            this.tbCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.tbCantidad.Location = new System.Drawing.Point(503, 37);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.ReadOnly = true;
            this.tbCantidad.Size = new System.Drawing.Size(200, 28);
            this.tbCantidad.TabIndex = 37;
            this.tbCantidad.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(498, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "CANTIDAD:";
            // 
            // tbDescuento
            // 
            this.tbDescuento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbDescuento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbDescuento.ForeColor = System.Drawing.SystemColors.Window;
            this.tbDescuento.Location = new System.Drawing.Point(503, 99);
            this.tbDescuento.Name = "tbDescuento";
            this.tbDescuento.ReadOnly = true;
            this.tbDescuento.Size = new System.Drawing.Size(200, 28);
            this.tbDescuento.TabIndex = 35;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(498, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 25);
            this.label6.TabIndex = 34;
            this.label6.Text = "DESCUENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(28, -2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "CARRITO:";
            // 
            // lbCarrito
            // 
            this.lbCarrito.FormattingEnabled = true;
            this.lbCarrito.Location = new System.Drawing.Point(33, 26);
            this.lbCarrito.Name = "lbCarrito";
            this.lbCarrito.Size = new System.Drawing.Size(456, 121);
            this.lbCarrito.TabIndex = 32;
            // 
            // tbTarjeta
            // 
            this.tbTarjeta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbTarjeta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.tbTarjeta.ForeColor = System.Drawing.SystemColors.Window;
            this.tbTarjeta.Location = new System.Drawing.Point(714, 99);
            this.tbTarjeta.Name = "tbTarjeta";
            this.tbTarjeta.ReadOnly = true;
            this.tbTarjeta.Size = new System.Drawing.Size(200, 22);
            this.tbTarjeta.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(709, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 28;
            this.label4.Text = "TARJETA:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button3.Location = new System.Drawing.Point(33, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(456, 32);
            this.button3.TabIndex = 21;
            this.button3.Text = "HACER PEDIDO";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "PACIENTE:";
            // 
            // tbMarca
            // 
            this.tbMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbMarca.ForeColor = System.Drawing.SystemColors.Window;
            this.tbMarca.Location = new System.Drawing.Point(643, 38);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.ReadOnly = true;
            this.tbMarca.Size = new System.Drawing.Size(252, 28);
            this.tbMarca.TabIndex = 33;
            // 
            // tbDisponible
            // 
            this.tbDisponible.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbDisponible.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbDisponible.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbDisponible.ForeColor = System.Drawing.SystemColors.Window;
            this.tbDisponible.Location = new System.Drawing.Point(643, 72);
            this.tbDisponible.Name = "tbDisponible";
            this.tbDisponible.ReadOnly = true;
            this.tbDisponible.Size = new System.Drawing.Size(252, 28);
            this.tbDisponible.TabIndex = 34;
            // 
            // tbPrecio
            // 
            this.tbPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbPrecio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbPrecio.ForeColor = System.Drawing.SystemColors.Window;
            this.tbPrecio.Location = new System.Drawing.Point(643, 106);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(252, 28);
            this.tbPrecio.TabIndex = 34;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(51)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button4.Location = new System.Drawing.Point(643, 140);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(252, 32);
            this.button4.TabIndex = 38;
            this.button4.Text = "AGREGAR AL CARRITO ";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbLentes
            // 
            this.lbLentes.FormattingEnabled = true;
            this.lbLentes.Location = new System.Drawing.Point(317, 38);
            this.lbLentes.Name = "lbLentes";
            this.lbLentes.Size = new System.Drawing.Size(320, 199);
            this.lbLentes.TabIndex = 39;
            this.lbLentes.SelectedIndexChanged += new System.EventHandler(this.lbLentes_SelectedIndexChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbTotal.ForeColor = System.Drawing.SystemColors.Window;
            this.tbTotal.Location = new System.Drawing.Point(503, 157);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(411, 28);
            this.tbTotal.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(498, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "TOTAL:";
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(95)))), ((int)(((byte)(105)))));
            this.tbSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.tbSubtotal.ForeColor = System.Drawing.SystemColors.Window;
            this.tbSubtotal.Location = new System.Drawing.Point(709, 37);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(200, 28);
            this.tbSubtotal.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(704, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "SUBTOTAL:";
            // 
            // sistemaLentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(107)))), ((int)(((byte)(112)))));
            this.ClientSize = new System.Drawing.Size(926, 455);
            this.Controls.Add(this.lbLentes);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDisponible);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "sistemaLentes";
            this.Text = "sistemaLentes";
            this.Load += new System.EventHandler(this.sistemaLentes_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lbMiembros;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox tbTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lbCarrito;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.TextBox tbDisponible;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ListBox lbLentes;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label1;
    }
}