using System;
using System.Collections.Generic;

namespace SonicWFA
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

        public string ObtenerInfo() //Obtener Info Cancion
        {
            return "\r\nTitulo: " + this.nombre +
            "\r\nCantante: " + this.cantante.nombre +
            "\r\nGenero: " + this.genero +
            "\r\nEstudio: " + this.estudio +
            "\r\nDiscografia: " + this.discografia +
            "\r\nAlbum: " + this.album.nombre +
            "\r\nCompositor: " + this.compositor.nombre +
            "\r\nAño de Publicación: " + this.añoPublicacion +
            "\r\nDuración: " + this.duracion +
            "\r\nImagen: " + this.imagen +
            "\r\nNumero de reproducciones: " + this.numeroReproducciones +
            "\r\nCalificación: " + this.calificacion +
            "\r\nMe Gusta: " + this.meGusta + "\r\n\r\n\r\n";
        }

        public void ImagenCancion(string imagen)
        {
            this.imagen = imagen;
        }

        

    }
}
