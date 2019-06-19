using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_Avanzada
{
    public partial class Modificar : Form
    {
        int bandera=0;
        MySqlConnection conectar;

        MySqlCommand codigo;
        MySqlDataReader leer;


    
        private void lbMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbMiembros.SelectedItems==null) {
                return;
            }
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                String[] datos = lbMiembros.SelectedItem.ToString().Split(' ');

                if (bandera == 2)//enfermera
                {


                    codigo.CommandText = "select nombres, apellidos, user, password,cedula from enfermera where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'   ";
                    leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        if (this.paneltoForm.Controls.Count > 0)
                        {
                            this.paneltoForm.Controls.RemoveAt(0);
                        }
                        leer.Read();
                        Form fh = new formEnfermeraU(leer.GetString(0), leer.GetString(1), leer.GetString(2), leer.GetString(3), leer.GetString(4));
                        fh.TopLevel = false;
                        fh.Dock = DockStyle.Fill;
                        this.paneltoForm.Controls.Add(fh);
                        this.paneltoForm.Tag = fh;
                        fh.Show();




                    }
                }
                if (bandera == 3)//doctor
                {
                    codigo.CommandText = "select nombres, apellidos, user, password,cedula,especialidad from doctor where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'   ";
                    leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        if (this.paneltoForm.Controls.Count > 0)
                        {
                            this.paneltoForm.Controls.RemoveAt(0);
                        }
                        leer.Read();
                        Form fh = new formDoctorU(leer.GetString(0), leer.GetString(1), leer.GetString(2), leer.GetString(3), leer.GetString(4), leer.GetString(5));
                        fh.TopLevel = false;
                        fh.Dock = DockStyle.Fill;
                        this.paneltoForm.Controls.Add(fh);
                        this.paneltoForm.Tag = fh;
                        fh.Show();
                    }



                }

                if (bandera == 5)//admin
                {

                    codigo.CommandText = "select nombres, apellidos, user, password from admin where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'   ";
                    leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        if (this.paneltoForm.Controls.Count > 0)
                        {
                            this.paneltoForm.Controls.RemoveAt(0);
                        }
                        leer.Read();
                        Form fh = new formAdminU(leer.GetString(0), leer.GetString(1), leer.GetString(2), leer.GetString(3));
                        fh.TopLevel = false;
                        fh.Dock = DockStyle.Fill;
                        this.paneltoForm.Controls.Add(fh);
                        this.paneltoForm.Tag = fh;
                        fh.Show();


                    }
                }
            }
            catch (Exception d)
            {
                MessageBox.Show(d.ToString(), "");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void cbTipo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
        conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
               codigo = new MySqlCommand();
                codigo.Connection = conectar;
                
               



           


              

            
            if (cbTipo.SelectedItem.ToString() == "ENFERMERA")
            {
                bandera = 2;
                    lbMiembros.Items.Clear();
                    codigo.CommandText = "select nombres, apellidos from enfermera";
                    MySqlDataReader leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            lbMiembros.Items.Add(leer.GetString(0) + " " + leer.GetString(1));
                        }
                    }
                }
            if (cbTipo.SelectedItem.ToString() == "DOCTOR")
            {
                bandera = 3;
                    lbMiembros.Items.Clear();
                    codigo.CommandText = "select nombres, apellidos from doctor";
                    MySqlDataReader leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            lbMiembros.Items.Add(leer.GetString(0) + " " + leer.GetString(1));
                        }
                    }
                }

            if (cbTipo.SelectedItem.ToString() == "ADMIN")
            {
                bandera = 5;
                    lbMiembros.Items.Clear();
                    codigo.CommandText = "select nombres, apellidos from admin";
                    MySqlDataReader leer = codigo.ExecuteReader();
                    if (leer.HasRows)
                    {
                        while (leer.Read())
                        {
                            lbMiembros.Items.Add(leer.GetString(0) + " " + leer.GetString(1));
                        }
                    }
                }
            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "");
            }

        }


        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void paneltoForm_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
