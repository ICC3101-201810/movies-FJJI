using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalLab
{
    [Serializable()]
    class PeliculaActor
    {
        Pelicula pelicula;
        List<Actor> actores;
        Director director;

        public PeliculaActor(Pelicula pelicula, Director director)
        {
            this.pelicula = pelicula;
            this.director = director;
        }

        public void AddActor(Actor actor)
        {
            foreach (Actor a in actores)
            {
                if (a == actor)
                    return;
            }
            actores.Add(actor);
        }

    }
}