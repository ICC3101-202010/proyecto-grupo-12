using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Compositor : Persona
    {
        List<Cancion> canciones;

        public Compositor(string nombre, List<Cancion> canciones)
        {
            this.nombre = nombre;
            this.canciones = canciones;
        }
    }
}
