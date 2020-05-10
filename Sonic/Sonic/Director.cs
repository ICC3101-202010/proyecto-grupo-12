using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Director : Persona
    {
        List<Video> videos = new List<Video>();

        List<Usuario> seguidores;
        int numeroSeguidores;

        public Director(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarVideo(Video video) { videos.Add(video); }

        public void ObtenerInfo() //Obtener Info Director
        {
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.Write("Nombre:"); Console.BackgroundColor = ConsoleColor.Black; Console.Write(" " + this.nombre);
            Console.BackgroundColor = ConsoleColor.DarkGray; Console.WriteLine("\n Videos: "); Console.BackgroundColor = ConsoleColor.Black;
            foreach (Video video in videos) { Console.WriteLine(video.nombre); }

        }

        public void NuevoSeguidor(Usuario usuario, Director director)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al director");
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                seguidores.Add(usuario);
                numeroSeguidores++;
                usuario.SeguimientoDirector(director);
                Console.WriteLine("Has comenzado a seguir al director");
            }
        }

        public void DejarSeguir(Usuario usuario, Director director)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    seguidores.Remove(usuario);
                    numeroSeguidores--;
                    usuario.NoSeguimientoDirector(director);
                    Console.WriteLine("Has dejado de seguir al Director");
                    contador++;
                    break;
                }
            }

            if (contador == 0) { Console.WriteLine("No sigues al Director"); }
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
