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
    public partial class sistemaLentes : Form
    {

        MySqlConnection conectar;

        MySqlCommand codigo;
        String fecha;
        int cantidad=0, precio=0;

        String[] arreglo;
        String nombres , apellidos;
        MySqlDataReader leer;
        int contadorImage = 2;
       public sistemaLentes()
        {
            InitializeComponent();
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
                        lbMiembros.Items.Add(leer.GetString(0) + " " + leer.GetString(1));
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
             
                codigo.CommandText = "select modelo from lentes";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        lbLentes.Items.Add(leer.GetString(0));
                    }
                }
            }
            catch (Exception s)
            {
                MessageBox.Show(s.ToString(), "");
            }






        }


        private void lbMiembros_SelectedIndexChanged(object sender, EventArgs e)
        {
            String[] s={};

            try { s = lbMiembros.SelectedItem.ToString().Split(' '); } catch (Exception a) {
            }

            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;
            
                codigo.CommandText = "select tarjeta from paciente where nombres = '"+s[0]+ "' and apellidos = '" + s[1] + "'";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        tbTarjeta.Text =leer.GetString(0);
                        nombres = s[0];
                        apellidos = s[1];
                    }
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "");
            }






        }

        private void sistemaLentes_Load(object sender, EventArgs e)
        {

        }

        private void lbLentes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           String modelo="";


            try
            {
                modelo = lbLentes.SelectedItem.ToString();
            }
            catch (Exception a) {
            }
            
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = "select marca, cantidad,precio from lentes where modelo = '" +modelo+ "'";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        tbPrecio.Text = "Precio: "+leer.GetString(2);
                        tbMarca.Text= "Marca: " + leer.GetString(0);
                        tbDisponible.Text= "Cantidad: " + leer.GetString(1);
                    }
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = "insert into ventas(fecha,tarjeta,nombres,apellidos,estado) values ( '"+(DateTime.Now).ToShortDateString()+"','"+tbTarjeta.Text+ "','" + nombres + "','" + apellidos + "','iniciada'  ); ";
                codigo.ExecuteNonQuery();
                MessageBox.Show("Venta registrada","Clinica");
                lbLentes.SelectedItem = null;
             
                lbCarrito.Items.Clear();

                tbMarca.Text = "";
                tbDescuento.Text = "";
                tbCantidad.Text = "";
                tbDisponible.Text = "";
                tbTarjeta.Text = "";
                tbTotal.Text = "";
                tbSubtotal.Text = "";
                tbPrecio.Text = "";

            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            double descuento = 0;
            double precio=0;
            int cantidadp=0;
            String modelo = "";
            if (Convert.ToInt16(tbCantidad.Text)>4)
            {
                descuento = .10;
                tbDescuento.Text = "10%";
            }
            if (Convert.ToInt16(tbCantidad.Text) > 9)
            {
                descuento = .120;
                tbDescuento.Text = "20%";
            }
            if (Convert.ToInt16(tbCantidad.Text) > 14)
            {
                descuento = .25;
                tbDescuento.Text = "25%";
            }


            try
            {
                modelo = lbLentes.SelectedItem.ToString();
            }
            catch (Exception a)
            {
            }
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = "select marca, cantidad,precio from lentes where modelo = '" + modelo + "'";
                MySqlDataReader leer = codigo.ExecuteReader();
                if (leer.HasRows)
                {
                    while (leer.Read())
                    {
                        cantidadp= Convert.ToInt32(leer.GetString(1));
                        precio = Convert.ToInt16(leer.GetString(2)); 

                    }
                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "");
            }
            cantidadp--;
            try
            {
                modelo = lbLentes.SelectedItem.ToString();
            }
            catch (Exception a)
            {
            }
            try
            {
                conectar = new MySqlConnection("server=127.0.0.1; database=clinica; Uid=root; pwd=''");
                conectar.Open();
                codigo = new MySqlCommand();
                codigo.Connection = conectar;

                codigo.CommandText = "update lentes set cantidad='"+cantidadp.ToString()+"' where modelo = '" + modelo + "'";
                codigo.ExecuteNonQuery();
              
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "");
            }


            tbDisponible.Text = "Cantidad: "+cantidadp.ToString();
            cantidad++;
            tbCantidad.Text = cantidad.ToString();
            lbCarrito.Items.Add(lbLentes.SelectedItem.ToString());
            double total = 0;
            try
            {
                total = Convert.ToInt16(tbTotal.Text);
            }
            catch (Exception d) {
            }

            total = total + precio;
            tbSubtotal.Text= total.ToString();
            total = total - (total*descuento);
            tbTotal.Text = total.ToString();
            



        }
    }
}
