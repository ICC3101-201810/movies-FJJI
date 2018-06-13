using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalLab
{
    public partial class Form2 : Form
    {
        int valornum;
        public Form2()
        {
            InitializeComponent();
            listBoxWoa.DisplayMember = "nombre";
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if( Caracteres(textBoxBusqueda.Text) == true)
            {
                listBoxWoa.Items.Clear();
                valornum = 0;
                foreach (Pelicula peli in BaseDeDatos.GetPeliculas())
                {
                    if (peli.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                    {
                        listBoxWoa.Items.Add(peli.GetNombre());
                        pasa = true;
                    }
                }
                if (pasa == false)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                valornum = 1;
                listBoxWoa.Items.Clear();
                foreach (Persona actor in BaseDeDatos.GetPersonas())
                {
                    if (actor is Actor)
                    {
                        if (actor.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                        {
                            listBoxWoa.Items.Add(actor.GetNombre() + " " + actor.GetApellido());
                            pasa = true;
                            continue;
                        }
                        if (actor.GetApellido().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                        {
                            listBoxWoa.Items.Add(actor.GetNombre() + " " + actor.GetApellido());
                            pasa = true;
                            continue;
                        }
                    }
                }
                if (pasa == false)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                valornum = 2;
                listBoxWoa.Items.Clear();
                foreach (Persona director in BaseDeDatos.GetPersonas())
                {
                    if (director is Director)
                    {
                        if (director.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                        {
                            listBoxWoa.Items.Add(director.GetNombre() + " " + director.GetApellido());
                            pasa = true;
                            continue;
                        }
                        if (director.GetApellido().ToLower() == textBoxBusqueda.Text.ToLower())
                        {
                            listBoxWoa.Items.Add(director.GetNombre() + " " + director.GetApellido());
                            pasa = true;
                            continue;
                        }
                    }
                }
                if (pasa == false)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                valornum = 3;
                listBoxWoa.Items.Clear();
                foreach (Persona productor in BaseDeDatos.GetPersonas())
                {
                    if (productor is Productor)
                    {
                        if (productor.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                        {
                            listBoxWoa.Items.Add(productor.GetNombre() + " " + productor.GetApellido());
                            pasa = true;
                            continue;
                        }
                        if (productor.GetApellido().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                        {
                            listBoxWoa.Items.Add(productor.GetNombre() + " " + productor.GetApellido());
                            pasa = true;
                            continue;
                        }
                    }
                }
                if (pasa == false)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            valornum = 4;
            bool pasa = false;
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                listBoxWoa.Items.Clear();
                foreach(Estudio est in BaseDeDatos.GetEstudios())
                {
                    if (est.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                    {
                        listBoxWoa.Items.Add(est.GetNombre());
                        pasa = true;
                    }
                }
            }
            if (pasa == false)
                MessageBox.Show("No se encuentra lo que busca");
        }
        public bool Caracteres (string busqueda)
        {
            if (textBoxBusqueda.Text.Count() < 3)
            {
                return false;
            }
            return true;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            serial.Guardar();
            Environment.Exit(0);
        }

        private void textBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                listBoxWoa.Items.Clear();
                foreach (Persona actor in BaseDeDatos.GetPersonas())
                {
                    if (actor.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                    {
                        listBoxWoa.Items.Add(actor.GetNombre() + " " + actor.GetApellido());
                    }
                }
                foreach (Estudio est in BaseDeDatos.GetEstudios())
                {
                    if (est.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                    {
                        listBoxWoa.Items.Add(est.GetNombre());
                    }
                }
                foreach (Pelicula peli in BaseDeDatos.GetPeliculas())
                {
                    if (peli.GetNombre().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
                    {
                        listBoxWoa.Items.Add(peli.GetNombre());
                    }
                }
            }

        }

        
    }
}
