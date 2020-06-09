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
    public partial class agregarActores : Form
    {
        Login login;
        public agregarActores(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if(selected == "Si")
            {
                agregarActores ins = new agregarActores(login);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else
            {
                MessageBox.Show("Se ha agregado el video con exito.");
                funcionesVideo ins = new funcionesVideo(login);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }
    }
}
