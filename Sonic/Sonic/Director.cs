using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Director : Persona
    {
        List<Video> videos;

        public Director(string nombre, List<Video> videos)
        {
            this.nombre = nombre;
            this.videos = videos;
        }
    }
}
