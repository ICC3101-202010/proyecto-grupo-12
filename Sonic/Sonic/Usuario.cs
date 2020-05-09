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

        // List<Object> seguir; Primera forma //BORRAR POST EXPLICACION

        List<Usuario> seguirUsuario;
        // List<Playlist> seguirPlaylist; Aun no esta creada
        // List<Disco> seguirDisco; Aparece en el enunciado
        List<Cantante> seguirCantante;
        List<Actor> seguirActor;
        List<Director> seguirDirector;
        List<Compositor> seguirCompositor;
        // List<Album> seguirAlbum; Nose si va esto
        int numeroSeguidores;
        List<Usuario> seguidores;

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


        // public void Seguimiento(Object objeto) {seguir.Add(objeto);} Primera forma ==> REVISAR para no repetir tanto codigo //BORRAR POST EXPLICACION

        public void SeguimientoUsuario(Usuario usuario) { seguirUsuario.Add(usuario); } //LISTO

        // public void SeguimientoPlaylist(Playlist playlist) { seguirPlaylist.Add(playlist); } //FALTA

        // public void SeguimientoDisco(Disco disco) { seguirDisco.Add(disco); } //FALTA

        public void SeguimientoCantante(Cantante cantante) { seguirCantante.Add(cantante); } //LISTO

        public void SeguimientoActor(Actor actor) { seguirActor.Add(actor); } //LISTO

        public void SeguimientoDirector(Director director) { seguirDirector.Add(director); } //LISTO

        public void SeguimientoCompositor(Compositor compositor) { seguirCompositor.Add(compositor); } //LISTO

        // public void SeguimientoAlbum(Album album) { seguirAlbum.Add(album); } //FALTA

        public void NuevoSeguidor(Usuario usuario) //Recomendado poner en una clase abstracta por multiples repeticiones
                                                   //Considere que solo pueden seguir los usuarios
                                                   //Decidi recibir el objeto usuario para  poder hacer futuras funciones con el, como revisar sus propios seguidores    
        {
            int contador = 0;
            foreach(var i in seguidores)
            {
                if(i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya sigues al Usuario");
                    contador++;
                    break;
                }
            }

            if(contador == 0) 
            {
                seguidores.Add(usuario);
                numeroSeguidores++;
                Console.WriteLine("Has comenzado a seguir al Usuario");
            }
        }

        public void DejarSeguir(Usuario usuario)
        {
            //No me acuerdo como eliminar un objeto de una lista
        }

        public void InformacionUsuarioSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Usuarios que sigues son:");

            foreach (var i in seguirUsuario)
            {
                Console.WriteLine(i.nombreDeUsuario);
                contador++;
            }

            if(contador == 0) {Console.WriteLine("No sigues a ningun usuario"); }
        }

        // public void InformacionPlaylistSeguidor() //FALTA

        // public void InformacionDiscoSeguidor() //FALTA

        public void InformacionCantanteSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Cantantes que sigues son:");

            foreach (var i in seguirCantante)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Cantante"); }
        }

        public void InformacionActorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Actores que sigues son:");

            foreach (var i in seguirActor)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Actor"); }
        }

        public void InformacionDirectorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Directores que sigues son:");

            foreach (var i in seguirDirector)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Director"); }
        }

        public void InformacionCompositorSeguidor() //LISTO
        {
            int contador = 0;

            Console.WriteLine("Los Compositor que sigues son:");

            foreach (var i in seguirCompositor)
            {
                Console.WriteLine(i.nombre);
                contador++;
            }

            if (contador == 0) { Console.WriteLine("No sigues a ningun Compositor"); }
        }

        // public void InformacionAlbumSeguidor() //FALTA

        public void InformacionSeguidores() //LISTO
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
