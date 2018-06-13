using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    [Serializable()]
    public static class BaseDeDatos
    {
        static List<Pelicula> peliculas;
        static List<Persona> personas;
        static List<Estudio> estudios;
        static List<PeliculaActor> peliculaActores;
        static List<PeliculaProductor> peliculaProductores;

        internal static List<Pelicula> GetPeliculas()
        {
            return peliculas;
        }
        internal static List<Persona> GetPersonas()
        {
            return personas;
        }
        internal static List<Estudio> GetEstudios()
        {
            return estudios;
        }
        internal static List<PeliculaActor> GetPeliculaActores()
        {
            return peliculaActores;
        }
        internal static List<PeliculaProductor> GetPeliculaProductores()
        {
            return peliculaProductores;
        }
        internal static void AddPelicula(Pelicula pelicula)
        {
            peliculas.Add(pelicula);
        }
        internal static void AddPersona(Persona persona)
        {
            personas.Add(persona);
        }
        internal static void AddEstudio(Estudio estudio)
        {
            estudios.Add(estudio);
        }
        internal static void AddPeliculaActor (PeliculaActor peliculaActor)
        {
            peliculaActores.Add(peliculaActor);
        }
        internal static void AddPeliculaProductor(PeliculaProductor peliculaProductor)
        {
            peliculaProductores.Add(peliculaProductor);
        }

    }
}
