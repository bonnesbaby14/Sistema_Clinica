using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Avanzada
{
    class Lentes
    {
        int id;
        float precio;
        string marca, modelo;

        Lentes(float precio, string marca, string modelo) {

            this.precio = precio;
            this.marca = marca;
            this.modelo = modelo;
        }



        int getId()
        {
            return id;
        }
        string getMarca()
        {
            return marca;
        }
        string getModelo()
        {
            return modelo;
        }

        float getPrecio()
        {
            return precio;
        }



    }
}
