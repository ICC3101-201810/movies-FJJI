using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    abstract class Persona
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento { get; set; }
        string biografia { get; set; }

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return nombre
        }
        public string GetApellido()
        {
            return apellido;
        }
    }
}