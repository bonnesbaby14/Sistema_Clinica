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
    public partial class formLentes : Form
    {
        public formLentes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("insert into Lentes(marca, modelo,precio,cantidad) values('" + tbMarca.Text.Trim().ToString() + "','" + tbModelo.Text.Trim().ToString() + "','" + tbPrecio.Text.Trim().ToString() + "', '" + tbCantidad.Text.Trim().ToString() + "')");
                codigo.ExecuteNonQuery();
                MessageBox.Show("Alta de Lente exitosa", "Clínica");
                tbMarca.Text = "";
                tbModelo.Text = "";
                tbPrecio.Text = "";
                tbCantidad.Text = "";
               



            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "");
            }
        }
    }
}
