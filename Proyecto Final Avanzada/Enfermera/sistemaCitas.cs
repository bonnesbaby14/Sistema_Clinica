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

namespace Proyecto_Final_Avanzada.Enfermera
{
    public partial class sistemaCitas : Form

    {
        MySqlConnection conectar;

        MySqlCommand codigo;
        String fecha;
        String[] arreglo,arreglo2;
        MySqlDataReader leer;
        public sistemaCitas()
        {
            InitializeComponent();
           



            //para doctores
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                lbMiembros.Items.Clear();
                codigo.CommandText = "select nombres, apellidos from doctor";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        lbDoctor.Items.Add(leer.GetString(0) + "-" + leer.GetString(1));
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }



            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                lbMiembros.Items.Clear();
                codigo.CommandText = "select nombres, apellidos from paciente";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        lbMiembros.Items.Add(leer.GetString(0) + "-" + leer.GetString(1));
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("insert into citas(nombres, apellidos,nombresD,apellidosD,fecha) values('" + arreglo[0] + "','" + arreglo[1] + "',  '" + arreglo2[0] + "','" + arreglo2[1] + "',     '" + monthCalendar1.SelectionStart.ToShortDateString() + "')");
                codigo.ExecuteNonQuery();
                MessageBox.Show("Alta de administrador exitosa", "Clínica");
            }  
            catch (Exception s) {
                MessageBox.Show(s.ToString(), "");
            }

}

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
          fecha=  monthCalendar1.SelectionStart.ToShortDateString();
        }

        private void lbMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
           arreglo= lbMiembros.SelectedItem.ToString().Split('-');
        }

        private void lbDoctor_SelectedIndexChanged(object sender, EventArgs e)
        {
            arreglo2 = lbDoctor.SelectedItem.ToString().Split('-');
        }
    }
}
