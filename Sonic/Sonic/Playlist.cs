using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Playlist
    {
        public string nombre;
        public string privacidad;
        List<Cancion> playlist = new List<Cancion>();

        public Playlist(string nombre, string privacidad)
        {
            this.nombre = nombre;
            this.privacidad = privacidad;
        }

        public void Crear() // Crea la playlist
        {
            Console.WriteLine("Ingrese nombre de la Playlist: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Privacidad de la Playlist: ");
            Console.WriteLine("0.- Privada");
            Console.WriteLine("1.- Publica");
            int eleccion = Convert.ToInt32(Console.ReadLine());
            if (eleccion == 0 || eleccion == 1)
            {
                if (eleccion == 0)
                {
                    this.privacidad = "privada";
                }
                else
                {
                    this.privacidad = "publica";
                }
            }
            else
            {
                Console.WriteLine("Opcion invalida.");
            }
        }

        public void Info() // Entrega la info para imprimirla en Sonic
        {
            int contador = 1;
            Console.WriteLine("Nombre Playlist : " + nombre);
            Console.WriteLine("Privacidad: " + privacidad);
            Console.WriteLine(playlist.Count + "canciones: ");
            foreach (Cancion cancion in playlist)
            {
                Console.WriteLine(contador + cancion.nombre);
                contador++;
            }
        }

        public void AgregarCancion(Cancion cancion) //Aca agrega una cancion que no este ya en la Playlist
        {
            foreach (Cancion cancion2 in playlist)
            {
                if (cancion2 == cancion)
                {
                    Console.WriteLine("Esta cancion ya se encuentra en tu Playlist");
                }
                else
                {
                    this.playlist.Add(cancion);
                    Console.WriteLine("Se ha agregado a tu Playlist la cancion: " + cancion.nombre);

                }
            }
        }
        public void BorrarCancion(Cancion cancion) // Borra una cancion de la playlist
        {
            if (playlist.Count == 0)
            {
                Console.WriteLine("No tienes canciones en esta Playlist");
            }
            else
            {
                foreach (Cancion cancion2 in playlist)
                {
                    if (cancion2 == cancion)
                    {
                        playlist.Remove(cancion);
                        Console.WriteLine("Se ha eliminado la cancion de tu Playlist");
                    }
                }
            }

        }

    }
}
