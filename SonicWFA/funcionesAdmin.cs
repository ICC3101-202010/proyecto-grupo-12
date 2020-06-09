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
    public partial class funcionesAdmin : Form
    {
        Login login;
        public funcionesAdmin(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 ins = new Form1(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregarAdmin ins = new agregarAdmin(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            agregarPublicidad ins = new agregarPublicidad(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
