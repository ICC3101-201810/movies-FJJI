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
        static List<Pelicula> peliculas = new List<Pelicula>();
        static List<Persona> personas = new List<Persona>();
        static List<Estudio> estudios = new List<Estudio>();
        static List<PeliculaActor> peliculaActores = new List<PeliculaActor>();
        static List<PeliculaProductor> peliculaProductores = new List<PeliculaProductor>();

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
            if (persona is Actor)
                personas.Add((Actor)persona);
            else if (persona is Productor)
                personas.Add((Productor)persona);
            else if (persona is Director)
                personas.Add((Director)persona);

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
