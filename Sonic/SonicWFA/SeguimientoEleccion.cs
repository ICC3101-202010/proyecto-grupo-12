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
    public partial class SeguimientoEleccion : Form
    {
        Sonic sonic;
        Usuario2 usuario;
        Seguimiento seguimiento;
        public Cantante cantante;
        public Album album;
        public Compositor compositor;
        public Director director;
        public Actor actor;
        public SeguimientoEleccion(Sonic sonic, Usuario2 usuario, Seguimiento seguimiento)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;
            this.seguimiento = seguimiento;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SeguimientoEleccion_Load(object sender, EventArgs e)
        {
            
        }

        private void SeguimientoEleccion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(cantante != null) { sonic.DejarSeguirPersona(usuario, cantante); }
            if (compositor != null) { sonic.DejarSeguirPersona(usuario, compositor);  }
            if (director != null) { sonic.DejarSeguirPersona(usuario, director); }
            if (actor != null) { sonic.DejarSeguirPersona(usuario, actor); }
            if(album != null) { usuario.seguirAlbum.Remove(album); }
            seguimiento.Actualizar();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
