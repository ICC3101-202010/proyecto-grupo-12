using System;
using System.Collections.Generic;

namespace SonicWFA
{
    [Serializable]
    public class Video : ArchivoMultimedia
    {

       
        public string categoria;
        public string genero;
        public string estudio;
        public Director director;
        public string descripcion;
        public List<Actor> actores;
        public string archivoMp3;
        public string rutaArchivoMp3;
        public int añoPublicacion;
        public int resolucion;
        public string imagen = null;



        public Video(string nombre, string categoria, string genero, string estudio, Director director, string descripcion, List<Actor> actores, int añoPublicacion, int duracion, int resolucion, string archivoMP3, string rutaArchivo)
        {
            this.nombre = nombre;
            this.categoria = categoria;
            this.genero = genero;
            this.estudio = estudio;
            this.director = director;
            this.descripcion = descripcion;
            this.actores = actores;
            this.añoPublicacion = añoPublicacion;
            this.duracion = duracion;
            this.resolucion = resolucion;
            this.archivoMp3 = archivoMP3;
            this.rutaArchivoMp3 = rutaArchivo;
        }

        public string ObtenerInfo() //Obtener Info del video
        {
            string devolver = "";
            devolver += "\nTitulo: " + this.nombre +
            "\nActores: ";
            foreach (Actor actor in actores) { devolver += "\n" + actor.nombre; }
            devolver += "\nCategoria: " + this.categoria +
            "\nGenero: " + this.genero +
            "\nEstudio: " + this.estudio +
            "\nDirector: " + this.director.nombre +
            "\nDescripción: " + this.descripcion +
            "\nAño de Publicación: " + this.añoPublicacion +
            "\nDuración: " + this.duracion +
            "\nResolución: " + this.resolucion +
            "\nImagen: " + this.imagen +
            "\nNumero de reproducciones: " + this.numeroReproducciones + "\n\n";

            return devolver;

        }

        public void ImagenVideo(string imagen)
        {
            this.imagen = imagen;
        }

    }
}



