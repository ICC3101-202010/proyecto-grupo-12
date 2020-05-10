using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Compositor : Persona
    {
        List<Cancion> canciones = new List<Cancion>();

        List<Usuario> seguidores = new List<Usuario>();
        int numeroSeguidores;

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

        public void NuevoSeguidor(Usuario usuario, Compositor compositor)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al compositor");
                    contador++;
                    break;
                }
            }

            if (contador == 0)
            {
                seguidores.Add(usuario);
                numeroSeguidores++;
                usuario.SeguimientoCompositor(compositor);
                Console.WriteLine("Has comenzado a seguir al compositor");
            }
        }

        public void DejarSeguir(Usuario usuario, Compositor compositor)
        {
            int contador = 0;
            foreach (var i in seguidores)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    seguidores.Remove(usuario);
                    numeroSeguidores--;
                    usuario.NoSeguimientoCompositor(compositor);
                    Console.WriteLine("Has dejado de seguir al Compositor");
                    contador++;
                    break;
                }
            }

            if (contador == 0) { Console.WriteLine("No sigues al Compositor"); }
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
