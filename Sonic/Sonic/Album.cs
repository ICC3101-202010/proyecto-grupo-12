using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Album
    {
        public string nombre;
        Cantante cantante;
        List<Cancion> canciones = new List<Cancion>();


        public Album(string nombre, Cantante cantante)
        {
            this.nombre = nombre;
            this.cantante = cantante;
        }

        public void AgregarCancion(Cancion cancion) { this.canciones.Add(cancion); }

        public void ObtenerInfo()
        {
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write("Nombre: "); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write("\n Cantante: "); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.cantante.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Canciones: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Cancion cancion in canciones) { Console.WriteLine(cancion.nombre); }
        }
    }
}
