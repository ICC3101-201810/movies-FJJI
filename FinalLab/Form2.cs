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
        public Form2()
        {
            InitializeComponent();
            int asd = 0;
            while (asd < 30)
            {
                asd++;
                listBoxWoa.Items.Add(asd.ToString());
            }
        }

        private void buttonPeliculas_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if( Caracteres(textBoxBusqueda.Text) == true)
            {
                foreach(Pelicula peli in BaseDeDatos.GetPeliculas())
                {
                    if (peli.GetNombre() == textBoxBusqueda.Text)
                    {
                        listBoxWoa.Items.Add(peli.GetNombre());
                        pasa = true;
                    }
                }
                if (pasa == true)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonActores_Click(object sender, EventArgs e)
        {
            bool pasa = false;
            if (Caracteres(textBoxBusqueda.Text) == true)
            {
                foreach (Actor actor in BaseDeDatos.GetPersonas())
                {
                    if (actor.GetNombre() == textBoxBusqueda.Text)
                    {
                        listBoxWoa.Items.Add(actor.GetNombre()+" "+actor.GetApellido());
                        pasa = true;
                        continue;
                    }
                    if (actor.GetApellido() == textBoxBusqueda.Text)
                    {
                        listBoxWoa.Items.Add(actor.GetNombre() + " " + actor.GetApellido());
                        pasa = true;
                        continue;
                    }
                }
                if (pasa == true)
                    MessageBox.Show("No se encuentra lo que busca");
            }
        }

        private void buttonDirectores_Click(object sender, EventArgs e)
        {
            if (Caracteres(textBoxBusqueda.Text) == true)
            {

            }
        }

        private void buttonProductores_Click(object sender, EventArgs e)
        {
            if (Caracteres(textBoxBusqueda.Text) == true)
            {

            }
        }

        private void buttonEstudios_Click(object sender, EventArgs e)
        {
            if (Caracteres(textBoxBusqueda.Text) == true)
            {

            }
        }
        public bool Caracteres (string busqueda)
        {
            if (textBoxBusqueda.Text.Count() < 3)
            {
                MessageBox.Show("ingrese a lo menos 3 caracteres");
                return true;
            }
            return false;
        }

        private void botonSalir_Click(object sender, EventArgs e)
        {
            serial.Guardar();
            Environment.Exit(0);
        }
    }
}
