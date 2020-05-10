﻿using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    [Serializable]
    public class Usuario : Persona
    {
        public string nombreDeUsuario;
        string apellido;
        string tipoUsuario;
        public string privacidad;
        public string contraseña;
        List<string> gustos = new List<string>();
        List<Cancion> descargas = new List<Cancion>();
        List<Cancion> FavoritosCancion;
        List<Video> FavoritosVideo;
        public List<Cancion> cancionesDescargadas = new List<Cancion>();


        //-- DATOS REPRODUCTOR --
        public ArchivoMultimedia archivoReproduccion;
        public int tiempoReproduccion;
        public List<Cancion> colaCanciones = new List<Cancion>();
        public List<Video> colaVideos = new List<Video>();

        List<Usuario> seguirUsuario = new List<Usuario>();
        // List<Playlist> seguirPlaylist; Aun no esta creada
        // List<Disco> seguirDisco; Aparece en el enunciado
        List<Cantante> seguirCantante = new List<Cantante>();
        List<Actor> seguirActor = new List<Actor>();
        List<Director> seguirDirector = new List<Director>();
        List<Compositor> seguirCompositor = new List<Compositor>();
        // List<Album> seguirAlbum; Nose si va esto

        public Usuario(string nombreDeUsuario, string nombre, string apellido, string contraseña, string privacidad, string tipoUsaurio) // Constructor Usuario
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.privacidad = privacidad;
            this.tipoUsuario = tipoUsaurio;
        }

        public void CambiarNombre() // Cambia el nombre y apellido de este usuario
        {
            Console.WriteLine("Nombre nuevo: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Apellido nuevo: ");
            this.apellido = Console.ReadLine();
        }

        public void CambiarContraseña() // Cambia la contraseña de este usuario
        {
            Console.WriteLine("Contraseña Nueva:");
            this.contraseña = Console.ReadLine();
        }

        public void CambiarPrivacidad() // Cambia la privacidad de este usuario
        {
            Console.WriteLine("Seleccione Privacidad:");
            Console.WriteLine("1. Publico");
            Console.WriteLine("2. Privado");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    this.privacidad = "Publico";
                    break;
                case 2:
                    this.privacidad = "Privado";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        public void AgregarGusto(string genero) { this.gustos.Add(genero); } // Agrega los gustos seleccionados a este usuario

        public void ObtenerInformacion() // Obtiene la info del perfil de este usuario
        {
            Console.WriteLine("Nombre de Usuario: " + this.nombreDeUsuario);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Tipo de Usuario: " + this.tipoUsuario);
            Console.WriteLine("Privacidad: " + this.privacidad);
            Console.WriteLine("Gustos: ");
            foreach (string gusto in gustos) { Console.Write(gusto + ", "); }

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

        // public void Seguimiento(Object objeto) {seguir.Add(objeto);} Primera forma ==> REVISAR para no repetir tanto codigo //BORRAR POST EXPLICACION

        // public void SeguimientoPlaylist(Playlist playlist) { seguirPlaylist.Add(playlist); } //FALTA

        // public void NoSeguimientoPlaylist(Playlist playlist) { seguirPlaylist.Remove(playlist); } //FALTA

        // public void SeguimientoDisco(Disco disco) { seguirDisco.Add(disco); } //FALTA

        // public void NoSeguimientoDisco(Disco disco) { seguirDisco.Remove(disco); } //FALTA

        public void SeguimientoCantante(Cantante cantante) { seguirCantante.Add(cantante); } //LISTO

        public void NoSeguimientoCantante(Cantante cantante) { seguirCantante.Remove(cantante); } //LISTO

        public void SeguimientoActor(Actor actor) { seguirActor.Add(actor); } //LISTO

        public void NoSeguimientoActor(Actor actor) { seguirActor.Remove(actor); } //LISTO

        public void SeguimientoUsuario(Usuario usuario) { seguirUsuario.Add(usuario); } //LISTO

        public void NoSeguimientoUsuario(Usuario usuario) { seguirUsuario.Remove(usuario); } //LISTO

        public void SeguimientoDirector(Director director) { seguirDirector.Add(director); } //LISTO

        public void NoSeguimientoDirector(Director director) { seguirDirector.Remove(director); } //LISTO

        public void SeguimientoCompositor(Compositor compositor) { seguirCompositor.Add(compositor); } //LISTO

        public void NoSeguimientoCompositor(Compositor compositor) { seguirCompositor.Remove(compositor); } //LISTO

        // public void SeguimientoAlbum(Album album) { seguirAlbum.Add(album); } //FALTA

        // public void NoSeguimientoAlbum(Album album) { seguirAlbum.Remove(album); } //FALTA

        

        public void InformacionUsuarioSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Usuarios que sigues son:");

            foreach (var i in seguirUsuario)
            {
                Console.WriteLine(i.nombreDeUsuario);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun usuario"); }
        }

        // public void InformacionPlaylistSeguidor() //FALTA

        // public void InformacionDiscoSeguidor() //FALTA

        public void InformacionCantanteSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Cantantes que sigues son:");

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

            Console.WriteLine("Los Actores que sigues son:");

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

            Console.WriteLine("Los Directores que sigues son:");

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

            Console.WriteLine("Los Compositor que sigues son:");

            foreach (var i in seguirCompositor)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Compositor"); }
        }
        // public void InformacionAlbumSeguidor() //FALTA
    }
}
