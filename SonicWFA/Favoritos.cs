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
    public partial class Favoritos : Form
    {
        Usuario2 usuarioActual;
        Sonic sonic;
        Cancion cancion;
        public Favoritos(Usuario2 usuario, Sonic sonic)
        {
            InitializeComponent();
            this.usuarioActual = usuario;
            this.sonic = sonic;

            foreach (Cancion cancion in usuarioActual.favoritosCancion) 
            {
                listBox1.Items.Add(cancion.nombre);
            }

            foreach (Video video in usuarioActual.favoritosVideo)
            {
                listBox2.Items.Add(video.nombre);
            }
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Cancion cancion in usuarioActual.favoritosCancion)
            {
                if (cancion.nombre == Convert.ToString(listBox1.Items[listBox1.SelectedIndex]))
                {
                    this.cancion = cancion;
                }
            }
            FavoritosEleccion fav = new FavoritosEleccion(sonic, usuarioActual, cancion);
            fav.MdiParent = this.MdiParent;
            this.Hide();
            fav.ShowDialog();
        }
    }
}
