using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Video : ArchivoMultimedia
    {

        string nombre;
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
        


        public Video(string nombre, string categoria, string genero, string estudio, Director director, string descripcion, List<Actor> actores, int añoPublicacion, int duracion)
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
        }

    }
}



