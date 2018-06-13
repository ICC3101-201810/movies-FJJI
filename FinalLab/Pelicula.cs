using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    [Serializable()]
    class Pelicula
    {
        string nombre;
        Director director;
        DateTime fechaEstreno;
        string Descripcion;
        int presupuesto;
        Estudio estudio;

        public Pelicula(string nombre)
        {
            this.nombre = nombre;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public Director GetDirector()
        {
            return director;
        }
        public DateTime GetFerchaEstreno()
        {
            return fechaEstreno;
        }
        public string GetDescripcion()
        {
            return Descripcion;
        }
        public int GetPresupuesto()
        {
            return presupuesto;
        }
        public Estudio GetEstudio()
        {
            return estudio;
        }
    }
}
