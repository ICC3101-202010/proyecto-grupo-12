using System;
namespace Sonic
{
    [Serializable]
    public class Persona
    {
        public string nombre;
      
        public Persona()
        {
            //
<<<<<<< Updated upstream
=======
        }

        public void NuevoSeguidor(Usuario usuario) { seguidores.Add(usuario); }

        public void EliminarSeguidor(Usuario usuario) { seguidores.Remove(usuario); }

        public void InformacionSeguidores()
        {
            Console.WriteLine("Sus seguidores son:");

            foreach (var i in seguidores)
            {
                Console.WriteLine(i.nombreDeUsuario);
            }

            if (numeroSeguidores == 0) { Console.WriteLine("No tiene ningun seguidor"); }
>>>>>>> Stashed changes
        }
    }
}
