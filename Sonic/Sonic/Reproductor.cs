using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    static class Reproductor
    {
        public static Cancion CancionesReproductor(List<Cancion> canciones)
        {
            int i = 1;
            Console.WriteLine("Canciones: ");
            foreach (Cancion cancion in canciones)
            {
                Console.WriteLine(i + ". " + cancion.nombre);
                i++;
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Seleccion una canción por su número: ");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Cancion cancion in canciones)
            {
                if (i == seleccion) { return cancion; }
                i++;
            }
            return null;
        }

        public static Video VideosReproductor(List<Video> videos)
        {
            int i = 1;
            Console.WriteLine("Videos: ");
            foreach (Video video in videos)
            {
                Console.WriteLine(i + ". " + video.nombre);
                i++;
            }
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("Seleccion una canción por su número: ");
            int seleccion = Convert.ToInt32(Console.ReadLine());
            i = 1;
            foreach (Video video in videos)
            {
                if (i == seleccion) { return video; }
                i++;
            }
            return null;
        }

        public static void EmpezarReproductor(List<Cancion> canciones, List<Video> videos)
        {
            bool reproductorEnCurso = true;
            while (reproductorEnCurso)
            {
                Console.WriteLine("1. Canciones" +
                                    "\n2. Videos");
                int eleccion = Convert.ToInt32(Console.ReadLine());
                ArchivoMultimedia archivo = null;
                switch (eleccion)
                {
                    case 1:
                        Cancion cancion = CancionesReproductor(canciones);
                        archivo = cancion;
                        break;
                    case 2:
                        Video video = VideosReproductor(videos);
                        archivo = video;
                        break;
                    default:
                        break;
                }
                
                Console.Clear();
                if (archivo != null)
                {
                    Barra.WriteProgressBar(0, "00:00");
                    int minutos = -1; int segundos = 0;
                    for (var i = 0; i <= archivo.duracion; ++i)
                    {
                        if (i % 60 == 0) { minutos++; segundos = 0; } else { segundos++; }
                        string tiempo;
                        if(segundos < 10) { tiempo = String.Format("{0}:0{1}", minutos, segundos); } else { tiempo = String.Format("{0}:{1}", minutos, segundos); }
                        if (!Console.KeyAvailable) { 
                            int progreso = ((i * 100) / archivo.duracion);
                            Barra.WriteProgressBar(progreso, tiempo, true);
                            Console.WriteLine("\n\n Canción: " + archivo.nombre);
                            Console.WriteLine("\n Presione: \n P: Pausar   R: Reproducir   S: Salir ");
                            Thread.Sleep(1000);
                        }
                        else if (Console.ReadKey(true).Key == ConsoleKey.S) { return; }
                        else if (Console.ReadKey(true).Key == ConsoleKey.P)
                        {
                            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.R))
                            {
                            }
                        } 
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red;  Console.WriteLine("SELECCION NO VALIDA"); Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(2000);
                    break;
                }
            }
        }

    }
}
