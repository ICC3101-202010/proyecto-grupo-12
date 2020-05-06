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
        string privacidad;
        public string contraseña;
        List<string> gustos = new List<string>();
        List<Cancion> FavoritosCancion;
        List<Video> FavoritosVideo;

        public Usuario(string nombreDeUsuario, string nombre, string apellido, string contraseña, string privacidad, string tipoUsaurio)
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.tipoUsuario = tipoUsaurio;
        }

        public void CambiarNombre()
        {
            Console.WriteLine("Nombre nuevo: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Apellido nuevo: ");
            this.apellido = Console.ReadLine();
        }

        public void CambiarContraseña()
        {
            Console.WriteLine("Contraseña Nueva:");
            this.contraseña = Console.ReadLine();
        }

        public void CambiarPrivacidad()
        {
            Console.WriteLine("Seleccione Privacidad:");
            Console.WriteLine("1. Publico");
            Console.WriteLine("2. Privado");
            int opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    this.privacidad = "Publico";
                    break;
                case 2:
                    this.privacidad = "Privado";
                    break;
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }
        }
        public void AgregarGusto(string genero){this.gustos.Add(genero);}

        public void ObtenerInformacion()
        {
            Console.WriteLine("Nombre de Usuario: " + this.nombreDeUsuario);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Tipo de Usuario: " + this.tipoUsuario);
            Console.WriteLine("Privacidad: " + this.privacidad);
            Console.WriteLine("Gustos: ");
            foreach (string gusto in gustos) { Console.Write(gusto + ", "); }

        }
    }
}
