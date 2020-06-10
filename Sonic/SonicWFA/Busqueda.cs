using System;
using System.Collections.Generic;

namespace SonicWFA
{
    [Serializable]
    public class Busqueda
    {
        public string nombre;
        public List<Action> busquedas = new List<Action>();

        public Busqueda(string nombre, List<Action> busquedas)
        {
            this.nombre = nombre;
            this.busquedas = busquedas;
        }
    }
}
