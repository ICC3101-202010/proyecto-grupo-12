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
    public partial class agregarVideo : Form
    {
        Login login;
        string ArchivoMP3;
        string rutaArchivoMP3;
        public agregarVideo(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionesVideo ins = new funcionesVideo(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            agregarActores ins = new agregarActores(login, textBox1.Text, textBox3.Text, textBox5.Text, textBox7.Text, textBox2.Text, Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox6.Text), textBox8.Text,  ArchivoMP3, rutaArchivoMP3);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            if (buscar.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ArchivoMP3 = buscar.SafeFileName;
                rutaArchivoMP3 = buscar.FileName;
            }
        }
    }
}
