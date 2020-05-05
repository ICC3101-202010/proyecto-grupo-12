using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Cancion : ArchivoMultimedia
    {

        string nombre;
        List<Cantante> cantante;
        string genero;
        string estudio;
        string discografia;
        List<Compositor> compositor;
        string letra;
        int añoPublicacion;
        int numeroReproducciones;
        int calificacion;
        int meGusta;


        public Cancion(string nombre, List<Cantante> cantante, string genero, string estudio, string discografia, List<Compositor> compositor, string letra, int añoPublicacion)
        {
            this.nombre = nombre;
            this.cantante = cantante;
            this.genero = genero;
            this.estudio = estudio;
            this.discografia = discografia;
            this.compositor = compositor;
            this.letra = letra;
            this.añoPublicacion = añoPublicacion;
        }

    }
}
