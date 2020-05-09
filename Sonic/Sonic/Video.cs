﻿using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Video : ArchivoMultimedia
    {

       
        string categoria;
        string genero;
        string estudio;
        Director director;
        string descripcion;
        List<Actor> actores;
        int añoPublicacion;
        int calificacion;
        int meGusta;
        public string imagen = null;



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
            Console.WriteLine("Duración: " + this.duracion);
            Console.WriteLine("Imagen: " + this.imagen);
            Console.WriteLine("Numero de reproducciones: " + this.numeroReproducciones);



        }

        public void ImagenVideo(string imagen)
        {
            this.imagen = imagen;
        }
    }
}



