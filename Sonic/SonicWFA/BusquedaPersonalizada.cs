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
    public partial class BusquedaPersonalizada : Form
    {
        Sonic sonic;
        Buscar buscar;
        public BusquedaPersonalizada(Sonic sonic, Buscar buscar)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.buscar = buscar;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string palabra = textBox1.Text;
            string persona = textBox2.Text;
            int eleccion1 = 0;
            int valor1 = 0;
            int valor2 = 0;
            if (comboBox1.Text == "MAYOR")
            {
                eleccion1 = 1;
            } else if (comboBox1.Text == "MENOR")
            {
                eleccion1 = 2;
            } else if (comboBox1.Text == "IGUAL")
            {
                eleccion1 = 3;
            }
            try
            {
                valor1 = Convert.ToInt32(comboBox2.Text);
            }
            catch (Exception)
            {

            }
            int eleccion2 = 0;
            if (comboBox3.Text == "MAYOR")
            {
                eleccion2 = 1;
            }
            else if (comboBox3.Text == "MENOR")
            {
                eleccion2 = 2;
            }
            else if (comboBox3.Text == "IGUAL")
            {
                eleccion2 = 3;
            }
            try
            {
                valor2 = Convert.ToInt32(comboBox4.Text);

            }
            catch (Exception)
            {
            }
            string categoria = textBox3.Text;

            if(textBox1.Text == "") { palabra = "qwery"; }
            if(textBox2.Text == "") { persona = "qwery"; }
            if (textBox3.Text == "") { categoria = "qwery"; }



            List<Cancion> canciones = sonic.BuscarCancion(palabra, persona, eleccion1, valor1, eleccion2, valor2, categoria);
            List<Video> videos = sonic.BuscarVideo(palabra, persona, eleccion1, valor1, eleccion2, valor2, categoria);

            buscar.listBox1.Items.Clear();
            foreach(Cancion cancion in canciones)
            {
                buscar.listBox1.Items.Add(cancion.nombre);
            }
            foreach (Video video in videos)
            {
                buscar.listBox1.Items.Add(video.nombre);
            }
            this.Close();
        }

        private void BusquedaPersonalizada_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void BusquedaPersonalizada_Load(object sender, EventArgs e)
        {

        }
    }
}
