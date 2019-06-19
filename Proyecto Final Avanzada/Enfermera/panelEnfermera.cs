using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Avanzada.Enfermera
{
    public partial class panelEnfermera : Form
    {
        public panelEnfermera()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (menu.Width == 200)
            {
                menu.Width = 74;
            }
            else
            {
                menu.Width = 200;
            }
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void pbMiximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new tbs() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            fh.Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new sistemaCitas() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new sistemaLentes() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            fh.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new sistemaVentas() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            fh.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form d = new logIn();
            d.Show();
        }
    }
}
