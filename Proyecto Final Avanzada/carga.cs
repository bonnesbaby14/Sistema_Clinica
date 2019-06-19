using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_Final_Avanzada
{
    public partial class carga : Form
    {
        public carga()
        {
            InitializeComponent();
            label.Text = "Cargando sistema...";
            this.timer1.Start();
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.bar.Increment(1);
            if (bar.Value==100) {
                label.Text = "Listo...";
                Thread.Sleep(1000);
                timer1.Stop();
                
                this.Hide();
                Form f = new logIn();
                f.Show();
                
            }
            if (bar.Value == 10)
            {
                label.Text = "Conectado con el servidor...";
            }
            if (bar.Value == 20)
            {
                label.Text = "Conectado con base de datos...";
            }
            if (bar.Value == 30)
            {
                label.Text = "Descargando complementos...";
            }
            if (bar.Value == 40)
            {
                label.Text = "Buscando Actualizaciones...";
            }
            if (bar.Value == 50)
            {
                label.Text = "Cargando Usuarios...";
            }
            if (bar.Value ==80)
            {
                label.Text = "Preparando todo...";
            }
            
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMiximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
