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
        string titulo;
        string categoria;
        string genero;
        string estudio;
        string director;
        int añoDeEstreno;
        int resolucion;
        string descripcion;
        string archivMP3;
        string rutaArchivo;

        List<Actor> actores1 = new List<Actor>();
        public agregarActores(Login login, string titulo,
        string categoria,
        string genero,
        string estudio,
        string director,
        int añoDeEstreno,
        int resolucion,
        string descripcion,
        string archivMP3,
        string rutaArchivo)
        {
            InitializeComponent();
            this.login = login;
            this.titulo = titulo;
            this.categoria = categoria;
            this.genero = genero;
            this.estudio = estudio;
            this.director = director;
            this.añoDeEstreno = añoDeEstreno;
            this.resolucion = resolucion;
            this.descripcion = descripcion;
            this.archivMP3 = archivMP3;
            this.rutaArchivo = rutaArchivo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            if(selected == "Si")
            {
                Actor actor1 = new Actor(textBox1.Text);
                actores1.Add(actor1);
                login.sonic.AgregarActor(textBox1.Text);
                textBox1.Text = "";
            }
            else
            {
                Actor actor1 = new Actor(textBox1.Text);
                actores1.Add(actor1);
                login.sonic.AgregarActor(textBox1.Text);
                login.sonic.ImportarVideos(actores1, titulo, categoria, genero, estudio, director, descripcion, añoDeEstreno, resolucion, 0, 0, archivMP3, rutaArchivo);
                MessageBox.Show("Se ha agregado el video con exito.");
                funcionesVideo ins = new funcionesVideo(login);
                ins.MdiParent = this.MdiParent;
                this.Hide();
                ins.ShowDialog();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            funcionesVideo ins = new funcionesVideo(login);
            ins.MdiParent = this.MdiParent;
            this.Hide();
            ins.ShowDialog();
        }
    }
}
