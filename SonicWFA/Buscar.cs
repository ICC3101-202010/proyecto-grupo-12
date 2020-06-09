using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicWFA
{
    public partial class Buscar : Form
    {
        Sonic sonic;
        Usuario2 usuarioActual;
        public Buscar(Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();

            this.sonic = sonic;
            this.usuarioActual = usuario;
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BusquedaPersonalizada personalizada = new BusquedaPersonalizada(sonic, this);
            personalizada.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            string palabra = textBox1.Text;
            string resultadoBusqueda = sonic.Buscar(palabra);
            if (resultadoBusqueda != "")
            {
               label3.Text = resultadoBusqueda;

            } else
            {
               label3.Text = "";
            }
        }
    }
}
