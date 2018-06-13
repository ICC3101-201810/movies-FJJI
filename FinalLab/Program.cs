using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLab
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Director director = new Director("Anthony", "Rousso");
            BaseDeDatos.AddPersona(director);
            Pelicula ave = new Pelicula("Avengers: Infinity War");
            foreach (Persona per in BaseDeDatos.GetPersonas())
            {
                if (per.GetApellido() == "Rousso")
                {
                    PeliculaActor peli = new PeliculaActor(ave, (Director)per);
                    BaseDeDatos.AddPeliculaActor(peli);
                }
            }
            serial.Cargar();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    
}
