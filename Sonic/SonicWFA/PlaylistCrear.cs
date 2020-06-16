using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SonicWFA
{
    public partial class PlaylistCrear : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        PlaylistForm form;
        public PlaylistCrear(PlaylistForm form, Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;
            this.form = form;
            
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CANCION")
            {
                foreach (Cancion cancion in usuario.favoritosCancion)
                {
                    if (cancion.nombre == listBox1.GetItemText(listBox1.SelectedItem))
                    {
                        listBox1.Items.Remove(cancion.nombre);
                        listBox2.Items.Add(cancion.nombre);
                    }
                }
            }

            if (comboBox1.Text == "VIDEO")
            {
                foreach (Video video in usuario.favoritosVideo)
                {
                    if (video.nombre == Convert.ToString(listBox1.Items[listBox1.SelectedIndex]))
                    {
                        listBox1.Items.Remove(video.nombre);
                        listBox2.Items.Add(video.nombre);
                    }
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "CANCION")
            {
                List<Cancion> cancionesPlaylist = new List<Cancion>();
                foreach (Cancion cancion2 in usuario.favoritosCancion)
                {
                    foreach (string cancion in listBox2.Items)
                    {
                        if (cancion == cancion2.nombre)
                        {
                            cancionesPlaylist.Add(cancion2);
                        }
                    }
                }
                sonic.CrearPlaylist(usuario, textBox1.Text, cancionesPlaylist);
            }

            if (comboBox1.Text == "VIDEO")
            {
                List<Video> videosPlaylist = new List<Video>();
                foreach (Video video2 in usuario.favoritosVideo)
                {
                    foreach (string video in listBox2.Items)
                    {
                        if (video == video2.nombre)
                        {
                            videosPlaylist.Add(video2);
                        }
                    }
                }
                sonic.CrearPlaylist(usuario, textBox1.Text, null,  videosPlaylist);
            }
            form.Actualizar();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if(comboBox1.Text == "CANCION")
            {
                foreach (Cancion cancion in usuario.favoritosCancion)
                {
                    listBox1.Items.Add(cancion.nombre);
                }
            }
            if (comboBox1.Text == "VIDEO")
            {
                foreach (Video video in usuario.favoritosVideo)
                {
                    listBox1.Items.Add(video.nombre);
                }
            }
        }

        private void PlaylistCrear_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
