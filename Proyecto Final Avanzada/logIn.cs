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
using Proyecto_Final_Avanzada.Doctor;
using Proyecto_Final_Avanzada.Enfermera;

namespace Proyecto_Final_Avanzada
{
    public partial class logIn : Form
    {
        public logIn()
        {
            InitializeComponent();
            timer1.Start();
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.setMode("loop",false);
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void logIn_Load(object sender, EventArgs e)
        {

        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbMiximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            try{
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                MySqlCommand codigo = new MySqlCommand();
                codigo.Connection = conectar;
                codigo.CommandText = ("select * from admin where user='" + tbUser.Text.Trim().ToString() + "' and password= '"+ tbPassword.Text.Trim().ToString()+"'");
                MySqlDataReader leer = codigo.ExecuteReader();



                if (leer.Read()) {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    Form d = new panelAdmin();
                    d.Show();

                    this.Hide();
                    return;
                  
                } else {

                     conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                    conectar.Open();
                     codigo = new MySqlCommand();
                    codigo.Connection = conectar;
                    codigo.CommandText = ("select nombres,apellidos from doctor where user='" + tbUser.Text.Trim().ToString() + "' and password= '" + tbPassword.Text.Trim().ToString() + "'");
                     leer = codigo.ExecuteReader();



                    if (leer.Read())
                    {
                        axWindowsMediaPlayer1.Ctlcontrols.pause();
                        Form d = new panelDoctor(leer.GetString(0),leer.GetString(1));
                        d.Show();

                        this.Hide();
                        return;

                    }
                    else
                    {
                         conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                        conectar.Open();
                         codigo = new MySqlCommand();
                        codigo.Connection = conectar;
                        codigo.CommandText = ("select * from enfermera where user='" + tbUser.Text.Trim().ToString() + "' and password= '" + tbPassword.Text.Trim().ToString() + "'");
                         leer = codigo.ExecuteReader();



                        if (leer.Read())
                        {
                            axWindowsMediaPlayer1.Ctlcontrols.pause();
                            Form d = new panelEnfermera();
                            
                            d.Show();

                            this.Hide();
                            return;

                        }
                        else
                        {
                            MessageBox.Show("No se encuentra el usuario", "Clinica");



                        }



                    }


                }
     

            }
            catch (Exception r) {
                MessageBox.Show(r.ToString(),"");
            }

         











        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity>.7) {
               
                this.timer1.Stop();

            }
            
            this.Opacity += .10;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
