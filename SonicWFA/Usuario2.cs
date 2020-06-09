using System;
using System.Collections.Generic;
using System.Threading;

namespace SonicWFA
{
    [Serializable]
    public class Usuario2 : Persona
    {
        public string nombreDeUsuario;
        public string apellido;
        public string tipoUsuario;
        public string privacidad;
        public string contraseña;
        string gustos;
        List<Cancion> descargas = new List<Cancion>();
        List<Cancion> favoritosCancion = new List<Cancion>();
        List<Video> favoritosVideo = new List<Video>();
        public List<Busqueda> busquedasInteligentes = new List<Busqueda>();

        //-- DATOS REPRODUCTOR --
        public ArchivoMultimedia archivoReproduccion;
        public int tiempoReproduccion;
        public List<Cancion> colaCanciones = new List<Cancion>();
        public List<Video> colaVideos = new List<Video>();

        // -- LISTAS SEGUIR --
        List<Usuario2> seguirUsuario = new List<Usuario2>();
        List<Playlist> seguirPlaylist = new List<Playlist>();
        List<Cantante> seguirCantante = new List<Cantante>();
        List<Actor> seguirActor = new List<Actor>();
        List<Director> seguirDirector = new List<Director>();
        List<Compositor> seguirCompositor = new List<Compositor>();
        List<Album> seguirAlbum = new List<Album>();

        public Usuario2(string nombreDeUsuario, string nombre, string apellido, string contraseña, string privacidad, string tipoUsaurio) // Constructor Usuario
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.privacidad = privacidad;
            this.tipoUsuario = tipoUsaurio;
        }

        public void CambiarInfo(string nombreDeUsuario, string nombre, string apellido, string contraseña, string privacidad, string gustos) // Cambia el nombre y apellido de este usuario
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.privacidad = privacidad;
            this.gustos = gustos;
        }

        public void AgregarCancionDescargada(Cancion cancion) //Agregar cancion a lista de descargas
        {
            
            bool state = false;
            foreach(Cancion cancion2 in descargas) { if (cancion.nombre == cancion2.nombre) { state = true; break; } }
            if (state)
            {
                Console.WriteLine("La canción "+cancion.nombre +" ya se encuentra en tus descargas");
                Thread.Sleep(2000);
            } else
            {
                this.descargas.Add(cancion);
                Console.WriteLine("\n Se ha descargado la cancion " + cancion.nombre);
                Thread.Sleep(2000);
            }
        }

        public void VerCancionesDescargadas() //Ver canciones descargadas del usuario
        {
            int contador = 1;
            if (descargas.Count == 0)
            {
                Console.WriteLine("No hay canciones descargadas.");
            }
            else
            {
                Console.WriteLine(descargas.Count + "canciones descargadas: ");
                foreach (Cancion cancion in descargas)
                {
                    Console.WriteLine(contador);
                    cancion.ObtenerInfo();
                    contador++;
                }
            }
        }

        public void SeguimientoPlaylist(Playlist playlist) { seguirPlaylist.Add(playlist); } 
        public void NoSeguimientoPlaylist(Playlist playlist) { seguirPlaylist.Remove(playlist); } 
        public void SeguimientoCantante(Cantante cantante) { seguirCantante.Add(cantante); } 
        public void NoSeguimientoCantante(Cantante cantante) { seguirCantante.Remove(cantante); } 
        public void SeguimientoActor(Actor actor) { seguirActor.Add(actor); } 
        public void NoSeguimientoActor(Actor actor) { seguirActor.Remove(actor); } 
        public void SeguimientoUsuario(Usuario2 usuario) { seguirUsuario.Add(usuario); } 
        public void NoSeguimientoUsuario(Usuario2 usuario) { seguirUsuario.Remove(usuario); } 
        public void SeguimientoDirector(Director director) { seguirDirector.Add(director); } 
        public void NoSeguimientoDirector(Director director) { seguirDirector.Remove(director); } 
        public void SeguimientoCompositor(Compositor compositor) { seguirCompositor.Add(compositor); } 
        public void NoSeguimientoCompositor(Compositor compositor) { seguirCompositor.Remove(compositor); } 
        public void SeguimientoAlbum(Album album) { seguirAlbum.Add(album); } 
        public void NoSeguimientoAlbum(Album album) { seguirAlbum.Remove(album); }

        

        public void InformacionUsuarioSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("\nLos Usuarios que sigues son:");

            foreach (var i in seguirUsuario)
            {
                Console.WriteLine(i.nombreDeUsuario);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun usuario"); }
        }

        public void InformacionPlaylistSeguidor()
        {
            int contador = 0;

            Console.WriteLine("\nLas Playlists que sigues son:");

            foreach (var i in seguirPlaylist)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ninguna playlist"); }
        }


        public void InformacionCantanteSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("\nLos Cantantes que sigues son:");

            foreach (var i in seguirCantante)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Cantante"); }
        }

        public void InformacionActorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("\nLos Actores que sigues son:");

            foreach (var i in seguirActor)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Actor"); }
        }

        public void InformacionDirectorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("\nLos Directores que sigues son:");

            foreach (var i in seguirDirector)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Director"); }
        }

        public void InformacionCompositorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("\nLos Compositores que sigues son:");

            foreach (var i in seguirCompositor)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Compositor"); }
        }

        public void InformacionAlbumSeguidor()
        {
            int contador = 0;

            Console.WriteLine("\nLos Albums que sigues son:");

            foreach (var i in seguirAlbum)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun album"); }
        }

        public void AgregarCancionFavoritos(Cancion cancion){
            bool cancionEnFavoritos = false;
            if (favoritosCancion != null)
            {
                foreach (Cancion cancion1 in favoritosCancion)
                {
                    if (cancion.nombre == cancion1.nombre) { Console.WriteLine("\nCancion ya se encuentra en favoritos"); Thread.Sleep(1500); cancionEnFavoritos = true; break; }
                }
            }
            if (!cancionEnFavoritos) { this.favoritosCancion.Add(cancion); Console.WriteLine("\nCancion agregada con exito"); Thread.Sleep(1500); }
        }

        public void AgregarVideoFavoritos(Video video)
        {
            bool videoEnFavoritos = false;
            if (favoritosVideo != null)
            {
                foreach (Video video1 in favoritosVideo)
                {
                    if (video.nombre == video1.nombre) { Console.WriteLine("\nVideo ya se encuentra en favoritos"); Thread.Sleep(1500); videoEnFavoritos = true; break; }
                }
            }
            if (!videoEnFavoritos) { this.favoritosVideo.Add(video); Console.WriteLine("\nVideo agregado con exito"); Thread.Sleep(1500); }
        }
    }
}
