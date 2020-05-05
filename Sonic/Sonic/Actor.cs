using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Actor : Persona
    {
        List<Video> videos;

        public Actor(string nombre, List<Video> videos)
        {
            this.nombre = nombre;
            this.videos = videos;
        }
    }
}
