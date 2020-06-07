using System;
using System.Collections.Generic;

namespace SonicWFA
{
    [Serializable]
    public class Admin
    {
        public string nombreDeUsuario;
        string nombre;
        string apellido;
        public string contraseña;
        List<Publicidad> publicidadAdmin = new List<Publicidad>();

        public Admin(string nombreDeUsuario, string nombre, string apellido, string contraseña) //Constructor Admin
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
        }

        public void CambiarNombre() // Cambia el nombre y apellido de este admin
        {
            Console.WriteLine("Nombre nuevo: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Apellido nuevo: ");
            this.apellido = Console.ReadLine();
        }

        public void CambiarContraseña() // Cambia la contraseña de este admin
        {
            Console.WriteLine("Contraseña Nueva:");
            this.contraseña = Console.ReadLine();
        }

        public void ObtenerInformacion() // Obtiene la info del perfil de este admin
        {
            Console.WriteLine("Nombre de Usuario: " + this.nombreDeUsuario);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
        }

        public void AgregarPublicidadAdmin(Publicidad publicidad) { publicidadAdmin.Add(publicidad); }

        public void QuitarPublicidadAdmin(Publicidad publicidad) { publicidadAdmin.Remove(publicidad); }
    }
}
