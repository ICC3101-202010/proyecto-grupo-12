﻿using System;
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
    public partial class agregarVideo : Form
    {
        public agregarVideo()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionesVideo ins = new funcionesVideo();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
            agregarActores ins = new agregarActores();
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
