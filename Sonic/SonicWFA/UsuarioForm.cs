
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
    public partial class UsuarioForm : Form
    {
        Sonic sonic;
        Usuario2 usuarioActual;
        public UsuarioForm(Sonic sonic, Usuario2 usuario)
        {
            this.sonic = sonic;
            this.usuarioActual = usuario;

            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btnDespliegue_Click(object sender, EventArgs e)
        {
            if (MenuVertical.Width == 250)
            {
                MenuVertical.Width = 70;
            }
            else
                MenuVertical.Width = 250;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            sonic.GuardarDatos();
            this.Close();
            Login login = new Login(sonic);
            login.Show();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnMinimizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnMinimizar.Visible = false;
        }

        private void btnDisminuir_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void AbrirPanel(object FormHijo)
        {
            if (this.Contenedor.Controls.Count > 0)
                this.Contenedor.Controls.RemoveAt(0);
            Form fh = FormHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(fh);
            this.Contenedor.Tag = fh;
            fh.Show();
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Perfil(usuarioActual));
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Login login = new Login(sonic);
            login.MdiParent = this.MdiParent;
            this.Hide();
            login.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Buscar(sonic, usuarioActual));
        }

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Reproducir(sonic, usuarioActual));
        }

        private void btnSeguimiento_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Seguimiento(sonic, usuarioActual));
        }

        private void btnMeGusta_Click(object sender, EventArgs e)
        {
            AbrirPanel(new MeGusta(sonic, usuarioActual));
        }

        private void btnCalificacion_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Calificacion());
        }

        private void btnFavoritos_Click(object sender, EventArgs e)
        {
            AbrirPanel(new Favoritos(usuarioActual, sonic));
        }

        private void btnPlaylist_Click(object sender, EventArgs e)
        {
            AbrirPanel(new PlaylistForm(sonic, usuarioActual));
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LogoSonic_Click(object sender, EventArgs e)
        {
            JuegoForm juego = new JuegoForm();
            juego.Show();
        }
    }
}

