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
    }
}
