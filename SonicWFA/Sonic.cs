using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace SonicWFA
{
    public class Sonic
    {
        public List<Admin> administradores = new List<Admin>(); //Creacion lista admin con un default
        public List<Usuario2> usuarios = new List<Usuario2>(); //Creacion lista Usuarios
        public List<Cancion> canciones = new List<Cancion>(); //Creacion lista de canciones
        public List<Cantante> cantantes = new List<Cantante>(); //Creacion lista cantantes
        public List<Album> albums = new List<Album>(); //Creacion lista albums
        public List<Compositor> compositores = new List<Compositor>(); //Creacion lista compositores
        public List<Video> videos = new List<Video>(); // Creacion lista de videos
        public List<Actor> actores = new List<Actor>(); //Creacion lista actores
        public List<Director> directores = new List<Director>(); //Creacion lista directores
        public List<Playlist> playlists = new List<Playlist>();
        public List<Cancion> cancionesBusqueda = new List<Cancion>();
        public List<Video> videosBusqueda = new List<Video>();
        public List<Publicidad> publicidades = new List<Publicidad>();
        private string perfilActual; //Saber en que perfil esta la sesion actual

        Usuario2 usuarioPrueba = new Usuario2("rodrigoguzman1", "Rodrigo", "Guzman", "1234", "Publico", "Gratis");
        
        public void GuardarDatos() //Guardar datos al cerrar aplicacion
        {
            IFormatter formatter = new BinaryFormatter();
            if (canciones.Count != 0)
            {
                Stream stream3 = new FileStream("canciones.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream3, canciones);
                stream3.Close();
            }
            if (usuarios.Count != 0)
            {
                Stream stream2 = new FileStream("usuarios.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream2, usuarios);
                stream2.Close();
            }
            if (administradores.Count != 0)
            {
                Stream stream1 = new FileStream("administradores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream1, administradores);
                stream1.Close();
            }
            if (albums.Count != 0)
            {
                Stream stream4 = new FileStream("albums.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream4, albums);
                stream4.Close();
            }
            if (compositores.Count != 0)
            {
                Stream stream5 = new FileStream("compositores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream5, compositores);
                stream5.Close();
            }
            if (cantantes.Count != 0)
            {
                Stream stream6 = new FileStream("cantantes.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream6, cantantes);
                stream6.Close();
            }
            if (videos.Count != 0)
            {
                Stream stream7 = new FileStream("videos.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream7, videos);
                stream7.Close();
            }
            if (actores.Count != 0)
            {
                Stream stream8 = new FileStream("actores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream8, actores);
                stream8.Close();
            }
            if (directores.Count != 0)
            {
                Stream stream9 = new FileStream("directores.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream9, directores);
                stream9.Close();
            }
            if (playlists.Count != 0)
            {
                Stream stream10 = new FileStream("playlists.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream10, playlists);
                stream10.Close();
            }
            if (publicidades.Count != 0)
            {
                Stream stream11 = new FileStream("publicidades.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream11, publicidades);
                stream11.Close();
            }

        }

        public void CargarDatos() //Cargar Datos al abrir aplicacion
        {
            if (File.Exists("administradores.bin")) { CargarAdmins(); }
            if (File.Exists("canciones.bin")) { CargarCanciones(); }
            if (File.Exists("albums.bin")) { CargarAlbums(); }
            if (File.Exists("compositores.bin")) { CargarCompositores(); }
            if (File.Exists("cantantes.bin")) { CargarCantantes(); }
            if (File.Exists("usuarios.bin")) { CargarUsuarios(); }
            if (File.Exists("directores.bin")) { CargarDirectores(); }
            if (File.Exists("videos.bin")) { CargarVideos(); }
            if (File.Exists("actores.bin")) { CargarActores(); }
            if (File.Exists("playlists.bin")) { CargarPlaylists(); }
            if (File.Exists("publicidades.bin")) { CargarPublicidades(); }
        }
        
        public void CargarAdmins() //Cargar administradores
        {
            IFormatter formatter1 = new BinaryFormatter();
            Stream stream1 = new FileStream("administradores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            administradores = (List<Admin>)formatter1.Deserialize(stream1);
            stream1.Close();
        }
        public void CargarUsuarios() //Cargar usuarios
        {
            IFormatter formatter2 = new BinaryFormatter();
            Stream stream2 = new FileStream("usuarios.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            usuarios = (List<Usuario2>)formatter2.Deserialize(stream2);
            stream2.Close();
        }
        public void CargarCanciones() //Cargar canciones
        {
            IFormatter formatter3 = new BinaryFormatter();
            Stream stream3 = new FileStream("canciones.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            canciones = (List<Cancion>)formatter3.Deserialize(stream3);
            stream3.Close();
        }
        public void CargarAlbums() //Cargar albums
        {
            IFormatter formatter4 = new BinaryFormatter();
            Stream stream4 = new FileStream("albums.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            albums = (List<Album>)formatter4.Deserialize(stream4);
            stream4.Close();
        }
        public void CargarCompositores() //Cargar compositores
        {
            IFormatter formatter5 = new BinaryFormatter();
            Stream stream5 = new FileStream("compositores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            compositores = (List<Compositor>)formatter5.Deserialize(stream5);
            stream5.Close();
        }
        public void CargarCantantes() //Cargar cantantes
        {
            IFormatter formatter6 = new BinaryFormatter();
            Stream stream6 = new FileStream("cantantes.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            cantantes = (List<Cantante>)formatter6.Deserialize(stream6);
            stream6.Close();
        }
        public void CargarVideos() //Cargar videos
        {
            IFormatter formatter7 = new BinaryFormatter();
            Stream stream7 = new FileStream("videos.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            videos = (List<Video>)formatter7.Deserialize(stream7);
            stream7.Close();
        }
        public void CargarActores() //Cargar actores
        {
            IFormatter formatter8 = new BinaryFormatter();
            Stream stream8 = new FileStream("actores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            actores = (List<Actor>)formatter8.Deserialize(stream8);
            stream8.Close();
        }
        public void CargarDirectores() //Cargar directores
        {
            IFormatter formatter9 = new BinaryFormatter();
            Stream stream9 = new FileStream("directores.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            directores = (List<Director>)formatter9.Deserialize(stream9);
            stream9.Close();
        }
        public void CargarPlaylists() //Cargar directores
        {
            IFormatter formatter10 = new BinaryFormatter();
            Stream stream10 = new FileStream("playlists.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            playlists = (List<Playlist>)formatter10.Deserialize(stream10);
            stream10.Close();
        }
        public void CargarPublicidades() //Cargar directores
        {
            IFormatter formatter11 = new BinaryFormatter();
            Stream stream11 = new FileStream("publicidades.bin", FileMode.Open, FileAccess.Read, FileShare.Read);
            publicidades = (List<Publicidad>)formatter11.Deserialize(stream11);
            stream11.Close();
        }


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

        public bool Registrarse(string nombreDeUsuario, string nombre, string apellido, string contraseña, string tipoUsuario, string privacidad) //Metodo para registrarse como usuario
        {
            Usuario2 usuario = new Usuario2(nombreDeUsuario, nombre, apellido, contraseña, privacidad, tipoUsuario);
            bool UsuarioRegistrado = false;
            foreach (Usuario2 Listausuario in usuarios)
            {
                if (usuario.nombreDeUsuario == Listausuario.nombreDeUsuario){UsuarioRegistrado = true;break;} else {UsuarioRegistrado = false;}
            }
            if (UsuarioRegistrado)
            {
                return false;

            } else
            {
                usuarios.Add(usuario);
                return true;
            }
        }

        public Usuario2 IniciarSesion(string nombreDeUsuario, string contraseña) //Metodo para iniciar sesión como usuario
        {
            usuarios.Add(usuarioPrueba);

            if (usuarios.Count == 0)
            {
                Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("DEBES REGISTRAR UN USUARIO PRIMERO"); Console.BackgroundColor = ConsoleColor.Black;
                Thread.Sleep(2000);
                return null;
            }
            else
            {
                foreach (Usuario2 usuario in usuarios)
                {
                    if (usuario.nombreDeUsuario == nombreDeUsuario && usuario.contraseña == contraseña)
                    {
                        perfilActual = usuario.nombreDeUsuario;
                        return usuario;
                    }
                }
                
                return null;
            }

            
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

        public void ImportarCanciones(string nombre, string cantante, string genero, string album, string estudio, string discografia, string compositor, int añoPublicacion, int duracionMinutos, int duracionSegundos) //Metadata de Importacion
        {
            
                Cantante cantante2 = AgregarCantante(cantante);
                Album album2 = AgregarAlbum(album, cantante2);
                Compositor compositor2 = AgregarCompositor(compositor);
                int duracion = (duracionMinutos * 60 + duracionSegundos);
                Cancion cancion = new Cancion(nombre, cantante2, album2,  genero, estudio, discografia, compositor2, añoPublicacion, duracion);
                canciones.Add(cancion);
                this.AgregarCancionCantante(cancion, cantante);
                this.AgregarCancionCompositor(cancion, compositor);
                this.AgregarCancionAlbum(cancion, album);
                this.AgregarAlbumCantante(album2, cantante);
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

        public Actor AgregarActor(string nombreActor) // Agregar un Actor
        {
            foreach (Actor actor1 in actores)
            {
                if (actor1.nombre == nombreActor) { return actor1; }
            }
            Actor actor = new Actor(nombreActor);
            actores.Add(actor);
            return actor;
        }

        public Director AgregarDirector(string nombreDirector) // Agregar un Director
        {
            foreach (Director director1 in directores)
            {
                if (director1.nombre == nombreDirector) { return director1; }
            }
            Director director = new Director(nombreDirector);
            directores.Add(director);
            return director;
        }

        public void AgregarVideoActor(Video video, string nombreActor) // Agregar un video a un actor
        {
            foreach (Actor actor in actores)
            {
                if (actor.nombre == nombreActor) { actor.AgregarVideo(video); break; }
            }
        }

        public void AgregarVideoDirector(Video video, string nombreDirector) // Agregar un video a un director
        {
            foreach (Director director in directores)
            {
                if (director.nombre == nombreDirector) { director.AgregarVideo(video); break; }
            }
        }

        public void ImportarVideos() //Metadata de importacion
        {
            while (true)
            {
                Console.WriteLine("AGREGUE VIDEO");
                Console.WriteLine("Titulo: ");
                string titulo = Console.ReadLine();
                Console.WriteLine("Categoria: ");
                string categoria = Console.ReadLine();
                Console.WriteLine("Genero: ");
                string genero = Console.ReadLine();
                Console.WriteLine("Estudio: ");
                string estudio = Console.ReadLine();
                Console.WriteLine("Director: ");
                string director = Console.ReadLine();
                Director director1 = AgregarDirector(director);
                Console.WriteLine("Descripción: ");
                string descripcion = Console.ReadLine();
                Console.WriteLine("Año de Publicacion: ");
                int añoDePublicacion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Resolucion (numero): ");
                int resolucion = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Duración (minutos): ");
                int duracionMinutos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Duración (segundos): ");
                int duracionSegundos = Convert.ToInt32(Console.ReadLine());
                int duracion = (duracionMinutos * 60 + duracionSegundos);
                List<Actor> actores1 = new List<Actor>();
                Console.WriteLine("Actores: ");
                while (true)
                {
                    Console.WriteLine("Nombre: ");
                    string actor = Console.ReadLine();
                    Actor actor1 = new Actor(actor);
                    actores1.Add(actor1);
                    AgregarActor(actor);
                    Console.WriteLine("¿Desea añadir a otro actor a este video? (s/n)");
                    string eleccion1 = Console.ReadLine();
                    if (eleccion1 == "n") { break; }
                }

                Video video = new Video(titulo, categoria, genero, estudio, director1, descripcion, actores1, añoDePublicacion, duracion, resolucion);
                videos.Add(video);
                foreach(Actor actor in actores1) { AgregarVideoActor(video, actor.nombre); }
                this.AgregarVideoDirector(video, director);
                Console.BackgroundColor = ConsoleColor.Green; Console.WriteLine("VIDEO AGREGADO"); Console.BackgroundColor = ConsoleColor.Black; Console.WriteLine(Environment.NewLine);
                Console.WriteLine("¿Desea agregar otro video? (s/n)");
                string eleccion2 = Console.ReadLine();
                if (eleccion2 == "n") { Thread.Sleep(1000); break; }
                Console.Clear();
            }
        }

        public void MostarVideos() // Display de info videos
        {
            foreach (Video video in videos)
            {
                Console.BackgroundColor = ConsoleColor.Gray; Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                video.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public void MostarActores() // Display de info de cantantes
        {
            foreach (Actor actor in actores)
            {
                Console.BackgroundColor = ConsoleColor.Gray; Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                actor.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public void MostarDirectores() //Display de info de albums
        {
            foreach (Director director in directores)
            {
                Console.BackgroundColor = ConsoleColor.Gray; Console.WriteLine("-------------------------------------"); Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine(Environment.NewLine);
                director.ObtenerInfo();
                Console.WriteLine(Environment.NewLine);
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public void BuscarPorCategoria(string categoria)
        {
            foreach(Video video in videos)
            {
                if (video.categoria.Contains(categoria))
                {
                    if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); }
                }   
            }
        }

        public void BuscarPorEvaluacion(string condicion, int valor)
        {
            foreach (Cancion cancion in canciones)
            {
                if (condicion == "mayor")
                {
                    if(cancion.calificacion > valor) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                }
                else if (condicion == "menor")
                {
                    if (cancion.calificacion < valor) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                }
                else if (condicion == "igual")
                {
                    if (cancion.calificacion == valor) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                }
            }
            foreach (Video video in videos)
            {
                if (condicion == "mayor")
                {
                    if (video.calificacion > valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
                else if (condicion == "menor")
                {
                    if (video.calificacion < valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
                else if (condicion == "igual")
                {
                    if (video.calificacion == valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
            }
        }


        public bool VerificarCancionEnBusqueda(Cancion cancion)
        {
            foreach(Cancion cancion1 in cancionesBusqueda)
            {
                if(cancion1.nombre == cancion.nombre) { return true; }
            }
            return false;
        }

        public bool VerificarVideoEnBusqueda(Video video)
        {
            foreach (Video video1 in videosBusqueda)
            {
                if (video1.nombre == video.nombre) { return true; }
            }
            return false;
        }

        public void BuscarPorPalabra(string palabra)
        {
            foreach(Cancion cancion in canciones)
            {
                if (cancion.nombre.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (cancion.genero.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (cancion.estudio.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (cancion.discografia.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (cancion.album.nombre.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (cancion.compositor.nombre.Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
                if (Convert.ToString(cancion.añoPublicacion).Contains(palabra)) { if (!VerificarCancionEnBusqueda(cancion)) { cancionesBusqueda.Add(cancion); } }
            }

            foreach(Video video in videos)
            {
                if (video.nombre.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                if (video.genero.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                if (video.estudio.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                if (video.director.nombre.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                if (video.descripcion.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                if (Convert.ToString(video.añoPublicacion).Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                foreach(Actor actor in video.actores) { if(actor.nombre.Contains(palabra)) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } } }
            }
        }

        public void BuscarPorResolucion(string condicion, int valor)
        {
            foreach (Video video in videos)
            {
                if (condicion == "mayor")
                {
                    if (video.resolucion > valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
                else if (condicion == "menor")
                {
                    if (video.resolucion < valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
                else if (condicion == "igual")
                {
                    if (video.resolucion == valor) { if (!VerificarVideoEnBusqueda(video)) { videosBusqueda.Add(video); } }
                }
            }
        }

        public void GuardarBusqueda(List<Action> busqueda)
        {
            Usuario2 usuarioActual = UsuarioActual();
            Console.WriteLine("Nombre de Busqueda Inteligente: ");
            string nombre = Console.ReadLine();
            Busqueda busqueda1 = new Busqueda(nombre, busqueda);
            usuarioActual.busquedasInteligentes.Add(busqueda1);
            Console.WriteLine("Busqueda Inteligente guardada");
            Thread.Sleep(1500);
        }

        public void RealizarBusqueda()
        {
            Usuario2 usuarioActual = UsuarioActual();
            Console.WriteLine("Seleccione Busqueda: ");
            int i = 1;
            foreach(Busqueda busqueda in usuarioActual.busquedasInteligentes)
            {
                Console.WriteLine(i + ". " + busqueda.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach(Busqueda busqeuda1 in usuarioActual.busquedasInteligentes)
            {
                if(i == eleccion)
                {
                    foreach(Action funcion in busqeuda1.busquedas)
                    {
                        funcion();
                    }
                    break;
                }
                i++;
            }
            int j = 1;
            Console.Clear();
            if (cancionesBusqueda.Count != 0)
            {
                Console.WriteLine("Canciones: ");
                foreach (Cancion cancion in cancionesBusqueda)
                {
                    Console.WriteLine("\n" + j + ". \n");
                    cancion.ObtenerInfo();
                    j++;
                }
            }
            j = 1;
            if (videosBusqueda.Count != 0)
            {
                Console.WriteLine("Videos: ");
                foreach (Video video in videosBusqueda)
                {
                    Console.WriteLine("\n"+j + ". \n");
                    video.ObtenerInfo();
                    j++;
                }
            }
            if (videosBusqueda.Count == 0 && cancionesBusqueda.Count == 0) { Console.WriteLine(Environment.NewLine); Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("NO HAY RESULTADOS"); Console.BackgroundColor = ConsoleColor.Black; }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
            cancionesBusqueda.Clear();
            videosBusqueda.Clear();
        }

        public string Buscar(string palabra = "qwery", string persona = "qwery", int eleccion3 = 0, int valor = 0, int eleccion7 = 0, int valor2 = 0, string categoria = "qwery")
        {
            string resultado = "";

            List<Action> busquedas = new List<Action>();

            BuscarPorPalabra(palabra);
            busquedas.Add(() => BuscarPorPalabra(palabra));

            BuscarPorPalabra(persona);
            busquedas.Add(() => BuscarPorPalabra(persona));

            Console.WriteLine("1. Mayor\n2. Menor\n3. Igual");
            Console.WriteLine("Valor: ");
            if (eleccion3 == 1) { BuscarPorEvaluacion("mayor", valor); busquedas.Add(() => BuscarPorEvaluacion("mayor", valor)); }
            else if (eleccion3 == 2) { BuscarPorEvaluacion("menor", valor); busquedas.Add(() => BuscarPorEvaluacion("menor", valor)); }
            else if (eleccion3 == 3) { BuscarPorEvaluacion("igual", valor); busquedas.Add(() => BuscarPorEvaluacion("igual", valor)); }

            Console.WriteLine("1. Mayor\n2. Menor\n3. Igual");
            Console.WriteLine("Valor: ");
            if (eleccion7 == 1) { BuscarPorResolucion("mayor", valor2); busquedas.Add(() => BuscarPorResolucion("mayor", valor2)); }
            else if (eleccion7 == 2) { BuscarPorResolucion("menor", valor2); busquedas.Add(() => BuscarPorResolucion("menor", valor2)); }
            else if (eleccion7 == 3) { BuscarPorResolucion("igual", valor2); busquedas.Add(() => BuscarPorResolucion("igual", valor2)); }

            BuscarPorCategoria(categoria);
            busquedas.Add(() => BuscarPorCategoria(categoria));


            if (cancionesBusqueda.Count != 0)
            {
                foreach (Cancion cancion in cancionesBusqueda)
                {

                    resultado += cancion.ObtenerInfo();
                }
            }
            if (videosBusqueda.Count != 0)
            {
                foreach (Video video in videosBusqueda)
                {
                    resultado += video.ObtenerInfo();
                }
            }

            if(videosBusqueda.Count == 0 && cancionesBusqueda.Count == 0) { return "NO HAY RESULTADOS"; }
            cancionesBusqueda.Clear();
            videosBusqueda.Clear();
            return resultado;
        }

        public void AgregarCancionAFavoritos()
        {
            Usuario2 usuarioActual = UsuarioActual();
            Cancion cancion = SeleccionarCancion();
            usuarioActual.AgregarCancionFavoritos(cancion);
        }

        public void AgregarVideoAFavoritos()
        {
            Usuario2 usuarioActual = UsuarioActual();
            Video video = SeleccionarVideo();
            usuarioActual.AgregarVideoFavoritos(video);
        }


        public void AgregarImagenCancion() //Agregar una imagen a una cancion
        {
            Console.WriteLine("Nombre de la Cancion:");
            string nombreCancion = Console.ReadLine();

            string eleccion = null;

            foreach (var i in canciones)
            {
                if(nombreCancion == i.nombre)
                {
                    Console.WriteLine("\nQue extension desea usar para esta imagen:" +
                                  "\n[1] .png" +
                                  "\n[2] .jpg" +
                                  "\n[3] .jpeg");

                    eleccion = Console.ReadLine();

                    if (CambiarImagenCancion(i)) { eleccion = "0"; }

                    switch (eleccion)
                    {
                        case "1":

                            i.ImagenCancion($"{nombreCancion}.png");
                            Console.WriteLine("La imagen ha sido guardada exitosamente");
                            break;

                        case "2":

                            i.ImagenCancion($"{nombreCancion}.jpg");
                            Console.WriteLine("La imagen ha sido guardada exitosamente");
                            break;

                        case "3":

                            i.ImagenCancion($"{nombreCancion}.jpeg");
                            Console.WriteLine("La imagen ha sido guardada exitosamente");
                            break;
                    }
                }
            }
            Thread.Sleep(1000);
            if(eleccion == null) { Console.WriteLine("No existen caciones con ese nombre para guardar la imagen"); Thread.Sleep(1000); }
        }

        public void AgregarImagenVideo() //Agregar una imagen a un video
        {
            Console.WriteLine("Nombre del video:");
            string nombreVideo = Console.ReadLine();

            string eleccion = null;

            foreach (var i in videos)
            {
                if (nombreVideo == i.nombre)
                {
                    Console.WriteLine("\nQue extension desea usar para esta imagen:" +
                                  "\n[1] .mp4" +
                                  "\n[2] .wav");

                    eleccion = Console.ReadLine();

                    if(CambiarImagenVideo(i)){ break; }

                    switch (eleccion)
                    {
                        case "1":

                            i.ImagenVideo($"{nombreVideo}.mp4");
                            Console.WriteLine("La imagen ha sido guardada exitosamente");
                            break;

                        case "2":

                            i.ImagenVideo($"{nombreVideo}.wav");
                            Console.WriteLine("La imagen ha sido guardada exitosamente");
                            break;
                    }
                }
            }
            Thread.Sleep(1000);
            if (eleccion == null) { Console.WriteLine("No existen videos con ese nombre para guardar la imagen"); Thread.Sleep(1000); }
        }

        public bool CambiarImagenCancion(Cancion cancion) //Cambiar imagen de cancion
        {
            string variable;

            if(cancion.imagen != null)
            {
                Console.WriteLine("La cancion ya tiene una imagen");
                Console.WriteLine("\nDesea cambiar la imagen?" +
                                  "\n[1] Si" +
                                  "\n[2] No");

                variable = Console.ReadLine();

                switch (variable)
                {
                    case "1":
                        return false;
                    case "2":
                        Console.WriteLine("Imagen no cambiada");
                        return true;
                }
            }
            return false;
        }

        public bool CambiarImagenVideo(Video video) //Cambiar imagen de video
        {
            string variable;

            if (video.imagen != null)
            {
                Console.WriteLine("El video ya tiene una imagen");
                Console.WriteLine("\nDesea cambiar la imagen?" +
                                  "\n[1] Si" +
                                  "\n[2] No");

                variable = Console.ReadLine();

                switch (variable)
                {
                    case "1":
                        return false;
                    case "2":
                        Console.WriteLine("Imagen no cambiada");
                        return true;
                }
            }

            return false;
        }

        public void ReproductorPoint() //Bypass a reproductor, entregandole la info
        {
            Usuario2 pasarUsuario = null;
            foreach(Usuario2 usuario in usuarios) { if (usuario.nombreDeUsuario == perfilActual) { pasarUsuario = usuario; } }
            Reproductor.EmpezarReproductor(canciones, videos, pasarUsuario, pasarUsuario.archivoReproduccion, publicidades, pasarUsuario.tiempoReproduccion );
        }

       public void DescargarCancion() //Añadir cancion a descargas
        {
            foreach (Usuario2 usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    if (canciones.Count == 0)
                    {
                        Console.WriteLine("Lo sentimos, no hay canciones disponibles por el momento.");
                        Thread.Sleep(2000);
                        break;
                    }
                    else
                    {
                        bool cancionEncontrada = true;
                        Console.WriteLine("Escriba el nombre de la cancion que desea descargar: ");
                        string cd = Console.ReadLine();

                        foreach (Cancion cancion in canciones)
                        {
                            if (cancion.nombre.Contains(cd))
                            {
                                usuario.AgregarCancionDescargada(cancion);
                               
                                break;
                            }
                            else { cancionEncontrada = false; }

                        }
                        if (!cancionEncontrada) { Console.WriteLine("No hemos encontrado la cancion " + cd); Thread.Sleep(2000); }
                    }
                }
            }
        }

        public void VerDescargas() //Ver descargas
        {
            foreach (Usuario2 usuario in usuarios)
            {
                if (usuario.nombreDeUsuario == perfilActual)
                {
                    usuario.VerCancionesDescargadas();

                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Presiona cualquier tecla para volver atras");
                    Console.ReadKey();
                }
            }
        }

        public void CrearPlaylist() // Crea la playlist
        {
            Console.WriteLine("Ingrese nombre de la Playlist: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Privacidad de la Playlist: ");
            Console.WriteLine("0.- Privada");
            Console.WriteLine("1.- Publica");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            string privacidad;
            if (eleccion == 0 || eleccion == 1 && UsuarioActual().privacidad == "Publico")
            {
                if (eleccion == 0)
                {
                    privacidad = "Privada";
                }
                else
                {
                    privacidad = "Publica";
                }
            }
            else
            {
                Console.WriteLine("Tus playlist solo pueden ser privada debido a que eres un usuario privado");
                Thread.Sleep(1500);
                privacidad = "Privada";
            }
            Playlist playlist = new Playlist(nombre, privacidad);
            playlists.Add(playlist);
            AgregarCancionPlaylist(playlist);
            Console.BackgroundColor = ConsoleColor.Green;  Console.WriteLine("PlAYLIST CREADA"); Console.BackgroundColor = ConsoleColor.Black;
            Thread.Sleep(1500);
        }

        public void AgregarCancionPlaylist(Playlist playlist) // Agrega canciones a la playlist
        {
            string eleccion = "";
            while (eleccion != "n")
            {
                Console.Clear();
                Console.WriteLine("Seleccione cancion que desea ingresar a su Playlist: ");
                Cancion cancion = SeleccionarCancion();
                playlist.AgregarCancion(cancion);
                Console.WriteLine("\nDesea agregar otra cancion? (s/n)");
                eleccion = Console.ReadLine();
            }
        }



        public void VerPlaylists() // Se ven las playlists de todos los usuarios que tienen su playlist como PUBLICA
        {
            Console.WriteLine("\nPlaylists Publicas: ");
            foreach (Playlist playlist in playlists)
            {
                if (playlist.privacidad == "Publica")
                {
                    playlist.Info();
                }
            }
            Console.WriteLine("\nPlaylist Privadas: ");
            foreach (Playlist playlist in playlists)
            {
                if (playlist.privacidad == "Privada")
                {
                    playlist.Info();
                }
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Presiona cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public Cancion SeleccionarCancion()
        {
            int i = 1;
            foreach (Cancion cancion in canciones)
            {
                Console.WriteLine(i + ". " + cancion.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Cancion cancion1 in canciones)
            {
                if (i == eleccion) { return cancion1; }
                i++;
            }
            return null;
        }
        public Video SeleccionarVideo()
        {
            int i = 1;
            foreach (Video video in videos)
            {
                Console.WriteLine(i + ". " + video.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Video videos1 in videos)
            {
                if (i == eleccion) { return videos1; }
                i++;
            }
            return null;
        }

        public Cantante SeleccionarCantante()
        {
            int i = 1;
            foreach(Cantante cantante in cantantes)
            {
                Console.WriteLine(i + ". " + cantante.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Cantante cantante1 in cantantes)
            {
                if(i == eleccion) { return cantante1; }
                i++;
            }
            return null;
        }

        public Actor SeleccionarActor()
        {
            int i = 1;
            foreach (Actor actor in actores)
            {
                Console.WriteLine(i + ". " + actor.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Actor actor1 in actores)
            {
                if (i == eleccion) { return actor1; }
                i++;
            }
            return null;
        }

        public Director SeleccionarDirector()
        {
            int i = 1;
            foreach (Director director in directores)
            {
                Console.WriteLine(i + ". " + director.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Director director1 in directores)
            {
                if (i == eleccion) { return director1; }
                i++;
            }
            return null;
        }

        public Compositor SeleccionarCompositor()
        {
            int i = 1;
            foreach (Compositor compositor in compositores)
            {
                Console.WriteLine(i + ". " + compositor.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Compositor compositor1 in compositores)
            {
                if (i == eleccion) { return compositor1; }
                i++;
            }
            return null;
        }

        public Album SeleccionarAlbum()
        {
            int i = 1;
            foreach (Album album in albums)
            {
                Console.WriteLine(i + ". " + album.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Album album1 in albums)
            {
                if (i == eleccion) { return album1; }
                i++;
            }
            return null;
        }

        public Playlist SeleccionarPlaylist()
        {
            int i = 1;
            foreach (Playlist playlist in playlists)
            {
                Console.WriteLine(i + ". " + playlist.nombre);
                i++;
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Playlist playlist1 in playlists)
            {
                if (i == eleccion) { return playlist1; }
                i++;
            }
            return null;
        }

        public Usuario2 SeleccionarUsuario()
        {
            int i = 1;
            foreach (Usuario2 usuario in usuarios)
            {
                if (usuario.privacidad == "Publico")
                {
                    Console.WriteLine(i +". " + usuario.nombre);
                    i++;
                }
            }
            int eleccion = Convert.ToInt32(Console.ReadLine());
            i = 0;
            foreach (Usuario2 usuario1 in usuarios)
            {
                if (usuario1.privacidad == "Publico") { i++; }
                if (i == eleccion) { return usuario1; }
            }
            return null;
        }

        public void Seguir()
        {
            Console.WriteLine("1. Cantantes" +
                "\n2. Actores" +
                "\n3. Directores" +
                "\n4. Compositores" +
                "\n5. Usuarios" +
                "\n6. Albums" +
                "\n7. Playlist\n");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            Usuario2 usuario = UsuarioActual();
            switch (eleccion)
            {
                case 1:
                    Cantante cantante = SeleccionarCantante();
                    NuevoSeguidorPersona(usuario, cantante);
                    break;
                case 2:
                    Actor actor = SeleccionarActor();
                    NuevoSeguidorPersona(usuario, actor);
                    break;
                case 3:
                    Director director = SeleccionarDirector();
                    NuevoSeguidorPersona(usuario, director);
                    break;
                case 4:
                    Compositor compositor = SeleccionarCompositor();
                    NuevoSeguidorPersona(usuario, compositor);
                    break;
                case 5:
                    Usuario2 usuario1 = SeleccionarUsuario();
                    NuevoSeguidorPersona(usuario, usuario1);
                    break;
                case 6:
                    Album album = SeleccionarAlbum();
                    NuevoSeguidorAlbum(usuario, album);
                    break;
                case 7:
                    Playlist playlist = SeleccionarPlaylist();
                    NuevoSeguidorPlaylist(usuario, playlist);
                    break;
                default:
                    break;
            }
        }

        public Usuario2 UsuarioActual()
        {
            foreach(Usuario2 usuario in usuarios)
            {
                if(usuario.nombreDeUsuario == perfilActual) { return usuario; }
            }
            return null;
        }

        public void NuevoSeguidorPersona(Usuario2 usuario, Persona persona)
        {
            int contador = 0;
            foreach (var i in persona.seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al " + persona.GetType().Name);
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                persona.NuevoSeguidor(usuario);
                persona.numeroSeguidores++;
                if (persona.GetType().Name == "Cantante") { var persona1 = (Cantante)persona;  usuario.SeguimientoCantante(persona1); };
                if (persona.GetType().Name == "Actor") { var persona1 = (Actor)persona; usuario.SeguimientoActor(persona1); };
                if (persona.GetType().Name == "Director") { var persona1 = (Director)persona; usuario.SeguimientoDirector(persona1); };
                if (persona.GetType().Name == "Compositor") { var persona1 = (Compositor)persona; usuario.SeguimientoCompositor(persona1); };
                if (persona.GetType().Name == "Usuario") { var persona1 = (Usuario2)persona; usuario.SeguimientoUsuario(persona1); };
                Console.WriteLine("Has comenzado a seguir al " + persona.GetType().Name);
                Thread.Sleep(1500);
            }
        }

        public void NuevoSeguidorAlbum(Usuario2 usuario, Album album)
        {
            int contador = 0;
            foreach (var i in album.seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al " + album.GetType().Name);
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                album.NuevoSeguidor(usuario);
                album.numeroSeguidores++;
                usuario.SeguimientoAlbum(album);
                Console.WriteLine("Has comenzado a seguir al " + album.GetType().Name);
                Thread.Sleep(1500);
            }
        }

        public void NuevoSeguidorPlaylist(Usuario2 usuario, Playlist playlist)
        {
            int contador = 0;
            foreach (var i in playlist.seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al " + playlist.GetType().Name);
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                playlist.NuevoSeguidor(usuario);
                playlist.numeroSeguidores++;
                usuario.SeguimientoPlaylist(playlist);
                Console.WriteLine("Has comenzado a seguir a la " + playlist.GetType().Name);
                Thread.Sleep(1500);
            }
        }

        public void DejarSeguir()
        {
            Console.WriteLine("1. Cantantes" +
                "\n2. Actores" +
                "\n3. Directores" +
                "\n4. Compositores" +
                "\n5. Usuarios" +
                "\n6. Albums" +
                "\n7. Playlist\n");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            Usuario2 usuario = UsuarioActual();
            switch (eleccion)
            {
                case 1:
                    Cantante cantante = SeleccionarCantante();
                    DejarSeguirPersona(usuario, cantante);
                    break;
                case 2:
                    Actor actor = SeleccionarActor();
                    DejarSeguirPersona(usuario, actor);
                    break;
                case 3:
                    Director director = SeleccionarDirector();
                    DejarSeguirPersona(usuario, director);
                    break;
                case 4:
                    Compositor compositor = SeleccionarCompositor();
                    DejarSeguirPersona(usuario, compositor);
                    break;
                case 5:
                    Usuario2 usuario1 = SeleccionarUsuario();
                    DejarSeguirPersona(usuario, usuario1);
                    break;
                default:
                    break;
            }
        }

        public void DejarSeguirPersona(Usuario2 usuario, Persona persona)
        {
            int contador = 0;
            foreach (var i in persona.seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    persona.EliminarSeguidor(usuario);
                    persona.numeroSeguidores--;
                    if (persona.GetType().Name == "Cantante") { var persona1 = (Cantante)persona; usuario.NoSeguimientoCantante(persona1); };
                    if (persona.GetType().Name == "Actor") { var persona1 = (Actor)persona; usuario.NoSeguimientoActor(persona1); };
                    if (persona.GetType().Name == "Director") { var persona1 = (Director)persona; usuario.NoSeguimientoDirector(persona1); };
                    if (persona.GetType().Name == "Compositor") { var persona1 = (Compositor)persona; usuario.NoSeguimientoCompositor(persona1); };
                    if (persona.GetType().Name == "Usuario") { var persona1 = (Usuario2)persona; usuario.NoSeguimientoUsuario(persona1); };
                    Console.WriteLine("Has dejado de seguir al " + persona.GetType().Name);
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }

            if (contador == 0) { Console.WriteLine("No sigues al " + persona.GetType().Name); Thread.Sleep(1500); }
        }

        public void Calificar()
        {
            Console.WriteLine("1. Canciones" +
                "\n2. Videos");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Cancion cancion = SeleccionarCancion();
                    Console.WriteLine("Califiación del 1 al 10 :");
                    int calificacion = Convert.ToInt32(Console.ReadLine());
                    cancion.RevisionCalificacion(UsuarioActual(), calificacion);
                    cancion.PromedioCalificion();
                    break; 
                case 2:
                    Video video = SeleccionarVideo();
                    Console.WriteLine("Califiación del 1 al 10 :");
                    int calificacion2 = Convert.ToInt32(Console.ReadLine());
                    video.RevisionCalificacion(UsuarioActual(), calificacion2);
                    video.PromedioCalificion();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Thread.Sleep(1500);
                    break;
            }
        }

        public void SacarCalificacion()
        {
            Console.WriteLine("1. Canciones" +
                "\n2. Videos");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Cancion cancion = SeleccionarCancion();
                    cancion.RevisionQuitarCalificacion(UsuarioActual());
                    cancion.PromedioCalificion();
                    break;
                case 2:
                    Video video = SeleccionarVideo();
                    video.RevisionQuitarCalificacion(UsuarioActual());
                    video.PromedioCalificion();
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Thread.Sleep(1500);
                    break;
            }
        }

        public void PonerMeGusta()
        {
            Console.WriteLine("1. Canciones" +
                "\n2. Videos");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Cancion cancion = SeleccionarCancion();
                    cancion.RevisionMeGusta(UsuarioActual());
                    break;
                case 2:
                    Video video = SeleccionarVideo();
                    video.RevisionMeGusta(UsuarioActual());
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Thread.Sleep(1500);
                    break;
            }
        }

        public void SacarMeGusta()
        {
            Console.WriteLine("1. Canciones" +
                "\n2. Videos");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Cancion cancion = SeleccionarCancion();
                    cancion.RevisionQuitarMeGusta(UsuarioActual());
                    break;
                case 2:
                    Video video = SeleccionarVideo();
                    video.RevisionQuitarMeGusta(UsuarioActual());
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    Thread.Sleep(1500);
                    break;
            }
        }

        public void AgregarPublicidad()
        {
            string eleccion;
            string tipo = "";
            int precioPagar = 0;
            int cantidad;
            int cantidadApariciones = 0;
            Console.WriteLine("Precio cada aparicion de Video publicitario----------> $1.000");
            Console.WriteLine("Precio cada aparicion de Imagen publicitaria----------> $500");
            Console.WriteLine("\nQue desea agregar");
            Console.WriteLine("1. Video");
            Console.WriteLine("2. Imagen");
            eleccion = Console.ReadLine();
            Console.WriteLine("\n Nombre publicidad: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Descripción publicidad: ");
            string descripcion = Console.ReadLine();
            Console.WriteLine("\nQue cantidad de repeticiones desea agregar");
            cantidad = int.Parse(Console.ReadLine());

            switch (eleccion)
            {
                case "1":
                    precioPagar = cantidad * 1000;
                    cantidadApariciones = cantidad;
                    tipo = "Video";
                    break;
                case "2":
                    precioPagar = cantidad * 500;
                    cantidadApariciones = cantidad;
                    tipo = "Imagen";
                    break;
                default:
                    break;
            }

            Publicidad publicidad1 = new Publicidad(nombre, tipo, descripcion, cantidadApariciones, precioPagar);
            publicidades.Add(publicidad1);
            publicidad1.PrecioPublicidad();
            if (!publicidad1.PagarPublicidad()) { publicidades.Remove(publicidad1); }
        }

        public void QuitarPublicidad(Publicidad publicidad) { publicidades.Remove(publicidad); }
    }
}
