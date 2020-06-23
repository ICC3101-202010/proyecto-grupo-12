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
    public partial class MeGusta : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        public MeGusta(Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;

            foreach(Cancion cancion in usuario.meGustaCanciones)
            {
                listBox1.Items.Add(cancion.nombre);
            }
            foreach (Video video in usuario.meGustaVideos)
            {
                listBox2.Items.Add(video.nombre);
            }
        }

        public void Actualizar()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            foreach (Cancion cancion in usuario.meGustaCanciones)
            {
                listBox1.Items.Add(cancion.nombre);
            }
            foreach (Video video in usuario.meGustaVideos)
            {
                listBox2.Items.Add(video.nombre);
            }
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Cancion cancion in usuario.meGustaCanciones)
            {
                if(cancion.nombre == Convert.ToString(listBox1.SelectedItem))
                {
                    MeGustaEleccion tmp = new MeGustaEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.cancion = cancion;
                    break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Video video in usuario.meGustaVideos)
            {
                if (video.nombre == Convert.ToString(listBox2.SelectedItem))
                {
                    MeGustaEleccion tmp = new MeGustaEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.video = video;
                    break;
                }
            }
        }
    }
}
