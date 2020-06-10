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
    public partial class pagarImagen : Form
    {
        Login login;
        public pagarImagen(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarPublicidad ins = new agregarPublicidad(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha realizado la compra con exito.");
            funcionesAdmin ins = new funcionesAdmin(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selected = comboBox2.SelectedItem.ToString();
            int casi = Convert.ToInt32(selected);
            int cantidad = casi * 500;
            label4.Text = cantidad.ToString();
        }
    }
}
