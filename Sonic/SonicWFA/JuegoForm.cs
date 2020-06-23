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
    public partial class JuegoForm : Form
    {
        int velocidad = 8;
        int gravedad = 5;
        int puntos = 0;

        public JuegoForm()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TiempoJuegoEvento(object sender, EventArgs e)
        {
            pbNave.Top += gravedad;
            pbEdificio.Left -= velocidad;
            pbRayo.Left -= velocidad;
            lPuntos.Text = "PUNTOS: " + puntos.ToString();

            if (pbEdificio.Left < -50)
            {
                pbEdificio.Left = 800;
                puntos++;
            }

            if (pbRayo.Left < -80)
            {   
                pbRayo.Left = 950;
                puntos++;
            }

            if(pbNave.Bounds.IntersectsWith(pbEdificio.Bounds) || pbNave.Bounds.IntersectsWith(pbRayo.Bounds) || pbNave.Bounds.IntersectsWith(pbTierra.Bounds))
            {
                finDelJuego();
            }

            if(pbNave.Top < -25)
            {
                finDelJuego();
            }
        }

        private void JuegoKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravedad = -15;
            }
        }

        private void JuegoKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravedad = 15;
            }
        }

        private void finDelJuego()
        {
            TiempoJuego.Stop();
            lPuntos.Text += " JUEGO TERMINADO";
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pBarra_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
