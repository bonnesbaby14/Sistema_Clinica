using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Avanzada
{
    class Pacientes
    {
        int id;
        string observaciones, recetas, diagnosticos, nombre, apellidoP, apellidoM;
        Lentes lente;

        Pacientes(string nombre, string apellidoP, string apellidoM) {
            this.nombre = nombre;
            this.apellidoM = apellidoM;
            this.apellidoP = apellidoP;
        }


        int getId()
        {
            return id;
        }
        string getObservaciones()
        {
            return observaciones;
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
        string getDiagnosttico()
        {
            return diagnosticos;
        }

        string getReceta()
        {
            return recetas;
        }

        Lentes getLente()
        {
            return lente;
        }



   
        void setObservaciones(string observacione)
        {
            this.observaciones=this.observaciones+"\n"+observacione;
        }
        
        
        void setDiagnosttico(string diagnostico)
        {
            this.diagnosticos = this.diagnosticos + "\n" + diagnostico;
       }

        void setReceta(string receta)
        {
            this.recetas = this.recetas + "\n" + receta;
        }

        void setLente(Lentes lente)
        {
            this.lente = lente;
        }





    }


}
