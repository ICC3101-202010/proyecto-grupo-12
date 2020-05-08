using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Compositor : Persona
    {
        List<Cancion> canciones = new List<Cancion>();

        public Compositor(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarCancion(Cancion cancion) { this.canciones.Add(cancion); }

        public void ObtenerInfo() // Obtener info del compositor
        {
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write("Nombre:"); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Canciones: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Cancion cancion in canciones) { Console.WriteLine(cancion.nombre); }
        }


    }
}
