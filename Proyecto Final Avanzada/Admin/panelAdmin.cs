using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Proyecto_Final_Avanzada
{
    public partial class panelAdmin : Form
    {
        public panelAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {

            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new Alta() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new Baja() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            this.fondo.Tag = fh;
            fh.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.fondo.Controls.Count > 0)
            {
                this.fondo.Controls.RemoveAt(0);
            }

            Form fh = new Modificar() as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.fondo.Controls.Add(fh);
            this.fondo.Tag = fh;
            fh.Show();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void fondo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form d = new logIn();
            d.Show();
        }
    }
}
