using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    [Serializable]
    public class Playlist
    {
        public string nombre;
        public string privacidad;
        List<Cancion> playlist = new List<Cancion>();

        public List<Usuario> seguidores = new List<Usuario>();
        public int numeroSeguidores;

        public Playlist(string nombre, string privacidad)
        {
            this.nombre = nombre;
            this.privacidad = privacidad;
        }


        public void Info() // Entrega la info para imprimirla en Sonic
        {
            int contador = 1;
            Console.WriteLine("Nombre Playlist : " + nombre);
            Console.WriteLine("Privacidad: " + privacidad);
            Console.WriteLine(playlist.Count + " canciones: ");
            foreach (Cancion cancion in playlist)
            {
                Console.WriteLine(contador+". "+ cancion.nombre);
                contador++;
            }
        }

        public void AgregarCancion(Cancion cancion) //Aca agrega una cancion que no este ya en la Playlist
        {
            bool cancionEnPlaylist = false;
            foreach (Cancion cancion2 in playlist)
            {
                if (cancion2.nombre == cancion.nombre)
                {
                    Console.WriteLine("Esta cancion ya se encuentra en tu Playlist");
                    cancionEnPlaylist = true;
                    Thread.Sleep(1500);
                    break;
                }
            }
            if (!cancionEnPlaylist)
            {
                this.playlist.Add(cancion);
                Console.WriteLine("Se ha agregado a tu Playlist la cancion: " + cancion.nombre);
                Thread.Sleep(1500);
            }
        }

        public void BorrarCancion(Cancion cancion) // Borra una cancion de la playlist
        {
            if (playlist.Count == 0)
            {
                Console.WriteLine("No tienes canciones en esta Playlist");
                Thread.Sleep(1500);
            }
            else
            {
                foreach (Cancion cancion2 in playlist)
                {
                    if (cancion2.nombre == cancion.nombre)
                    {
                        playlist.Remove(cancion);
                        Console.WriteLine("Se ha eliminado la cancion de tu Playlist");
                        Thread.Sleep(1500);
                        return;
                    }
                }

                Console.WriteLine("Esta cancion no esta en tu playlist");
                Thread.Sleep(1500);
            }

        }

        public void NuevoSeguidor(Usuario usuario) { seguidores.Add(usuario); }

        public void EliminarSeguidor(Usuario usuario) { seguidores.Remove(usuario); }

        public void InformacionSeguidores()
        {
            Console.WriteLine("\nSus seguidores son:");

            foreach (var i in seguidores)
            {
                Console.WriteLine(i.nombreDeUsuario);
            }

            if (numeroSeguidores == 0) { Console.WriteLine("No tiene ningun seguidor"); }
        }
    }
}
