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
    public partial class InformacionVideo : Form
    {
        public InformacionVideo()
        {
            InitializeComponent();
        }

        private void btnFlecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
