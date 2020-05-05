using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Album
    {
        string nombre;
        int año;
        List<Cantante> cantantes;


        public Album(string nombre, int año, List<Cantante> cantantes)
        {
            this.nombre = nombre;
            this.año = año;
            this.cantantes = cantantes;
        }
    }
}
