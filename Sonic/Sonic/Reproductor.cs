using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    static class Reproductor
    {
        

        public static Cancion CancionesReproductor(List<Cancion> canciones) //Elegir Cancion
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
         
        public static Video VideosReproductor(List<Video> videos) //Elegir Video
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

<<<<<<< Updated upstream
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
=======
        public static void CargarArchivoCola(List<Cancion> canciones, List<Video> videos,Usuario usuario, ArchivoMultimedia archivoReproduciendo) //Agregar a cola
        {

            if (archivoReproduciendo.GetType().Name == "Cancion")
            {
                bool cancionCola = false;
                Cancion cancion = CancionesReproductor(canciones);
                foreach (var cancion1 in usuario.colaCanciones)
                {
                    if (cancion.nombre == cancion1.nombre) { Console.WriteLine("Canción ya se encuentra en la cola"); cancionCola = true; Thread.Sleep(1000); }
                }
                if (!cancionCola) { usuario.colaCanciones.Add(cancion); }
            }
            else if (archivoReproduciendo.GetType().Name == "Video")
            {
                bool videoCola = false;
                Video video = VideosReproductor(videos);
                foreach (var video1 in usuario.colaVideos)
                {
                    if (video.nombre == video1.nombre) { Console.WriteLine("Video ya se encuentra en la cola"); videoCola = true; Thread.Sleep(1000); }
                }
                if (!videoCola) { usuario.colaVideos.Add(video); }
            }
        }

        public static void MostarCola(Usuario usuario, ArchivoMultimedia archivoReproduciendo) //Mostar cola
        {
            int i = 1;
            if (archivoReproduciendo.GetType().Name == "Cancion")
            {
                Console.WriteLine("Cola canciones: ");
                foreach (Cancion cancion in usuario.colaCanciones)
                {
                    Console.WriteLine(Convert.ToString(i) + ". " + cancion.nombre);
                    i++;
                }
            }
            else if (archivoReproduciendo.GetType().Name == "Video")
            {
                Console.WriteLine("Cola videos: ");
                foreach (Video video in usuario.colaVideos)
                {
                    Console.WriteLine(Convert.ToString(i) + ". " + video.nombre);
                    i++;
                }
            }
            Console.WriteLine("Pulsa cualquier tecla para volver atras");
            Console.ReadKey();
        }

        public static void EmpezarReproductor(List<Cancion> canciones, List<Video> videos, Usuario usuario, ArchivoMultimedia ultimaReproduccion, int tiempoGuardado = 0) //Reproductor
        {
            ArchivoMultimedia archivo = null;
            while (true)
            {
                int inicio = 0;
                bool firstTime = true;
                while (true)
                {
                    if (ultimaReproduccion == null && archivo == null)
                    {
                        Console.Clear();
                        inicio = 0;
                        Console.WriteLine("1. Canciones" +
                                            "\n2. Videos");
                        int eleccion = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
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
                                Console.WriteLine("Opción no valida");
                                break;
                        }
                    }
                    else if (ultimaReproduccion != null && archivo == null)
                    {
                        Console.WriteLine("¿Desea reanudar desde ultima reproducción? (s/n)");
                        string eleccion2 = Console.ReadLine();
                        if (eleccion2 == "n") { ultimaReproduccion = null; usuario.colaVideos.Clear(); usuario.colaCanciones.Clear(); continue; }
                        archivo = ultimaReproduccion; inicio = tiempoGuardado;
                    }
                    break;
>>>>>>> Stashed changes
                }
                
                Console.Clear();
                if (archivo != null)
                {
                    Barra.WriteProgressBar(0, "00:00");
                    int minutos = -1; int segundos = 0;
                    for (var i = 0; i <= archivo.duracion; ++i)
                    {
                        if (i % 60 == 0) { minutos++; segundos = 0; } else { segundos++; }
<<<<<<< Updated upstream
=======
                        if (ultimaReproduccion != null && i % 60 != 0 && firstTime) { minutos++; firstTime = false; }
>>>>>>> Stashed changes
                        string tiempo;
                        if (segundos < 10) { tiempo = String.Format("{0}:0{1}", minutos, segundos); } else { tiempo = String.Format("{0}:{1}", minutos, segundos); }
                        if (!Console.KeyAvailable)
                        {
                            int progreso = ((i * 100) / archivo.duracion);
                            Barra.WriteProgressBar(progreso, tiempo, true);
<<<<<<< Updated upstream
                            Console.WriteLine("\n\n Canción: " + archivo.nombre);
                            Console.WriteLine("\n Presione: \n P: Pausar   R: Reproducir   S: Salir ");
                            Thread.Sleep(1000);
                        }
                        else if (Console.ReadKey(true).Key == ConsoleKey.S) { return; }
=======
                            if (archivo.GetType().Name == "Cancion") { Console.WriteLine("\n\n Canción: " + archivo.nombre); } else { Console.WriteLine("\n\n Video: " + archivo.nombre); }
                            Console.WriteLine("\n Presione: \n P: Pausar   C: Cola" +
                                "\n Presione 2 veces: \n R: Reproducir   S: Salir ");
                            Thread.Sleep(1000);
                        }
                        else if (Console.ReadKey(true).Key == ConsoleKey.C)
                        {
                            Console.WriteLine(String.Format("\n1. Mostar Cola" +
                                "\n2. Agregar {0} a cola", archivo.GetType().Name));
                            int eleccion = Convert.ToInt32(Console.ReadLine());
                            switch (eleccion)
                            {
                                case 1:
                                    MostarCola(usuario, archivo);
                                    break;
                                case 2:
                                    CargarArchivoCola(canciones, videos,usuario, archivo);
                                    break;
                                default:
                                    break;
                            }
                        }
                        else if (Console.ReadKey(true).Key == ConsoleKey.S) { GuardarArchivo(archivo, i, usuario); return; }
>>>>>>> Stashed changes
                        else if (Console.ReadKey(true).Key == ConsoleKey.P)
                        {
                            while (!(Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.R))
                            {
                            }
                        }
                    }
                    Console.WriteLine();
<<<<<<< Updated upstream
=======
                    usuario.archivoReproduccion = null;
                    usuario.tiempoReproduccion = 0;
                    if(archivo.GetType().Name == "Cancion" && usuario.colaCanciones.Count != 0)
                    {
                        Cancion siguienteCancion = usuario.colaCanciones[0];
                        archivo = siguienteCancion;
                        usuario.colaCanciones.Remove(siguienteCancion);

                    } else if(archivo.GetType().Name == "Video" && usuario.colaVideos.Count != 0)
                    {
                        Video siguienteVideo = usuario.colaVideos[0];
                        archivo = siguienteVideo;
                        usuario.colaVideos.Remove(siguienteVideo);
                    } else
                    {
                        Console.WriteLine("¿Desea reproducir otra archivo? (s/n)");
                        string eleccion2 = Console.ReadLine();
                        if (eleccion2 == "n") { break; }
                        archivo = null;
                    }
>>>>>>> Stashed changes
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Red; Console.WriteLine("SELECCION NO VALIDA"); Console.BackgroundColor = ConsoleColor.Black;
                    Thread.Sleep(2000);
                    break;
                }
            }
        }

<<<<<<< Updated upstream
=======
        public static void GuardarArchivo(ArchivoMultimedia archivo, int tiempo, Usuario usuario) //Guardar Archivo si se estaba reproduciendo
        {
            usuario.archivoReproduccion = archivo;
            usuario.tiempoReproduccion = tiempo;
        }
>>>>>>> Stashed changes
    }
}
