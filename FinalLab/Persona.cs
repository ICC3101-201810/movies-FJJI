using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace FinalLab
{
    [Serializable()]
    abstract class Persona
    {
        string nombre;
        string apellido;
        DateTime fechaNacimiento;
        CultureInfo MyCultureInfo = new CultureInfo("es-CL");
        string biografia;

        public Persona(string nombre, string apellido)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public virtual void SetFechaNacimiento(string MyString)
        { 
            fechaNacimiento = DateTime.Parse(MyString, MyCultureInfo);
        }
        public void SetBiografia(string bio)
        {
            biografia = bio;
        }
    }
}