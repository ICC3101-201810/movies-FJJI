using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    [Serializable()]
    class Estudio
    {
        string nombre;
        string direccion;
        DateTime fechaApertura;

        public Estudio(string _nombre)
        {
            nombre = _nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetDireccion()
        {
            return direccion;
        }
    }
}