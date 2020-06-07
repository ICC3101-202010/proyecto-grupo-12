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
            return "\nTitulo: " + this.nombre +
            "\nCantante: " + this.cantante.nombre +
            "\nGenero: " + this.genero +
            "\nEstudio: " + this.estudio +
            "\nDiscografia: " + this.discografia +
            "\nAlbum: " + this.album.nombre +
            "\nCompositor: " + this.compositor.nombre +
            "\nAño de Publicación: " + this.añoPublicacion +
            "\nDuración: " + this.duracion +
            "\nImagen: " + this.imagen +
            "\nNumero de reproducciones: " + this.numeroReproducciones +
            "\nCalificación: " + this.calificacion +
            "\nMe Gusta: " + this.meGusta;
        }

        public void ImagenCancion(string imagen)
        {
            this.imagen = imagen;
        }

        

    }
}
