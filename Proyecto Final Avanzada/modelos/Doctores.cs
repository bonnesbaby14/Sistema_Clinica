using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Avanzada
{
    class Doctores
    {
        int id;
        string cedula, nombre, apellidoM, apellidoP, especialidad;

        Doctores(string cedula, string nombre, string apellidoM, string apellidoP, string especialidad) {
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellidoM =apellidoM;
            this.apellidoP = apellidoP;
            this.especialidad = especialidad;
        }
        int getId() {
            return id;
        }
        string getCedula() {
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
