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
            listBox1.Items.Clear();
            string palabra = textBox1.Text;

            if (checkBox5.Checked == true) 
            {
                List<Cancion> cancionesBusqueda = sonic.BuscarCancion(palabra);
                foreach(Cancion cancion in cancionesBusqueda)
                {
                    listBox1.Items.Add(cancion.nombre);
                }
            }
            if(checkBox1.Checked == true)
            {
                List<Video> videosBusqueda = sonic.BuscarVideo(palabra);
                foreach (Video video in videosBusqueda)
                {
                    listBox1.Items.Add(video.nombre);
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string seleccion = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
           

            if (checkBox5.Checked == true)
            {
                InformacionCancion infoCancion = new InformacionCancion(seleccion, sonic, usuarioActual);
                infoCancion.Show();
            }
            if (checkBox1.Checked == true)
            {
                InformacionVideo infovideo = new InformacionVideo(seleccion, sonic, usuarioActual);
                infovideo.Show();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
