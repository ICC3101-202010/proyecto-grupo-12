using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Sonic sonic = new Sonic();

            sonic.CargarDatos();
          
            bool exit = true;
            while (exit)
            {
                string elejido = MostrarOpciones(new List<string>() {"Administrador", "Usuario", "Salir" });
                
                switch (elejido)
                {
                    case "Administrador":
                        Console.Clear();
                        bool controlador1 = true;

                        while (controlador1)
                        {
                            bool a = sonic.IniciarSesionAdmin();
                            if (!a && sonic.administradores.Count == 1) { break; }
                            if (a)
                            {
                                controlador1 = false;
                                Console.WriteLine("Iniciando Sesión...");
                                Thread.Sleep(2000);
                                Console.Clear();
                                bool sesion1 = true;
                                while (sesion1)
                                {
                                    string elejidoPrincial = MostrarOpciones(new List<string>() { "Funciones Canción", "Funciones Videos", "Funciones Administrador", "Cerrar Sesión"});

                                    switch (elejidoPrincial)
                                    {
                                        case "Funciones Canción":
                                            Console.Clear();
                                            bool sesion2 = true;
                                            while (sesion2)
                                            {
                                                string elejido6 = MostrarOpciones(new List<string>() { "Agregar Canción","Agregar Imagen", "Mostrar Canciones", "Mostrar Cantantes", "Mostrar Albums", "Salir" });

                                                switch (elejido6)
                                                {
                                                    case "Agregar Canción":
                                                        Console.Clear();
                                                        sonic.ImportarCanciones();
                                                        break;
                                                    case "Agregar Imagen":
                                                        sonic.AgregarImagenCancion();
                                                        break;
                                                    case "Mostrar Canciones":
                                                        Console.Clear();
                                                        sonic.MostarCanciones();
                                                        break;
                                                    case "Mostrar Cantantes":
                                                        Console.Clear();
                                                        sonic.MostarCantantes();
                                                        break;
                                                    case "Mostrar Albums":
                                                        Console.Clear();
                                                        sonic.MostarAlbums();
                                                        break;
                                                    case "Salir":
                                                        Console.Clear();
                                                        Console.WriteLine("Saliendo...");
                                                        Thread.Sleep(1000);
                                                        sesion2 = false;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Opción no valida");
                                                        Thread.Sleep(1000);
                                                        break;
                                                }
                                                Console.Clear();
                                                Thread.Sleep(1000);
                                            }
                                            break;
                                        case "Funciones Videos":
                                            Console.Clear();
                                            bool sesion3 = true;
                                            while (sesion3)
                                            {
                                                string elejido7 = MostrarOpciones(new List<string>() { "Agregar Video", "Agregar Imagen", "Mostrar Videos", "Mostrar Actores", "Mostrar Directores", "Salir" });

                                                switch (elejido7)
                                                {
                                                    case "Agregar Video":
                                                        Console.Clear();
                                                        sonic.ImportarVideos();
                                                        break;
                                                    case "Agregar Imagen":
                                                        sonic.AgregarImagenVideo();
                                                        break;
                                                    case "Mostrar Videos":
                                                        Console.Clear();
                                                        sonic.MostarVideos();
                                                        break;
                                                    case "Mostrar Actores":
                                                        Console.Clear();
                                                        sonic.MostarActores();
                                                        break;
                                                    case "Mostrar Directores":
                                                        Console.Clear();
                                                        sonic.MostarDirectores();
                                                        break;
                                                    case "Salir":
                                                        Console.Clear();
                                                        Console.WriteLine("Saliendo...");
                                                        Thread.Sleep(1000);
                                                        sesion3 = false;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Opción no valida");
                                                        Thread.Sleep(1000);
                                                        break;

                                                }
                                                Console.Clear();
                                                Thread.Sleep(1000);
                                            }
                                            break;
                                        case "Funciones Administrador":
                                            Console.Clear();
                                            bool sesion4 = true;
                                            while (sesion4)
                                            {
                                                string elejido8 = MostrarOpciones(new List<string>() { "Agregar Administrador", "Agregar Publicidad", "Mostrar Perfil", "Editar Perfil", "Salir" });

                                                switch (elejido8)
                                                {
                                                    case "Agregar Administrador":
                                                        Console.Clear();
                                                        sonic.AgregarAdministrador();
                                                        break;
                                                    case "Mostrar Perfil":
                                                        Console.Clear();
                                                        sonic.MostarInfoPerfilAdmin();
                                                        break;
                                                    case "Editar Perfil":
                                                        Console.Clear();
                                                        string elejido4 = MostrarOpciones(new List<string>() { "Cambiar Nombre", "Cambiar Contraseña" });
                                                        switch (elejido4)
                                                        {
                                                            case "Cambiar Nombre":
                                                                Console.Clear();
                                                                sonic.CambiarNombreAdmin();
                                                                break;
                                                            case "Cambiar Contraseña":
                                                                Console.Clear();
                                                                sonic.CambiarContraseñaAdmin();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Agregar Publicidad":
                                                        Console.Clear();
                                                        sonic.AgregarPublicidad();
                                                        break;
                                                    case "Salir":
                                                        Console.Clear();
                                                        Console.WriteLine("Saliendo...");
                                                        Thread.Sleep(1000);
                                                        sesion4 = false;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Opción no valida");
                                                        Thread.Sleep(1000);
                                                        break;
                                                }
                                                Console.Clear();
                                                Thread.Sleep(1000);
                                            }
                                            break;
                                        case "Cerrar Sesión":
                                            Console.Clear();
                                            Console.WriteLine("Cerrando Sesión...");
                                            Thread.Sleep(1000);
                                            controlador1 = false;
                                            sesion1 = false;
                                            break;

                                        default:
                                            Console.WriteLine("Opción no valida");
                                            Thread.Sleep(1000);
                                            break;
                                    }
                                  
                                    Console.Clear();
                                    Thread.Sleep(1000);
                                }
                            }
                        }
                        
                        break;
                    case "Usuario":
                        Console.Clear();
                        bool exit1 = true;
                        while (exit1)
                        {
                            string elejido1 = MostrarOpciones(new List<string>() { "Iniciar Sesión", "Registrarse", "Salir" });

                            switch (elejido1)
                            {
                                case "Iniciar Sesión":
                                    Console.Clear();
                                    bool controlador2 = true;
                                    while (controlador2)
                                    {
                                        bool u = sonic.IniciarSesion();
                                        if (u)
                                        {
                                            controlador2 = false;
                                            Console.WriteLine("Iniciando Sesión...");
                                            Thread.Sleep(2000);
                                            Console.Clear();
                                            bool sesion = true;
                                            while (sesion)
                                            {
                                                string elejido2 = MostrarOpciones(new List<string>() {"Perfil", "Buscar", "Reproducir", "Seguimiento", "Descargas", "Playlists","Favoritos", "Calificacíon","Me Gusta","Cerrar Sesión" });

                                                switch (elejido2)
                                                {
                                                    case "Perfil":
                                                        string elejido9 = MostrarOpciones(new List<string>() { "Mostrar Perfil", "Editar Perfil" });
                                                        switch (elejido9)
                                                        {
                                                            case "Mostrar Perfil":
                                                                Console.Clear();
                                                                sonic.MostarInfoPerfilUsuario();
                                                                break;
                                                            case "Editar Perfil":
                                                                Console.Clear();
                                                                string elejido3 = MostrarOpciones(new List<string>() { "Cambiar Nombre", "Cambiar Contraseña", "Elegir Gustos", "Cambiar Privacidad" });
                                                                switch (elejido3)
                                                                {
                                                                    case "Cambiar Nombre":
                                                                        Console.Clear();
                                                                        sonic.CambiarNombreUsuario();
                                                                        break;
                                                                    case "Cambiar Contraseña":
                                                                        Console.Clear();
                                                                        sonic.CambiarContraseñaUsuario();
                                                                        break;
                                                                    case "Elegir Gustos":
                                                                        Console.Clear();
                                                                        sonic.ElegirGustos();
                                                                        break;
                                                                    case "Cambiar Privacidad":
                                                                        Console.Clear();
                                                                        sonic.CambiarPrivacidad();
                                                                        break;
                                                                    default:
                                                                        Console.WriteLine("Opción no valida");
                                                                        Thread.Sleep(1000);
                                                                        break;
                                                                }
                                                                break;
                                                        }
                                                        break;
                                                    case "Buscar":
                                                        string elejido11 = MostrarOpciones(new List<string>() { "Buscar por filtros", "Buquedas Inteligentes" });
                                                        switch (elejido11)
                                                        {
                                                            case "Buscar por filtros":
                                                                Console.Clear();
                                                                sonic.Buscar();
                                                                break;
                                                            case "Buquedas Inteligentes":
                                                                Console.Clear();
                                                                sonic.RealizarBusqueda();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Reproducir":
                                                        Console.Clear();
                                                        sonic.ReproductorPoint();
                                                        break;
                                                    case "Seguimiento":
                                                        string elejido4 = MostrarOpciones(new List<string>() { "Seguir", "Dejar de Seguir" });
                                                        switch (elejido4)
                                                        {
                                                            case "Seguir":
                                                                Console.Clear();
                                                                sonic.Seguir();
                                                                break;
                                                            case "Dejar de Seguir":
                                                                Console.Clear();
                                                                sonic.DejarSeguir();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Descargas":
                                                        string elejido5 = MostrarOpciones(new List<string>() { "Descargar", "Mostar Descargas"});
                                                        switch (elejido5)
                                                        {
                                                            case "Descargar":
                                                                Console.Clear();
                                                                sonic.DescargarCancion();
                                                                break;
                                                            case "Mostar Descargas":
                                                                Console.Clear();
                                                                sonic.VerDescargas();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Playlists":
                                                        string elejido6 = MostrarOpciones(new List<string>() { "Crear Playlist", "Mostrar Playlists" });
                                                        switch (elejido6)
                                                        {
                                                            case "Crear Playlist":
                                                                Console.Clear();
                                                                sonic.CrearPlaylist();
                                                                break;
                                                            case "Mostrar Playlists":
                                                                Console.Clear();
                                                                sonic.VerPlaylists();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Favoritos":
                                                        string elejido12 = MostrarOpciones(new List<string>() { "Agregar cancion a Favoritos", "Agregar video a Favoritos" });
                                                        switch (elejido12)
                                                        {
                                                            case "Agregar cancion a Favoritos":
                                                                Console.Clear();
                                                                sonic.AgregarCancionAFavoritos();
                                                                break;
                                                            case "Agregar video a Favoritos":
                                                                Console.Clear();
                                                                sonic.AgregarVideoAFavoritos();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                     case "Calificacíon":
                                                        string elejido7 = MostrarOpciones(new List<string>() { "Calificar", "Quitar Calificación" });
                                                        switch (elejido7)
                                                        {
                                                            case "Calificar":
                                                                Console.Clear();
                                                                sonic.Calificar();
                                                                break;
                                                            case "Quitar Calificación":
                                                                Console.Clear();
                                                                sonic.SacarCalificacion();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Me Gusta":
                                                        string elejido8 = MostrarOpciones(new List<string>() { "Dar Me Gusta", "Quitar Me Gusta"});
                                                        switch (elejido8)
                                                        {
                                                            case "Dar Me Gusta":
                                                                Console.Clear();
                                                                sonic.PonerMeGusta();
                                                                break;
                                                            case "Quitar Me Gusta":
                                                                Console.Clear();
                                                                sonic.SacarMeGusta();
                                                                break;
                                                            default:
                                                                Console.WriteLine("Opción no valida");
                                                                Thread.Sleep(1000);
                                                                break;
                                                        }
                                                        break;
                                                    case "Cerrar Sesión":
                                                        Console.Clear();
                                                        Console.WriteLine("Cerrando Sesión...");
                                                        Thread.Sleep(2000);
                                                        sesion = false;
                                                        controlador2 = false;
                                                        break;
                                                    default:
                                                        Console.WriteLine("Opción no valida");
                                                        Thread.Sleep(1000);
                                                        break;
                                                }
                                                Console.Clear();
                                                Thread.Sleep(1000);
                                            }
                                        }
                                        else { break; }
                                    }
                                    break;
                                case "Registrarse":
                                    Console.Clear();
                                    sonic.Registrarse();
                                    break;
                                case "Salir":
                                    Console.Clear();
                                    Console.WriteLine("Saliendo...");
                                    Thread.Sleep(2000);
                                    exit1 = false;
                                    break;
                                default:
                                    Console.WriteLine("Opción no valida");
                                    Thread.Sleep(1000);
                                    break;
                            }
                            Console.Clear();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "Salir":
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        sonic.GuardarDatos();
                        Thread.Sleep(1000);
                        exit = false;
                        break;

                    default:
                        Console.WriteLine("Opción no valida");
                        Thread.Sleep(1000);
                        break;
                }
                Console.Clear();
                Thread.Sleep(1000);
            }

            string MostrarOpciones(List<string> opciones)
            {
                int i = 0;
                Console.WriteLine("\n\nSelecciona una opcion:");
                foreach (string opcion in opciones)
                {
                    Console.WriteLine(Convert.ToString(i) + ". " + opcion);
                    i += 1;
                }
                int opcion2 = 0;
                try
                {
                    opcion2 = Convert.ToInt16(Console.ReadLine());
                    return opciones[opcion2];
                }
                catch (Exception)
                {
                    return "Invalido";
                }
               
            }
       
        }
    }
}
