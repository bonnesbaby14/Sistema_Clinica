using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final_Avanzada
{
    public partial class Alta : Form
    {
        Label lbNombre, lbApellidoP, lbApellidoM, lbEspecializad, lbCedula;
        TextBox tbNombre, tbApellidoP, tbApellidoM, tbEspecializad, tbCedula;

        private void panelform_Paint(object sender, PaintEventArgs e)
        {

        }

        Button btnRegistar;
        public Alta()
        {
            InitializeComponent();

        }

        private void Alta_Load(object sender, EventArgs e)
        {
          
        }
        void Registar(Object sender, EventArgs e) {
            //CRae objetos y base de datos
       
        }
        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

 
            if (cbTipo.SelectedItem.ToString() == "DOCTOR")
            {



                if (this.panelform.Controls.Count > 0)
                {
                    this.panelform.Controls.RemoveAt(0);
                }
                Form fh = new formDoctor();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelform.Controls.Add(fh);
                this.panelform.Tag = fh;
                fh.Show();

            }
            if (cbTipo.SelectedItem.ToString() == "ADMIN")
            {



                if (this.panelform.Controls.Count > 0)
                {
                    this.panelform.Controls.RemoveAt(0);
                }
                Form fh = new formAdmin();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelform.Controls.Add(fh);
                this.panelform.Tag = fh;
                fh.Show();

            }
            if (cbTipo.SelectedItem.ToString() == "ENFERMERA")
                {


                if (this.panelform.Controls.Count > 0)
                {
                    this.panelform.Controls.RemoveAt(0);
                }
                Form fh = new formEnfermera();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelform.Controls.Add(fh);
                this.panelform.Tag = fh;
                fh.Show();





            }

            if (cbTipo.SelectedItem.ToString() == "PACIENTE") {

                if (this.panelform.Controls.Count > 0)
                {
                    this.panelform.Controls.RemoveAt(0);
                }
                Form fh = new formAdmin();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelform.Controls.Add(fh);
                this.panelform.Tag = fh;
                fh.Show();

            }

            if (cbTipo.SelectedItem.ToString() == "LENTES")
            {

                if (this.panelform.Controls.Count > 0)
                {
                    this.panelform.Controls.RemoveAt(0);
                }
                Form fh = new formLentes();
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.panelform.Controls.Add(fh);
                this.panelform.Tag = fh;
                fh.Show();

            }

        }
        }
    }

