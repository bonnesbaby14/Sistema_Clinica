using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Final_Avanzada
{
    public partial class Baja : Form
    {
        MySqlConnection conectar;
        int bandera = 0;

        MySqlCommand codigo;
        MySqlDataReader leer;


        public Baja()
        {
            InitializeComponent();
        }

        private void cbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
            conectar.Open();
            codigo = new MySqlCommand();
            codigo.Connection = conectar;


            if (cbTipo.SelectedItem.ToString() == "DOCTOR")
            {
                bandera = 1;
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
            if (cbTipo.SelectedItem.ToString() == "ADMIN")
            {
                bandera = 3;

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

        private void lbMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (bandera==1) {//docto
                try
                {
                    String[] datos = lbMiembros.SelectedItem.ToString().Split(' ');
                    conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                    conectar.Open();
                    codigo = new MySqlCommand();
                    codigo.Connection = conectar;
                    codigo.CommandText = ("delete from doctor where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'");
                    codigo.ExecuteNonQuery();
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
                    MessageBox.Show("Baja de doctor exitosa", "Clínica");
                

                }
                catch (Exception r)
                {
                    MessageBox.Show(r.ToString(), "");
                }



            }

            if (bandera == 2)//enfermera
            {
                try
                {
                    String[] datos = lbMiembros.SelectedItem.ToString().Split(' ');
                    conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                    conectar.Open();
                    codigo = new MySqlCommand();
                    codigo.Connection = conectar;
                    codigo.CommandText = ("delete from enfermera where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'");
                    codigo.ExecuteNonQuery();
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
                    MessageBox.Show("Baja de enfermera exitosa", "Clínica");


                }
                catch (Exception r)
                {
                    MessageBox.Show(r.ToString(), "");
                }
            }

            if (bandera == 3)//admin
            {
                try
                {
                    String[] datos = lbMiembros.SelectedItem.ToString().Split(' ');
                    conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                    conectar.Open();
                    codigo = new MySqlCommand();
                    codigo.Connection = conectar;
                    codigo.CommandText = ("delete from admin where nombres='" + datos[0] + "' and apellidos='" + datos[1] + "'");
                    codigo.ExecuteNonQuery();
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
                    MessageBox.Show("Baja de administrador exitosa", "Clínica");


                }
                catch (Exception r)
                {
                    MessageBox.Show(r.ToString(), "");
                }
            }



        }
    }
}
