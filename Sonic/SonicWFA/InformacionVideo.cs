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
    public partial class InformacionVideo : Form
    {

        Sonic sonic;
        Usuario2 usuarioActual;
        Video video;
        string seleccion;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public InformacionVideo(string seleccion, Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.seleccion = seleccion;
            this.sonic = sonic;
            this.usuarioActual = usuario;

            foreach (Video video in sonic.videos)
            {
                if (video.nombre == seleccion)
                {
                    this.video = video;
                    label16.Text = video.GetType().Name;
                    label17.Text = video.nombre;
                    label18.Text = video.director.nombre;

                    foreach(Actor actor in video.actores)
                    {
                        comboBox1.Items.Add(actor.nombre);
                    }
                    label19.Text = video.genero;
                    label20.Text = video.categoria;
                    label21.Text = video.estudio;
                    label22.Text = Convert.ToString(video.añoPublicacion);
                    label23.Text = Convert.ToString(video.resolucion);
                    label24.Text = Convert.ToString(video.numeroReproducciones);
                    label25.Text = Convert.ToString(video.calificacion);
                    label26.Text = Convert.ToString(video.meGusta);
                    label4.Text = Convert.ToString(video.descripcion);
                   
                }
            }
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (checkBox8.Checked == true) { sonic.AgregarVideoAFavoritos(usuarioActual, video); }
            //if (checkBox1.Checked == true) { sonic.NuevoSeguidorPersona(usuarioActual, cancion.cantante); }
            //if (checkBox4.Checked == true) { sonic.NuevoSeguidorEstudio(usuarioActual, cancion.album); }
            if (checkBox1.Checked == true) { sonic.NuevoSeguidorPersona(usuarioActual, video.director); }
            if (checkBox3.Checked == true) { usuarioActual.gustos += video.genero; }
            if (checkBox7.Checked == true) { video.meGusta += 1; }
            this.Close();
        }

        private void InformacionVideo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
