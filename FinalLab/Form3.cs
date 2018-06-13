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
    public partial class Form3 : Form
    {
        public Form3(object sender)
        {
            InitializeComponent();
            Actor listenerActor;
            Titulo.Text = "Perfil de Actor";
            if (sender is Actor)
            {
                listenerActor = (Actor)sender;
                NombrePerfil.Text = listenerActor.GetNombre();
                ApellidoPerfil.Text = listenerActor.GetApellido();
                NacimietoPerfil.Text = listenerActor.GetFechaNacimiento();
                BiografiaPerfil.Text = listenerActor.GetBiografia();

            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void NombrePerfil_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NacimietoPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}

