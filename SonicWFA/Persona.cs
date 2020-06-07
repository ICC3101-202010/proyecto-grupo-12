using System;
using System.Collections.Generic;

namespace SonicWFA
{
    [Serializable]
    public class Persona
    {
        public string nombre;
        public List<Usuario2> seguidores = new List<Usuario2>();
        public int numeroSeguidores;


        public Persona()
        {
        }

        public void NuevoSeguidor(Usuario2 usuario) { seguidores.Add(usuario); }

        public void EliminarSeguidor(Usuario2 usuario) { seguidores.Remove(usuario); }

        public void InformacionSeguidores()
        {
            Console.WriteLine("Sus seguidores son:");

            foreach (var i in seguidores)
            {
                Console.WriteLine(i.nombreDeUsuario);
            }

            if (numeroSeguidores == 0) { Console.WriteLine("No tiene ningun seguidor"); }
        }
    }
}
