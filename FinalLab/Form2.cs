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
                        if (director.GetApellido().ToLower().IndexOf(textBoxBusqueda.Text.ToLower()) != -1)
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
            listBoxWoa.Items.Clear();
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
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
            valornum = 99; //evito que me entre sin apretar boton

        }

        private void listBoxWoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nombre;
            string apellido;
            Actor escogidoActor = null;
            Director escogidoDirector = null;
            Productor escogidoProductor = null;
            try
            {
                if (valornum == 1) //si se seleccionó una actor
                {
                    foreach (Persona actor in BaseDeDatos.GetPersonas())
                    {
                        //if(ListBox.SelectedItem.ToString().Split(" ")[0] == actor.GetNombre() && ListBox.SelectedItem.ToString().Split(" ")[1] == actor.GetApellido())
                        if (listBoxWoa.SelectedItem.ToString() == (actor.GetNombre() + " " + actor.GetApellido()))
                        {
                            escogidoActor = (Actor)actor;
                            Form3 form3 = new Form3(escogidoActor);
                            this.Hide();
                            form3.ShowDialog();
                            this.Show();

                        }

                    }

                }
                if (valornum == 2) //si se seleccionó una director
                {
                    foreach (Director director in BaseDeDatos.GetPersonas())
                    {
                        //if(ListBox.SelectedItem.ToString().Split(" ")[0] == actor.GetNombre() && ListBox.SelectedItem.ToString().Split(" ")[1] == actor.GetApellido())
                        if (listBoxWoa.SelectedItem.ToString() == (director.GetNombre() + " " + director.GetApellido()))
                        {
                            escogidoDirector = (Director)director;
                            Form3 form3 = new Form3(escogidoDirector);
                            this.Hide();
                            form3.ShowDialog();
                            this.Show();
                        }

                    }

                }
                if (valornum == 3) //si se seleccionó una productor
                {
                    foreach (Productor productor in BaseDeDatos.GetPersonas())
                    {
                        //if(ListBox.SelectedItem.ToString().Split(" ")[0] == actor.GetNombre() && ListBox.SelectedItem.ToString().Split(" ")[1] == actor.GetApellido())
                        if (listBoxWoa.SelectedItem.ToString() == (productor.GetNombre() + " " + productor.GetApellido()))
                        {
                            escogidoProductor = (Productor)productor;
                            Form3 form3 = new Form3(escogidoProductor);
                            this.Hide();
                            form3.ShowDialog();
                            this.Show();
                        }

                    }

                }
            }
            catch
            {

            }
            

        }
    }
}
