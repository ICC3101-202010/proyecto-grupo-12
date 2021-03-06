﻿using System;
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
    public partial class agregarPublicidad : Form
    {
        Login login;
        public agregarPublicidad(Login login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            funcionesAdmin ins = new funcionesAdmin(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if(selected == "Video")
            {
                pagarVideo ins = new pagarVideo(login);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
            else
            {
                pagarImagen ins = new pagarImagen(login);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }
    }
}