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
    public partial class Perfil : Form
    {
        Usuario2 usuarioActual;
        public Perfil(Usuario2 usuario)
        {
            InitializeComponent();

            this.usuarioActual = usuario;
            labelUsuario.Text = usuario.nombreDeUsuario;
            labelNombre.Text = usuario.nombre;
            labelApellido.Text = usuario.apellido;
            if (usuario.tipoUsuario == "SI")
            {
                labelTipo.Text = "PREMIUM";
            } else
            {
                labelTipo.Text = "GRATIS";
            }
            labelPrivacidad.Text = usuario.privacidad;
        }

        private void Actualizar()
        {

            labelUsuario.Text = usuarioActual.nombreDeUsuario;
            labelNombre.Text = usuarioActual.nombre;
            labelApellido.Text = usuarioActual.apellido;
            if (usuarioActual.tipoUsuario == "SI")
            {
                labelTipo.Text = "PREMIUM";
            }
            else
            {
                labelTipo.Text = "GRATIS";
            }
            labelPrivacidad.Text = usuarioActual.privacidad;
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuarioActual.CambiarInfo(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, comboBox1.Text, textBox5.Text);
            Actualizar();
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            comboBox1.Text = "";
        }
    }
}
