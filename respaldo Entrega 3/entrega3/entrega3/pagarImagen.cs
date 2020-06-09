using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace entrega3
{
    public partial class pagarImagen : Form
    {
        public pagarImagen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agregarPublicidad ins = new agregarPublicidad();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se ha realizado la compra con exito.");
            funcionesAdmin ins = new funcionesAdmin();
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
