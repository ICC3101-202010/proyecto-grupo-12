using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Actor : Persona
    {
        List<Video> videos = new List<Video>();

        List<Usuario> seguidores;
        int numeroSeguidores;

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
            
        }

        public void NuevoSeguidor(Usuario usuario, Actor actor)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al Actor");
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                seguidores.Add(usuario);
                numeroSeguidores++;
                usuario.SeguimientoActor(actor);
                Console.WriteLine("Has comenzado a seguir al Actor");
            }
        }

        public void DejarSeguir(Usuario usuario, Actor actor)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    seguidores.Remove(usuario);
                    numeroSeguidores--;
                    usuario.NoSeguimientoActor(actor);
                    Console.WriteLine("Has dejado de seguir al Actor");
                    contador++;
                    break;
                }
            }

            if (contador == 0) { Console.WriteLine("No sigues al Actor"); }
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
