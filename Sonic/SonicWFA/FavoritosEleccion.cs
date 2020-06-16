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
    public partial class FavoritosEleccion : Form
    {
        Sonic sonic;
        Usuario2 usuarioActual;
        Cancion cancion;
        Video video;
        public FavoritosEleccion(Sonic sonic, Usuario2 usuario, Cancion cancion = null, Video video = null)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuarioActual = usuario;
            this.cancion = cancion;
            this.video = video;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoritosEleccion_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cancion != null)
            {
                usuarioActual.favoritosCancion.Remove(cancion);
                this.Close();
            }
            if (video != null)
            {
                usuarioActual.favoritosVideo.Remove(video);
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FavoritosEleccion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
