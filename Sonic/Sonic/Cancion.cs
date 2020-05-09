using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Cancion : ArchivoMultimedia
    {

        public string nombre;
        Cantante cantante;
        string genero;
        string estudio;
        string discografia;
        Album album;
        Compositor compositor;
        string letra;
        int añoPublicacion;
        int numeroReproducciones;
        int calificacion;
        int meGusta;
        public string imagen = null;


        public Cancion(string nombre, Cantante cantante,Album album, string genero, string estudio, string discografia, Compositor compositor, int añoPublicacion)
        {
            this.nombre = nombre;
            this.cantante = cantante;
            this.album = album;
            this.genero = genero;
            this.estudio = estudio;
            this.discografia = discografia;
            this.compositor = compositor;
            this.añoPublicacion = añoPublicacion;
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
            Console.WriteLine("Imagen: " + this.imagen);
           
        }

        public void ImagenCancion(string imagen)
        {
            this.imagen = imagen;
        }

    }
}
