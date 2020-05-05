using System;
using System.Collections.Generic;

namespace Sonic
{
    public class Usuario
    {
        public string nombreDeUsuario;
        string nombre;
        string apellido;
        string tipoUsuario;
        public string contraseña;
        List<Cancion> FavoritosCancion;
        List<Video> FavoritosVideo;

        public Usuario(string nombreDeUsuario, string nombre, string apellido, string contraseña, string tipoUsaurio)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.tipoUsuario = tipoUsaurio;
        }


    }
}
