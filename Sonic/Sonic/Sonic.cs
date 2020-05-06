using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    public class Sonic
    {
        public List<Admin> administradores = new List<Admin>(); //Creacion lista admin con un default
        List<Usuario> usuarios = new List<Usuario>(); //Creacion lista Usuarios
        List<Cancion> canciones = new List<Cancion>(); //Creacion lista canciones
        List<Cantante> cantantes = new List<Cantante>(); //Creacion lista cantantes
        List<Album> albums = new List<Album>(); //Creacion lista albums
        List<Compositor> compositores = new List<Compositor>(); //Creacion lista compositores
        private string perfilActual; //Saber en que perfil esta la sesion actual

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

                foreach (Admin admin in administradores)
                {
                    if (admin.nombreDeUsuario == nombreDeUsuarioAdmin && admin.contraseña == contraseñaAdmin)
                    {
                        perfilActual = admin.nombreDeUsuario;
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
            Admin admin = new Admin(nombreDeUsuario, nombre, apellido, contraseña);
            bool AdminRegistrado = false;
            foreach (Admin Listausuario in administradores)
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
            int opcion1 = Convert.ToInt32(Console.ReadLine());
            string tipoUsuario = "";
            switch (opcion1)
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
            Console.WriteLine("Elegir Privacidad");
            Console.WriteLine("1. Publico");
            Console.WriteLine("2. Privado");
            int opcion2 = Convert.ToInt32(Console.ReadLine());
            string privacidad = "";
            switch (opcion2)
            {
                case 1:
                    privacidad = "Publico";
                    break;
                case 2:
                    privacidad = "Privado";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            Usuario usuario = new Usuario(nombreDeUsuario, nombre, apellido, contraseña, privacidad, tipoUsuario);
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
                        perfilActual = usuario.nombreDeUsuario;
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

        public void CambiarNombreUsuario() //Cambiar Nombre / Perfil Actual
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    usuario.CambiarNombre();
                }
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("NOMBRE CAMBIADO"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }

        public void CambiarContraseñaUsuario() //Cambiar Contraseña / Perfil Actual
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    usuario.CambiarContraseña();
                }
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("CONTRASEÑA CAMBIADA"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }

        public void CambiarPrivacidad() //Cambiar Privacidad / Perfil Actual
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    usuario.CambiarPrivacidad();
                }
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("PRIVACIDAD CAMBIADA"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }

        public void ElegirGustos() //Elegir Gustos / Perfil Actual
        {
            while(true)
            {
                Console.WriteLine("Ingresa Generos que te gusten (uno a la vez): ");
                Console.WriteLine("Si deseas guardar y salir, escribe 'Salir' ");
                string genero = Console.ReadLine();
                if (genero == "Salir" || genero == "salir" || genero == "SALIR") { break; }
                foreach (Usuario usuario in usuarios)
                {
                    if (usuario.nombreDeUsuario == perfilActual)
                    {
                        usuario.AgregarGusto(genero);
                    }
                }
                Console.Clear();
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("GUSTOS GUARDADOS"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }

        public void MostarInfoPerfilUsuario() // Mostrar Perfil / Perfil Actual
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    usuario.ObtenerInformacion();
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public void CambiarNombreAdmin() //Cambiar Nombre / Perfil Actual
        {
            foreach (Admin admin in administradores)
            {
                if (admin.nombreDeUsuario == perfilActual)
                {
                    admin.CambiarNombre();
                }
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("NOMBRE CAMBIADO"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }


        public void CambiarContraseñaAdmin() //Cambiar Contraseña / Perfil Actual
        {
            foreach (Admin admin in administradores)
            {
                if (admin.nombreDeUsuario == perfilActual)
                {
                    admin.CambiarContraseña();
                }
            }
            Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("CONTRASEÑA CAMBIADA"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(2000);
        }

        public void MostarInfoPerfilAdmin() // Mostrar Perfil / Perfil Actual
        {
            foreach (Admin admin in administradores)
            {
                if (admin.nombreDeUsuario == perfilActual)
                {
                    admin.ObtenerInformacion();
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public Cantante AgregarCantante(string nombreCantante) // Agregar un Cantante
        {
            foreach (Cantante cantante1 in cantantes)
            {
                if (cantante1.nombre == nombreCantante){ return cantante1; }
            }
            Cantante cantante = new Cantante(nombreCantante);
            cantantes.Add(cantante);
            return cantante;
        }

        public Album AgregarAlbum(string nombreAlbum, Cantante cantanteAlbum) //Agregar un album
        {
            foreach (Album album1 in albums)
            {
                if (album1.nombre == nombreAlbum) { return album1; }
            }
            Album album = new Album(nombreAlbum, cantanteAlbum);
            albums.Add(album);
            return album;
        }

        public Compositor AgregarCompositor(string nombreCompositor) // Agregar un compositor
        {
            foreach (Compositor compositor1 in compositores)
            {
                if (compositor1.nombre == nombreCompositor) { return compositor1; }
            }
            Compositor compositor = new Compositor(nombreCompositor);
            compositores.Add(compositor);
            return compositor;
        }

        public void AgregarCancionCantante(Cancion cancion, string nombreCantante) // Agregar una cancion a un cantante
        {
            foreach(Cantante cantante in cantantes)
            {
                if(cantante.nombre == nombreCantante) { cantante.AgregarCancion(cancion); break; }
            }
        }

        public void AgregarCancionCompositor(Cancion cancion, string nombreCompositor) // Agregar una cancion a un compositor
        {
            foreach (Compositor compositor in compositores)
            {
                if (compositor.nombre == nombreCompositor) { compositor.AgregarCancion(cancion); break; }
            }
        }

        public void AgregarCancionAlbum(Cancion cancion, string nombreAlbum) // Agregar una cancion a un album
        {
            foreach (Album album in albums)
            {
                if (album.nombre == nombreAlbum) { album.AgregarCancion(cancion); break; }
            }
        }

        public void AgregarAlbumCantante(Album album, string nombreCantante) //Agregar un album a un cantante
        {
            foreach (Cantante cantante in cantantes)
            {
                if (cantante.nombre == nombreCantante && !cantante.albums.Contains(album)) { cantante.AgregarAlbum(album); break; }
            }
        }

        public void ImportarCanciones() //Metadata de Importacion
        {
            while (true)
            {
                Console.WriteLine("AGREGUE CANCIÓN");
                Console.WriteLine("Titulo: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Cantante: ");
                string cantante = Console.ReadLine();
                Cantante cantante2 = AgregarCantante(cantante);
                Console.WriteLine("Genero: ");
                string genero = Console.ReadLine();
                Console.WriteLine("Album: ");
                string album = Console.ReadLine();
                Album album2 = AgregarAlbum(album, cantante2);
                Console.WriteLine("Estudio: ");
                string estudio = Console.ReadLine();
                Console.WriteLine("Discografia: ");
                string discografia = Console.ReadLine();
                Console.WriteLine("Compositor: ");
                string compositor = Console.ReadLine();
                Compositor compositor2 = AgregarCompositor(compositor);
                Console.WriteLine("Año de Publicación: ");
                int añoPublicacion = Convert.ToInt32(Console.ReadLine());
                Cancion cancion = new Cancion(nombre, cantante2, album2,  genero, estudio, discografia, compositor2, añoPublicacion);
                canciones.Add(cancion);
                this.AgregarCancionCantante(cancion, cantante);
                this.AgregarCancionCompositor(cancion, compositor);
                this.AgregarCancionAlbum(cancion, album);
                this.AgregarAlbumCantante(album2, cantante);
                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("CANCIÓN AGREGADA"); Console.BackgroundColor = ConsoleColor.Black; Console.WriteLine(Environment.NewLine);
                Console.WriteLine("¿Desea agregar otra canción? (s/n)");
                string eleccion = Console.ReadLine();
                if (eleccion == "n") { Thread.Sleep(1000); break; }
                Console.Clear();
            }
        }

        public void MostarCanciones() // Display de info canciones
        {
            foreach(Cancion cancion in canciones)
            {
                Console.BackgroundColor = ConsoleColor.Gray;  Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                cancion.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }
        public void MostarCantantes() // Display de info de cantantes
        {
            foreach(Cantante cantante in cantantes)
            {
                Console.BackgroundColor = ConsoleColor.Gray; Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                cantante.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public void MostarAlbums() //Display de info de albums
        {
            foreach (Album album in albums)
            {
                Console.BackgroundColor = ConsoleColor.Gray; Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                album.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }
    }
}
