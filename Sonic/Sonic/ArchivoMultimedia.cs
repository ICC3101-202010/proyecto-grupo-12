using System;
namespace Sonic
{
    [Serializable]
    public abstract class ArchivoMultimedia
    {
        public string nombre;
        public int duracion;
        public int numeroReproducciones = 0;


        public ArchivoMultimedia()
        {

        }
    }
}
