using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Cantante : Persona
    {
        public List<Cancion> canciones = new List<Cancion>();
        public List<Album> albums = new List<Album>();



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
            this.InformacionSeguidores();
        }
    }
}
