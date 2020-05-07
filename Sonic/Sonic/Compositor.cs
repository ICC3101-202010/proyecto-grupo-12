using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
    public class Compositor : Persona
    {
        List<Cancion> canciones = new List<Cancion>();

        public Compositor(string nombre)
        {
            this.nombre = nombre;
        }

        public void AgregarCancion(Cancion cancion) { this.canciones.Add(cancion); }

    }
}
