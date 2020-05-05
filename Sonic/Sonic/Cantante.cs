using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Cantante : Persona
    {
        List<Cancion> canciones;
        List<Album> albumes;


        public Cantante(string nombre, List<Cancion> canciones, List<Album> albumes)
        {
            this.nombre = nombre;
            this.canciones = canciones;
            this.albumes = albumes;
        }
    }
}
