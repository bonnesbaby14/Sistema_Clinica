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
    public partial class formAdminU : Form
    {
        String nombres, apellidos, user, password;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("update admin set nombres='" + tbNombres.Text.Trim().ToString() + "', apellidos='" + tbApellidos.Text.Trim().ToString() + "',user='" + tbUser.Text.Trim().ToString() + "',password='" + tbPassword.Text.Trim().ToString() + "' where nombres='"+nombres+"' and apellidos='"+apellidos+"'");
                codigo.ExecuteNonQuery();
                MessageBox.Show("Modificación de administrador exitosa", "Clínica");
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

        public formAdminU()
        {
            InitializeComponent();
        }

        public formAdminU(String nombres, String apellidos, String user, String password)
        {
            InitializeComponent();
          
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.user = user;
            this.password = password;


            tbNombres.Text = nombres;
            tbApellidos.Text = apellidos;
            tbUser.Text = user;
            tbPassword.Text = password;

        } 


        private void formAdminU_Load(object sender, EventArgs e)
        {

        }
    }
}
