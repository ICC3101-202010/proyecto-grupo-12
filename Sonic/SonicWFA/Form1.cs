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
    public partial class Form1 : Form
    {
        Login login;
        public Form1(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            funcionesAdmin ins = new funcionesAdmin(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionesCancion ins = new funcionesCancion(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionesVideo ins = new funcionesVideo(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            login.Show();
        }
    }
}
