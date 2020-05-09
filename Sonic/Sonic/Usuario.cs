using System;
using System.Collections.Generic;

namespace Sonic
{
    [Serializable]
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
        public List<Cancion> cancionesDescargadas = new List<Cancion>();

        public Usuario(string nombreDeUsuario, string nombre, string apellido, string contraseña, string privacidad, string tipoUsaurio) // Constructor Usuario
        {
            this.nombreDeUsuario = nombreDeUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.contraseña = contraseña;
            this.privacidad = privacidad;
            this.tipoUsuario = tipoUsaurio;
        }

        public void CambiarNombre() // Cambia el nombre y apellido de este usuario
        {
            Console.WriteLine("Nombre nuevo: ");
            this.nombre = Console.ReadLine();
            Console.WriteLine("Apellido nuevo: ");
            this.apellido = Console.ReadLine();
        }

        public void CambiarContraseña() // Cambia la contraseña de este usuario
        {
            Console.WriteLine("Contraseña Nueva:");
            this.contraseña = Console.ReadLine();
        }

        public void CambiarPrivacidad() // Cambia la privacidad de este usuario
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
        public void AgregarGusto(string genero){this.gustos.Add(genero);} // Agrega los gustos seleccionados a este usuario

        public void ObtenerInformacion() // Obtiene la info del perfil de este usuario
        {
            Console.WriteLine("Nombre de Usuario: " + this.nombreDeUsuario);
            Console.WriteLine("Nombre: " + this.nombre);
            Console.WriteLine("Apellido: " + this.apellido);
            Console.WriteLine("Tipo de Usuario: " + this.tipoUsuario);
            Console.WriteLine("Privacidad: " + this.privacidad);
            Console.WriteLine("Gustos: ");
            foreach (string gusto in gustos) { Console.Write(gusto + ", "); }

        }
        public void AgregarCancionDescargada(Cancion cancion)
        {
            cancionesDescargadas.Add(cancion);

        }
        public void VerCancionesDescargadas()
        {
            int contador = 1;
            if (cancionesDescargadas.Count == 0)
            {
                Console.WriteLine("No hay canciones descargadas.");
            }
            else
            {
                Console.WriteLine(cancionesDescargadas.Count + "canciones descargadas: ");
                foreach (Cancion cancion in cancionesDescargadas)
                {
                    Console.WriteLine(contador);
                    cancion.ObtenerInfo();
                    contador++;
                }
            }

        }
    }
}
