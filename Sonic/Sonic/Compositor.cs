using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Compositor : Persona
    {
        List<Cancion> canciones;

        public Compositor(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarCancion(Cancion cancion) { this.canciones.Add(cancion); }

    }
}
