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
    public partial class SistemaCitas : Form
    {
        MySqlConnection conectar;

        MySqlCommand codigo;
        String fecha;
        String[] arreglo, arreglo2;
        MySqlDataReader leer;
        String nombres, apellidos;
      
        public SistemaCitas(String _nombres, String _apellidos)
        {
            InitializeComponent();
            this.nombres = _nombres;
            this.apellidos = _apellidos;
          
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                lbPacientes.Items.Clear();
                codigo.CommandText = "select nombres, apellidos from paciente";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        lbPacientes.Items.Add(leer.GetString(0) + "-" + leer.GetString(1));
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }
        }
        public SistemaCitas()
        {
            InitializeComponent();
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                lbPacientes.Items.Clear();
                codigo.CommandText = "select nombres, apellidos from paciente";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        lbPacientes.Items.Add(leer.GetString(0) + "-" + leer.GetString(1));
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }
        }

     
      

        private void SistemaDoctor_Load_1(object sender, EventArgs e)
        {


        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("insert into consulta(nombresP,apellidosP,nombresD,apellidosD,receta,diagnostico,observaciones,fecha) values('" + arreglo[0] + "', '" + arreglo[1]+"', '" + this.nombres+"', '" +this.apellidos +"', '" + tbReceta.Text+"', '" +tbDiagnostico.Text +"', '" +tbObservaciones.Text + "', '" +DateTime.Now.ToShortDateString() +"')");
                codigo.ExecuteNonQuery();
                tbDiagnostico.Text = "";
                tbObservaciones.Text = "";
                tbPaciente.Text = "";
                tbReceta.Text = "";

                MessageBox.Show("Alta de consulta exitosa", "Clínica");



               




            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "");
            }




        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            String historial="Historial Medico: \n \n";

            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = "select fecha, nombresD,apellidosD, receta, diagnostico, observaciones from consulta where nombresD='"+this.nombres+"' and apellidosD='"+this.apellidos+"' and nombresP='"+arreglo[0]+"' and apellidosP='"+arreglo[1]+"' ";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {

                        historial = "\n" + historial + "fecha: "+leer.GetString(0)+" "+"\n"+ "Docotor: "+leer.GetString(1)+ " "+leer.GetString(2)+ " "+"\n"+ "Receta: "+leer.GetString(3)+ ""+"\n"+ "Diagnostico: "+leer.GetString(4)+ ""+"\n"+ "Observaciones: "+leer.GetString(5)+" \n \n";
                    }
                    MessageBox.Show(historial,"");
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lbPacientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                arreglo = lbPacientes.SelectedItem.ToString().Split('-');
            }
            catch (Exception a) {
            }
                tbPaciente.Text = lbPacientes.SelectedItem.ToString();



        }
    }
}
