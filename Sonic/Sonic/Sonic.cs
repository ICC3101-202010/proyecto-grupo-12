using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    public class Sonic
    {
        public List<Usuario> administradores = new List<Usuario>(); //Creacion lista admin con un default
        List<Usuario> usuarios = new List<Usuario>(); //Creacion lista Usuarios

        public bool IniciarSesionAdmin() //Metodo para iniciar sesion como admin
        {
            if (administradores.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("NO EXISTEN ADMINISTRADORES"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("-- Agrega el primer administrador --");
                AgregarAdministrador();
                return false;
            }
            else
            {
                Console.WriteLine("Nombre de usuario: ");
                string nombreDeUsuarioAdmin = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                string contraseñaAdmin = Console.ReadLine();

                foreach (Usuario admin in administradores)
                {
                    if (admin.nombreDeUsuario == nombreDeUsuarioAdmin && admin.contraseña == contraseñaAdmin)
                    {
                        return true;
                    }
                }
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("USUARIO DE ADMIN O CONTRASEÑA INCORRECTO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                Console.Clear();
                return false;
            }
        }

        public void AgregarAdministrador() //Metodo para agregar admin
        {
            Console.WriteLine("Nombre de Usuario: ");
            string nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string contraseña = Console.ReadLine();
            Usuario admin = new Usuario(nombreDeUsuario, nombre, apellido, contraseña, "Administrador");
            bool AdminRegistrado = false;
            foreach (Usuario Listausuario in administradores)
            {
                if (admin.nombreDeUsuario == Listausuario.nombreDeUsuario) { AdminRegistrado = true; break; } else { AdminRegistrado = false; }
            }
            if (AdminRegistrado)
            {
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("NOMBRE DE USUARIO NO DISPONIBLE"); Console.BackgroundColor = ConsoleColor.Black;
             
                Thread.Sleep(2000);
                Console.Clear();
                AgregarAdministrador();
            }
            else
            {
                administradores.Add(admin);
                Thread.Sleep(2000);
                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("ADMINISTRADOR AGREGADO CON EXITO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
            }
        }

        public void Registrarse() //Metodo para registrarse como usuario
        {
            Console.WriteLine("Nombre de Usuario: ");
            string nombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine("Contraseña: ");
            string contraseña = Console.ReadLine();
            Console.WriteLine("¿Desea suscribirse como Usuario Premium?");
            Console.WriteLine("1. SI");
            Console.WriteLine("2. NO");
            int opcion = Convert.ToInt32(Console.ReadLine());
            string tipoUsuario = "";
            switch (opcion)
            {
                case 1:
                    tipoUsuario = "Premium";
                    break;
                case 2:
                    tipoUsuario = "Gratis";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
            Usuario usuario = new Usuario(nombreDeUsuario, nombre, apellido, contraseña, tipoUsuario);
            bool UsuarioRegistrado = false;
            foreach (Usuario Listausuario in usuarios)
            {
                if (usuario.nombreDeUsuario == Listausuario.nombreDeUsuario){UsuarioRegistrado = true;break;} else {UsuarioRegistrado = false;}
            }
            if (UsuarioRegistrado)
            {
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("NOMBRE DE USUARIO NO DISPONIBLE"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                Console.Clear();
                this.Registrarse();
            } else
            {
                usuarios.Add(usuario);
                Thread.Sleep(2000);
                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("USUARIO REGISTRADO CON EXITO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
            }
        }

        public bool IniciarSesion() //Metodo para iniciar sesión como usuario
        {
            if (usuarios.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("DEBES REGISTRAR UN USUARIO PRIMERO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                return false;
            }
            else
            {
                Console.WriteLine("Nombre de usuario: ");
                string nombreDeUsuario = Console.ReadLine();
                Console.WriteLine("Contraseña: ");
                string contraseña = Console.ReadLine();

                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.nombreDeUsuario == nombreDeUsuario && usuario.contraseña == contraseña)
                    {
                        return true;
                    }
                }
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("USUARIO O CONTRASEÑA INCORRECTO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                Console.Clear();
                return false;
            }

            
        }
    }
}
