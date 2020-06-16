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
    public partial class PlaylistSeleccionar : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        Playlist playlist;
        public PlaylistSeleccionar(Sonic sonic, Usuario2 usuario, Playlist playlist)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;
            this.playlist = playlist;


            foreach(Cancion cancion in playlist.playlist)
            {
                listBox1.Items.Add(cancion.nombre);
            }

            foreach(Video video in playlist.videos)
            {
                listBox1.Items.Add(video.nombre);
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PlaylistSeleccionar_Load(object sender, EventArgs e)
        {
            
        }

        private void PlaylistSeleccionar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Cancion cancion in playlist.playlist)
            {
                if (cancion.nombre == Convert.ToString(listBox1.Items[listBox1.SelectedIndex]))
                {
                    playlist.playlist.Remove(cancion);
                    listBox1.Items.Remove(cancion.nombre);
                    break;
                }
            }

            foreach (Video video in playlist.videos)
            {
                if (video.nombre == Convert.ToString(listBox1.Items[listBox1.SelectedIndex]))
                {
                    playlist.videos.Remove(video);
                    listBox1.Items.Remove(video.nombre);
                    break;
                }
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
