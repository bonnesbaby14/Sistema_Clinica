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
    public partial class tbs : Form
    {
        public tbs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("insert into paciente(nombres, apellidos,tarjeta,vigencia,cvc) values('" + tbNombres.Text.Trim().ToString() + "','" + tbApellidos.Text.Trim().ToString() + "','" + tbTarjeta.Text.Trim().ToString() + "', '" + tbVigencia.Text.Trim().ToString() + "', '" + tbCVC.Text.Trim().ToString() + "')");
            codigo.ExecuteNonQuery();
            MessageBox.Show("Alta de Enfermera exitosa", "Clínica");
            tbNombres.Text = "";
            tbTarjeta.Text = "";
            tbApellidos.Text = "";
            tbVigencia.Text = "";
            tbCVC.Text = "";
        }

        private void tbTarjeta_TextChanged(object sender, EventArgs e)
        {
            if (tbTarjeta.Text == "")
            {
                return;
            }
            else {
                if (tbTarjeta.Text.ToString().Substring(0, 1).Equals("3"))
                {
                    tbTipo.Text = "American Express";
                }
                else if (tbTarjeta.Text.ToString().Substring(0, 1).Equals("4"))
                {
                    tbTipo.Text = "Visa";
                }
                else if (tbTarjeta.Text.ToString().Substring(0, 1).Equals("5"))
                {
                    tbTipo.Text = "MasterCard";
                }
                else {
                    tbTipo.Text = "Desconocida";
                }
            }
        }
    }
}
