using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sonic
{
    public class Publicidad
    {
        string nombre; //Titulo
        string tipo; //Video o Imagen
        string descripcion; //Pequena descripcion que puede aparecer
        int cantidadApariciones; 
        string banco = null;
        string clave = null;
        List<Publicidad> videosPublicidad = new List<Publicidad>();
        List<Publicidad> imagenPublicidad = new List<Publicidad>();

        public Publicidad(string nombre, string tipo, string descripcion)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.descripcion = descripcion;
        }

        public void AgregarPublicidadVideo(Publicidad publicidad) { videosPublicidad.Add(publicidad); }

        public void QuitarPublicidadVideo(Publicidad publicidad) { videosPublicidad.Remove(publicidad); }

        public void AgregarPublicidadImagen(Publicidad publicidad) { imagenPublicidad.Add(publicidad); }

        public void QuitarPublicidadImagen(Publicidad publicidad) { imagenPublicidad.Remove(publicidad); }

        public void PublicidadDenunciada()
        {
            // Si la publicidad es denunciada por un usuario debe ser quitada por un Admin
        }

        public int CantidadMostrarPublicidad(Publicidad publicidad)
        {
            string eleccion;
            int cantidad;
            int precioPagar;
            Console.WriteLine("Precio cada aparicion de Video publicitario----------> $1.000");
            Console.WriteLine("Precio cada aparicion de Imagen publicitaria----------> $500");
            Console.WriteLine("\nQue desea agregar");
            Console.WriteLine("1. Video");
            Console.WriteLine("2. Imagen");
            eleccion = Console.ReadLine();
            Console.WriteLine("\nQue cantidad de repeticiones desea agregar");
            cantidad = int.Parse(Console.ReadLine());

            switch(eleccion)
            {
                case "1":
                    precioPagar = cantidad * 1000;
                    AgregarPublicidadVideo(publicidad);
                    this.cantidadApariciones = cantidad;
                    return precioPagar;
                    
                case "2":
                    precioPagar = cantidad * 500;
                    AgregarPublicidadImagen(publicidad);
                    this.cantidadApariciones = cantidad;
                    return precioPagar;

                default:
                    break;
            }
            return 0;
        }

        public void PrecioPublicidad(Publicidad publicidad)
        {
            if (CantidadMostrarPublicidad(publicidad) != 0) { Console.WriteLine($"Su precio a pagar es de ${CantidadMostrarPublicidad(publicidad)}"); }
        }

        public void PagarPublicidad(Publicidad publicidad)
        {
            string decision;
            Console.WriteLine("Desea efectuar el pago?");
            Console.WriteLine("1. SI");
            Console.WriteLine("2. NO");
            decision = Console.ReadLine();

            switch (decision)
            {
                case "1":
                    Pago(publicidad);
                    break;

                case "2":
                    Console.WriteLine("Operacion cancelada");
                    if (tipo == "Video") { QuitarPublicidadVideo(publicidad); }
                    else if (tipo == "Imagen") { QuitarPublicidadImagen(publicidad); }
                    break;
            }
        }

        public void Pago(Publicidad publicidad)
        {
            string decision;

            if (banco == null && clave == null)
            {
                Console.WriteLine("Ingrese su Banco afiliado: ");
                this.banco = Console.ReadLine();
                Console.WriteLine("Ingrese su clave bancaria: ");
                this.clave = Console.ReadLine();
                Console.WriteLine("Realizando pago...");
                EnvioReciboPublicidad();
            }

            else if (banco != null && clave != null)
            {
                Console.WriteLine("Ya tiene una cuenta afiliada");
                Console.WriteLine("Desea cambiarla?");
                Console.WriteLine("1. SI");
                Console.WriteLine("2. NO");
                decision = Console.ReadLine();

                switch(decision)
                {
                    case "1":
                        Console.WriteLine("Ingrese su nuevo Banco");
                        this.banco = Console.ReadLine();
                        Console.WriteLine("Ingrese su nueva clave");
                        this.clave = Console.ReadLine();
                        Console.WriteLine("Realizando pago...");
                        EnvioReciboPublicidad();
                        break;

                    case "2":
                        Console.WriteLine($"Su cuenta esta afiliada al Banco {banco}");
                        Console.WriteLine("Realizando pago...");
                        EnvioReciboPublicidad();
                        break;

                    default:
                        Console.WriteLine($"No se ha realizado el pago correctamente");
                        Console.WriteLine("Cancelando operacion...");
                        if (tipo == "Video") { QuitarPublicidadVideo(publicidad); }
                        else if (tipo == "Imagen") { QuitarPublicidadImagen(publicidad); }
                        break;
                }
            }
        }
        public void EnvioReciboPublicidad()
        {
            //Mandar recibo al mail
        }

        public void MostrarPublicidadRandom()
        {
            //Preguntar como agregar
        }

    }
}
