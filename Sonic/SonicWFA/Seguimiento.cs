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
    public partial class Seguimiento : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        public Seguimiento(Sonic sonic , Usuario2 usuario )
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;

            foreach(Cantante cantante in usuario.seguirCantante) { comboBox1.Items.Add(cantante.nombre); }
            foreach(Album album in usuario.seguirAlbum) { comboBox4.Items.Add(album.nombre); }
            foreach(Compositor compositor in usuario.seguirCompositor) { comboBox5.Items.Add(compositor.nombre); }
            foreach(Director director in usuario.seguirDirector) { comboBox6.Items.Add(director.nombre); }
            foreach(Actor actor in usuario.seguirActor) { comboBox7.Items.Add(actor.nombre); }
        }

        public void Actualizar()
        {
            comboBox1.Items.Clear();
            comboBox4.Items.Clear();
            comboBox5.Items.Clear();
            comboBox6.Items.Clear();
            comboBox7.Items.Clear();

            comboBox1.Text = "";
            comboBox4.Text = "";
            comboBox5.Text = "";
            comboBox6.Text = "";
            comboBox7.Text = "";

            foreach (Cantante cantante in usuario.seguirCantante) { comboBox1.Items.Add(cantante.nombre); }
            foreach (Album album in usuario.seguirAlbum) { comboBox4.Items.Add(album.nombre); }
            foreach (Compositor compositor in usuario.seguirCompositor) { comboBox5.Items.Add(compositor.nombre); }
            foreach (Director director in usuario.seguirDirector) { comboBox6.Items.Add(director.nombre); }
            foreach (Actor actor in usuario.seguirActor) { comboBox7.Items.Add(actor.nombre); }
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(Cantante cantante in sonic.cantantes)
            {
                if(Convert.ToString(comboBox1.SelectedItem) == cantante.nombre)
                {
                    SeguimientoEleccion tmp = new SeguimientoEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.cantante = cantante;
                    break;
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Compositor compositor in sonic.compositores)
            {
                if (Convert.ToString(comboBox5.SelectedItem) == compositor.nombre)
                {
                    SeguimientoEleccion tmp = new SeguimientoEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.compositor = compositor;
                    break;
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Director director in sonic.directores)
            {
                if (Convert.ToString(comboBox6.SelectedItem) == director.nombre)
                {
                    SeguimientoEleccion tmp = new SeguimientoEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.director = director;
                    break;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Album album in sonic.albums)
            {
                if (Convert.ToString(comboBox4.SelectedItem) == album.nombre)
                {
                    SeguimientoEleccion tmp = new SeguimientoEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.album = album;
                    break;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (Actor actor in sonic.actores)
            {
                if (Convert.ToString(comboBox7.SelectedItem) == actor.nombre)
                {
                    SeguimientoEleccion tmp = new SeguimientoEleccion(sonic, usuario, this);
                    tmp.Show();
                    tmp.actor = actor;
                    break;
                }
            }
        }
    }
}
