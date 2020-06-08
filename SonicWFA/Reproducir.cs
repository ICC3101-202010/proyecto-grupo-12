using System;
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

        public Reproducir()
        {
            InitializeComponent();
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reproducir_Load(object sender, EventArgs e)
        {

        }

        private void btnCargarCancion_Click(object sender, EventArgs e)
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

            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = rutaArchivoMP3[listBox1.SelectedIndex];
        }
    }
}
