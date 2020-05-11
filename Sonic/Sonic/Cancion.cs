using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Cancion : ArchivoMultimedia
    {

        public Cantante cantante;
        public string genero;
        public string estudio;
        public string discografia;
        public Album album;
        public Compositor compositor;
        public string letra;
        public int añoPublicacion;
        public string imagen = null;
        

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
            Console.WriteLine("Calificación: " + this.calificacion);
            Console.WriteLine("Me Gusta: " + this.meGusta);
        }

        public void ImagenCancion(string imagen)
        {
            this.imagen = imagen;
        }

        

    }
}
