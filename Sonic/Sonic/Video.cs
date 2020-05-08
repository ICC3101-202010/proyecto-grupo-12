using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Video : ArchivoMultimedia
    {

        public string nombre;
        string categoria;
        string genero;
        string estudio;
        Director director;
        string descripcion;
        List<Actor> actores;
        int añoPublicacion;
        int duracion;
        int numeroReproducciones;
        int calificacion;
        int meGusta;
        public string imagen = null;
<<<<<<< Updated upstream
=======

>>>>>>> Stashed changes


        public Video(string nombre, string categoria, string genero, string estudio, Director director, string descripcion, List<Actor> actores, int añoPublicacion)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.genero = genero;
            this.estudio = estudio;
            this.director = director;
            this.descripcion = descripcion;
            this.actores = actores;
            this.añoPublicacion = añoPublicacion;
        }

        public void ObtenerInfo() //Obtener Info del video
        {
            Console.WriteLine("Titulo: " + this.nombre);
            Console.WriteLine("Actores: ");
            foreach (Actor actor in actores) { Console.WriteLine(actor.nombre); }
            Console.WriteLine("Categoria: " + this.categoria);
            Console.WriteLine("Genero: " + this.genero);
            Console.WriteLine("Estudio: " + this.estudio);
            Console.WriteLine("Director: " + this.director.nombre);
            Console.WriteLine("Descripción: " + this.descripcion);
            Console.WriteLine("Año de Publicación: " + this.añoPublicacion);

        }

        public void ImagenVideo(string imagen)
        {
            this.imagen = imagen;
        }
    }
}



