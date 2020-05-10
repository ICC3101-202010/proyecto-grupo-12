using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Cantante : Persona
    {
        public List<Cancion> canciones = new List<Cancion>();
        public List<Album> albums = new List<Album>();

        List<Usuario> seguidores = new List<Usuario>();
        int numeroSeguidores;


        public Cantante(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarCancion(Cancion cancion) { this.canciones.Add(cancion); }

        public void AgregarAlbum(Album album) { this.albums.Add(album);  }

        public void ObtenerInfo() // Obtener info del cantante
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;  Console.Write("Nombre:"); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Canciones: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Cancion cancion in canciones) { Console.WriteLine(cancion.nombre); }
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Albums: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Album album in albums) { Console.WriteLine(album.nombre); }
        }

        public void NuevoSeguidor(Usuario usuario, Cantante cantante) 
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al Cantante");
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                seguidores.Add(usuario);
                numeroSeguidores++;
                usuario.SeguimientoCantante(cantante);
                Console.WriteLine("Has comenzado a seguir al Cantante");
            }
        }

        public void DejarSeguir(Usuario usuario, Cantante cantante)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    seguidores.Remove(usuario);
                    numeroSeguidores--;
                    usuario.NoSeguimientoCantante(cantante);
                    Console.WriteLine("Has dejado de seguir al Cantante");
                    contador++;
                    break;
                }
            }

            if (contador == 0) { Console.WriteLine("No sigues al Cantante"); }
        }

        public void InformacionSeguidores()
        {
            Console.WriteLine("Sus seguidores son:");

            foreach (var i in seguidores)
            {
                Console.WriteLine(i.nombreDeUsuario);
            }

            if (numeroSeguidores == 0) { Console.WriteLine("No tiene ningun seguidor"); }
        }
    }
}
