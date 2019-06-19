using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Avanzada.Doctor
{
    public partial class panelDoctor : Form
    {
        String nombres, apellidos;
        public panelDoctor()
        {
            InitializeComponent();
        }
        public panelDoctor(String _nombres, String _apellidos)
        {
            InitializeComponent();
            this.nombres = _nombres;
            this.apellidos = _apellidos;
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

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }
            Form fh = new SistemaCitas(this.nombres,this.apellidos);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
