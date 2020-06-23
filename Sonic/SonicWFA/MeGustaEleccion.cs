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
    public partial class MeGustaEleccion : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        MeGusta meGusta;
        public Cancion cancion;
        public Video video;
        public MeGustaEleccion(Sonic sonic, Usuario2 usuario, MeGusta megusta)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;
            this.meGusta = megusta;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cancion != null)
            {
                usuario.meGustaCanciones.Remove(cancion);
                cancion.meGusta--;
                meGusta.listBox1.Items.Remove(cancion.nombre);
            }
            if(video != null)
            {
                usuario.meGustaVideos.Remove(video);
                video.meGusta--;
                meGusta.listBox2.Items.Remove(video.nombre);
            }
            meGusta.Actualizar();
            this.Close();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MeGustaEleccion_Load(object sender, EventArgs e)
        {
           
        }

        private void MeGustaEleccion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
