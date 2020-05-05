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

            bool exit = true;
            while (exit)
            {
                string elejido = MostrarOpciones(new List<string>() { "Administrador", "Usuario", "Salir" });
                
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
                                    string elejidoAdmin = MostrarOpciones(new List<string>() { "Agregar Canción", "Agregar Video", "Agregar Administrador", "Cerrar Sesión" });

                                    switch (elejidoAdmin)
                                    {
                                        case "Agregar Canción":

                                        case "Agregar Video":

                                        case "Agregar Administrador":
                                            Console.Clear();
                                            sonic.AgregarAdministrador();
                                            break;
                                        case "Cerrar Sesión":
                                            Console.Clear();
                                            Console.WriteLine("Cerrando Sesión...");
                                            Thread.Sleep(2000);
                                            controlador1 = false;
                                            sesion1 = false;
                                            break;
                                        default:
                                            break;
                                    }
                                    Console.Clear();
                                    Thread.Sleep(1000);
                                }
                                
                            }

                        }
                        break;
                    case "Usuario":
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
                                                string elejido2 = MostrarOpciones(new List<string>() { "Editar Perfil", "Buscar", "Cerrar Sesión" });

                                                switch (elejido2)
                                                {
                                                    case "Editar Perfil":
                                                        break;
                                                    case "Buscar":
                                                        break;
                                                    case "Cerrar Sesión":
                                                        Console.Clear();
                                                        Console.WriteLine("Cerrando Sesión...");
                                                        Thread.Sleep(2000);
                                                        sesion = false;
                                                        controlador2 = false;
                                                        break;
                                                    default:
                                                        break;
                                                }
                                                Console.Clear();
                                                Thread.Sleep(1000);
                                            }
                                        } 
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
                                    break;
                            }
                            Console.Clear();
                            Thread.Sleep(1000);
                        }
                        break;
                    case "Salir":
                        Console.Clear();
                        Console.WriteLine("Saliendo...");
                        Thread.Sleep(2000);
                        exit = false;
                        break;

                    default:
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
                return opciones[Convert.ToInt16(Console.ReadLine())];
            }
        }
    }
}
