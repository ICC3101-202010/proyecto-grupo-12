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
    public partial class InformacionCancion : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);


        Sonic sonic;
        Usuario2 usuarioActual;
        Cancion cancion;
        string seleccion;

        public InformacionCancion(string seleccion, Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.seleccion = seleccion;
            this.sonic = sonic;
            this.usuarioActual = usuario;

            foreach(Cancion cancion in sonic.canciones)
            {
                if(cancion.nombre == seleccion)
                {
                    this.cancion = cancion;
                    label16.Text = cancion.GetType().Name;
                    label17.Text = cancion.nombre;
                    label18.Text = cancion.cantante.nombre;
                    label19.Text = cancion.genero;
                    label20.Text = cancion.estudio;
                    label21.Text = cancion.discografia;
                    label22.Text = cancion.album.nombre;
                    label23.Text = cancion.compositor.nombre;
                    label24.Text = Convert.ToString(cancion.añoPublicacion);
                    label25.Text = Convert.ToString(cancion.duracion);
                    label27.Text = Convert.ToString(cancion.numeroReproducciones);
                    label28.Text = Convert.ToString(cancion.calificacion);
                    label29.Text = Convert.ToString(cancion.meGusta);
                }
            }

        }
        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(checkBox8.Checked == true) { sonic.AgregarCancionAFavoritos(usuarioActual, cancion); }
            if(checkBox1.Checked == true) { sonic.NuevoSeguidorPersona(usuarioActual, cancion.cantante); }
            if(checkBox4.Checked == true) { sonic.NuevoSeguidorAlbum(usuarioActual, cancion.album); }
            if(checkBox5.Checked == true) { sonic.NuevoSeguidorPersona(usuarioActual, cancion.compositor); }
            if(checkBox3.Checked == true) { usuarioActual.gustos += cancion.genero; }
            if(checkBox7.Checked == true) { cancion.meGusta += 1; }
            this.Close();
        }
    }
}
