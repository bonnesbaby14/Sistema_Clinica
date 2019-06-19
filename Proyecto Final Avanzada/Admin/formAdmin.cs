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
    public partial class formAdmin : Form
    {
        public formAdmin()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("insert into admin(nombres, apellidos,user,password) values('"+tbNombres.Text.Trim().ToString()+ "','"+tbApellidos.Text.Trim().ToString()+ "','"+tbUser.Text.Trim().ToString()+ "', '"+tbPassword.Text.Trim().ToString()+"')");
                codigo.ExecuteNonQuery();
                MessageBox.Show("Alta de administrador exitosa", "Clínica");
                tbNombres.Text = "";
                tbPassword.Text = "";
                tbApellidos.Text = "";
                tbUser.Text = "";



            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "");
            }


        }
    }
}
