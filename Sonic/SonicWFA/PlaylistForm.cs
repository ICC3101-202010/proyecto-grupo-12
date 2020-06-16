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
    public partial class PlaylistForm : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        public PlaylistForm(Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;

            foreach(Playlist playlist in usuario.playlistUsuario)
            {
                listBox2.Items.Add(playlist.nombre);
            }
        }

        public void Actualizar()
        {
            listBox2.Items.Clear();
            foreach (Playlist playlist in usuario.playlistUsuario)
            {
                listBox2.Items.Add(playlist.nombre);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PlaylistCrear crear = new PlaylistCrear(this, sonic, usuario);
            crear.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Playlist playlist in usuario.playlistUsuario)
            {
                if (playlist.nombre == Convert.ToString(listBox2.Items[listBox2.SelectedIndex]))
                {
                    PlaylistSeleccionar tmp = new PlaylistSeleccionar(sonic, usuario, playlist);
                    tmp.Show();
                    break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Playlist playlist in usuario.playlistUsuario)
            {
                if (playlist.nombre == Convert.ToString(listBox2.Items[listBox2.SelectedIndex]))
                {
                    usuario.playlistUsuario.Remove(playlist);
                    sonic.playlists.Remove(playlist);
                    listBox2.Items.Remove(playlist.nombre);
                    break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            foreach (Playlist playlist in sonic.playlists)
            {
                if (playlist.nombre == Convert.ToString(listBox1.Items[listBox1.SelectedIndex]))
                {
                    PlaylistSeleccionar tmp = new PlaylistSeleccionar(sonic, usuario, playlist);
                    tmp.Show();
                    break;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string palabra = textBox1.Text;

            if (checkBox5.Checked == true)
            {
                foreach (Playlist playlist in sonic.playlists)
                {
                    if (palabra == playlist.nombre && playlist.playlist.Count() != 0)
                    {
                        listBox1.Items.Add(playlist.nombre);
                    }
                }
            }
            if (checkBox1.Checked == true)
            {
                foreach (Playlist playlist in sonic.playlists)
                {
                    if (palabra == playlist.nombre && playlist.videos.Count() != 0)
                    {
                        listBox1.Items.Add(playlist.nombre);
                    }
                }
            }
        }
    }
}
