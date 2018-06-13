using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalLab
{
    static class serial
    {
        public static void Cargar()
        {
            try
            {

                using (Stream stream = File.Open(@"..\..\data\DataPeliculas.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Pelicula> peliculas = (List<Pelicula>)bin.Deserialize(stream);

                    foreach (Pelicula peli in peliculas)
                    {
                        BaseDeDatos.AddPelicula(peli);
                    }
                }

                using (Stream stream = File.Open(@"..\..\data\DataPersonas.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    List<Persona> personas = (List<Persona>)bin.Deserialize(stream);
                    foreach (Persona person in personas)
                    {
                        BaseDeDatos.AddPersona(person);
                    }


                }
                using (Stream stream = File.Open(@"..\..\data\DataEstudios.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<Estudio> estudios = (List<Estudio>)bin.Deserialize(stream);
                    foreach (Estudio estudio in estudios)
                    {
                        BaseDeDatos.AddEstudio(estudio);
                    }
                }
                using (Stream stream = File.Open(@"..\..\data\DataPeliculaActores.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<PeliculaActor> peliculaActores = (List<PeliculaActor>)bin.Deserialize(stream);
                    foreach (PeliculaActor peliculaActor in peliculaActores)
                    {
                        BaseDeDatos.AddPeliculaActor(peliculaActor);
                    }
                }
                using (Stream stream = File.Open(@"..\..\data\DataPeliculaProductores.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    List<PeliculaProductor> peliculaProductores = (List<PeliculaProductor>)bin.Deserialize(stream);
                    foreach (PeliculaProductor peliculaProductor in peliculaProductores)
                    {
                        BaseDeDatos.AddPeliculaProductor(peliculaProductor);
                    }
                }
            }
            catch (Exception)
            {

            }
            // datos agregados a intancia actual
        }

        public static void Guardar()
        {
            // serializacion para guardado de datos 
            //using (Stream stream = File.Open(@"..\data\DataAlumno.bin", FileMode.Create));
            using (Stream stream = File.Open(@"..\..\data\DataPeliculaActores.bin", FileMode.Create))
            {
                List<PeliculaActor> peliculaActores = BaseDeDatos.GetPeliculaActores();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, peliculaActores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculaProductores.bin", FileMode.Create))
            {
                List<PeliculaProductor> peliculaProductores = BaseDeDatos.GetPeliculaProductores();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, peliculaProductores);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPeliculas.bin", FileMode.Create))
            {
                List<Pelicula> peliculas = BaseDeDatos.GetPeliculas();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, peliculas);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataPersonas.bin", FileMode.Create))
            {
                List<Persona> personas = BaseDeDatos.GetPersonas();

                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, personas);
                stream.Close();
            }
            using (Stream stream = File.Open(@"..\..\data\DataEstudios.bin", FileMode.Create))
            {
                List<Estudio> estudios = BaseDeDatos.GetEstudios();
                BinaryFormatter bin = new BinaryFormatter();
                bin.Serialize(stream, estudios);
                stream.Close();
            }
            //datos guardados 
        }
    }
}
