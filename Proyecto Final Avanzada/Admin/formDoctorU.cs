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
    public partial class formDoctorU : Form
    {
        String nombres, apellidos, user, password, cedula, especialidad;

        private void formDoctorU_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public formDoctorU()
        {
            InitializeComponent();
        }
        public formDoctorU(String nombres, String apellidos, String user, String password, String cedula, String especialidad) {
            InitializeComponent();
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.user = user;
            this.password = password;
            this.cedula = cedula;
            this.especialidad = especialidad;

            tbNombres2.Text = nombres;
            tbApellidos.Text = apellidos;
            tbUser.Text = user;
            tbPassword.Text = password;
            tbCedula.Text = cedula;
            tbEspecialidad.Text = especialidad;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
            conectar.Open();
            MySqlCommand codigo = new MySqlCommand();
            codigo.Connection = conectar;
            codigo.CommandText = ("update doctor set nombres='" + tbNombres2.Text.Trim().ToString() + "', apellidos='" + tbApellidos.Text.Trim().ToString() + "',user='" + tbUser.Text.Trim().ToString() + "',password='" + tbPassword.Text.Trim().ToString() + "',cedula='" + tbCedula.Text.Trim().ToString() + "',especialidad='" + tbEspecialidad.Text.Trim().ToString() + "' where nombres='" + nombres + "' and apellidos='" + apellidos + "'");
            codigo.ExecuteNonQuery();
            MessageBox.Show("Modificación ded doctor exitosa", "Clínica");
            tbNombres2.Text = "";
            tbPassword.Text = "";
            tbApellidos.Text = "";
            tbUser.Text = "";
                tbCedula.Text = "";
                tbEspecialidad.Text = "";


            }
            catch (Exception r)
            {
                MessageBox.Show(r.ToString(), "");
            }
        }
    }
}
