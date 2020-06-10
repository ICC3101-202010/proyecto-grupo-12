﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicWFA
{
    public partial class Reproducir : Form
    {
        bool play = false;
        String[] ArchivoMP3;
        String[] ArchivosMP3;
        String[] rutaArchivoMP3;
        Sonic sonic;
        Usuario2 usuario;

        public Reproducir(Sonic sonic, Usuario2 usuario)
        {
            InitializeComponent();
            this.sonic = sonic;
            this.usuario = usuario;

            foreach (Cancion cancion in sonic.canciones)
            {
                listBox1.Items.Add(cancion.nombre);
            }

            foreach (Video video in sonic.videos)
            {
                listBox2.Items.Add(video.nombre);
            }
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reproducir_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarCancion_Click(object sender, EventArgs e)
<<<<<<< Updated upstream
        {
            OpenFileDialog buscar = new OpenFileDialog();
            buscar.Multiselect = true;
            if(buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivoMP3 = buscar.SafeFileNames;
                rutaArchivoMP3 = buscar.FileNames;
                foreach(var ArchivoMp3 in ArchivosMP3)
                {
                    listBox1.Items.Add(ArchivoMP3);
                }
                axWindowsMediaPlayer1.URL = rutaArchivoMP3[0];
                listBox1.SelectedIndex = 0;

=======
        {

            string cancionReproducir = Convert.ToString(listBox1.Items[listBox1.SelectedIndex]);
            foreach(Cancion cancion in sonic.canciones)
            {
                if(cancion.nombre == cancionReproducir)
                {
                    axWindowsMediaPlayer1.URL = cancion.rutaArchivoMp3;
                }
>>>>>>> Stashed changes
            }
               
        }

        private void btnCargarVideos_Click(object sender, EventArgs e)
        {
            string videoReproducir = Convert.ToString(listBox2.Items[listBox2.SelectedIndex]);
            foreach (Video video in sonic.videos)
            {
                if (video.nombre == videoReproducir)
                {
                    axWindowsMediaPlayer1.URL = video.rutaArchivoMp3;
                }
            }
        }
    }
}
