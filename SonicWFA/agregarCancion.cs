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
    public partial class agregarCancion : Form
    {
        Login login;
        public agregarCancion(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionesCancion ins = new funcionesCancion(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.sonic.ImportarCanciones(textBox1.Text, textBox3.Text, textBox5.Text, textBox6.Text, textBox9.Text, textBox2.Text, textBox4.Text, Convert.ToInt32(textBox7.Text), 0, 0);
            login.sonic.GuardarDatos();
            MessageBox.Show("Se ha agregado la cancion con exito.");
            funcionesCancion ins = new funcionesCancion(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
