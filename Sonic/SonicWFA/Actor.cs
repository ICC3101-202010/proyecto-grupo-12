using System;
using System.Collections.Generic;

namespace SonicWFA
{
    [Serializable]
    public class Actor : Persona
    {
        List<Video> videos = new List<Video>();


        public Actor(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarVideo(Video video) { videos.Add(video); }

        public void ObtenerInfo() //Obtener Info Actor
        {
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write("Nombre:"); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Videos: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Video video in videos) { Console.WriteLine(video.nombre); }
            this.InformacionSeguidores();
            
        }
    }
}
