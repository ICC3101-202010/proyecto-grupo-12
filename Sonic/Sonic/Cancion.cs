using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Cancion : ArchivoMultimedia
    {

        Cantante cantante;
        string genero;
        string estudio;
        string discografia;
        Album album;
        Compositor compositor;
        string letra;
        int añoPublicacion;
        int calificacion;
        int meGusta = 0;
        public string imagen = null;
        List<Usuario> meGustaUsuarios = new List<Usuario>();
        List<Usuario> calificacionUsuarios = new List<Usuario>();
        List<int> calificaciones = new List<int>();


        public Cancion(string nombre, Cantante cantante,Album album, string genero, string estudio, string discografia, Compositor compositor, int añoPublicacion, int duracion)
        {
            this.nombre = nombre;
            this.cantante = cantante;
            this.album = album;
            this.genero = genero;
            this.estudio = estudio;
            this.discografia = discografia;
            this.compositor = compositor;
            this.añoPublicacion = añoPublicacion;
            this.duracion = duracion;
        }

        public void ObtenerInfo() //Obtener Info Cancion
        {
            Console.WriteLine("Titulo: "+ this.nombre);
            Console.WriteLine("Cantante: " + this.cantante.nombre);
            Console.WriteLine("Genero: " + this.genero);
            Console.WriteLine("Estudio: " + this.estudio);
            Console.WriteLine("Discografia: " + this.discografia);
            Console.WriteLine("Album: " + this.album.nombre);
            Console.WriteLine("Compositor: " + this.compositor.nombre);
            Console.WriteLine("Año de Publicación: " + this.añoPublicacion);
            Console.WriteLine("Duración: " + this.duracion);
            Console.WriteLine("Imagen: " + this.imagen);
            Console.WriteLine("Numero de reproducciones: " + this.numeroReproducciones);
           
        }

        public void ImagenCancion(string imagen)
        {
            this.imagen = imagen;
        }

        public void MeGusta(Usuario usuario)
        {
            Console.WriteLine("Le has dado me gusta a esta cancion");
            meGustaUsuarios.Add(usuario);
            meGusta++;
        }

        public void RevisionMeGusta(Usuario usuario)
        {
            int contador = 0;
            foreach (var i in meGustaUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya le has dado me gusta");
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                MeGusta(usuario);
            }
        }

        public void QuitarMeGusta(Usuario usuario)
        {
            Console.WriteLine("Le has quitado el me gusta a esta cancion");
            meGustaUsuarios.Remove(usuario);
            meGusta--;
        }

        public void RevisionQuitarMeGusta(Usuario usuario)
        {
            int contador = 0;
            foreach (var i in meGustaUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("No le has dado me gusta");
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                QuitarMeGusta(usuario);
            }
        }

        public void Calificacion(Usuario usuario, int calificacion)
        {
            Console.WriteLine("Has calificado esta cancion");
            calificacionUsuarios.Add(usuario);
            calificaciones.Add(calificacion);
        }

        public void RevisionCalificacion(Usuario usuario, int calificacion)
        {
            int contador = 0;

            foreach (var i in calificacionUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya has calificado esta cancion");
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Calificacion(usuario, calificacion);
            }
        }

        public void QuitarCalificacion(Usuario usuario, int calificacion, int posicion)
        {
            Console.WriteLine("Has Quitado la calificacion de esta cancion");
            calificacionUsuarios.Remove(usuario);
            calificaciones.Remove(calificaciones[posicion]); //Preguntar
        }

        public void RevisionQuitarCalificacion(Usuario usuario, int calificacion)
        {
            int contador = 0;
            int posicion = -1;

            foreach (var i in calificacionUsuarios)
            {
                posicion++;

                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    QuitarCalificacion(usuario, calificacion, posicion);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("Aun no calificas esta cancion");
            }
        }

        public int PromedioCalificion()
        {
            int sumaPromedio = 0;
            int promedio;

            foreach (var i in calificaciones)
            {
                sumaPromedio = sumaPromedio + i;
            }

            promedio = sumaPromedio / calificaciones.Count;

            return promedio;
        }

        public void MostrarPromedioCalificion()
        {
            Console.WriteLine($"El promedio de calificaciones de esta cancion es: {PromedioCalificion()}");
        }


    }
}
