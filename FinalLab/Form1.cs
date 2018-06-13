using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace FinalLab
{
    public partial class Form1 : Form
    {
        Form2 form2;
        public Form1()
        { 
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Hide();
            if (form2 == null )
            {
                form2 = new Form2();
            }
            timer1.Stop();
            form2.ShowDialog();
            this.Close();
        }

        private void TExtoBienvenida_Click(object sender, EventArgs e)
        {

        }
    }
}
