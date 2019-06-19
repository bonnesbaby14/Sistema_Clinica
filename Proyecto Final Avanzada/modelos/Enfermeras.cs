using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Avanzada
{
    class Enfermeras
    {
        int id;
        string cedula, nombre, apellidoM, apellidoP, especialidad;
        Enfermeras(string cedula, string nombre, string apellidoM, string apellidoP)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidoM = apellidoM;
            this.apellidoP = apellidoP;
 
        }


        int getId()
        {
            return id;
        }
        string getCedula()
        {
            return cedula;
        }
        string getNombre()
        {
            return nombre;
        }
        string getApellidoM()
        {
            return apellidoM;
        }
        string getApellidoP()
        {
            return apellidoP;
        }
        string getEspecialidad()
        {
            return especialidad;
        }

    }
}
