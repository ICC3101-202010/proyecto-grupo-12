﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace SonicWFA
{
    public partial class Login : Form
    {
        Sonic sonic = new Sonic();

        Thread th;
        public Login()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);     
        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDisminuir_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void tbUsuario_Enter(object sender, EventArgs e)
        {
            if(tbUsuario.Text == "USUARIO")
            {
                tbUsuario.Text = "";
                tbUsuario.ForeColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            }
        }

        private void tbUsuario_Leave(object sender, EventArgs e)
        {
            if(tbUsuario.Text == "")
            {
                tbUsuario.Text = "USUARIO";
                tbUsuario.ForeColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "CONTRASEÑA")
            {
                tbPassword.Text = "";
                tbPassword.ForeColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
                tbPassword.UseSystemPasswordChar = true;
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "CONTRASEÑA";
                tbPassword.ForeColor = Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(250)))), ((int)(((byte)(171)))));
                tbPassword.UseSystemPasswordChar = false;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            bool temp = InicioSesionCorrecto();
            if (temp)
            {
                Usuario usuario = new Usuario();
                usuario.MdiParent = this.MdiParent;
                this.Hide();
                usuario.ShowDialog();
            }
        }

        public bool InicioSesionCorrecto()
        {
            
            if (sonic.IniciarSesion(this.tbUsuario.Text, this.tbPassword.Text))
            {
                return true;
            }
            else
            {
                label2.Text = "USUARIO O CONTRASEÑA INCORRECTO";
                return false;
            }
        }

        private void linkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
        }

    }
}