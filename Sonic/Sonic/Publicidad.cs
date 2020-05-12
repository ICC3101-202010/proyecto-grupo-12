using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Sonic
{
    [Serializable]
    public class Publicidad
    {
        string nombre; //Titulo
        string tipo; //Video o Imagen
        string descripcion; //Pequena descripcion que puede aparecer
        public int cantidadApariciones;
        int precioPagar = 0;
        string banco = null;
        string clave = null;
        

        public Publicidad(string nombre, string tipo, string descripcion, int cantidadApariciones, int precioPagar)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.descripcion = descripcion;
            this.cantidadApariciones = cantidadApariciones;
            this.precioPagar = precioPagar;
        }

        public void PublicidadDenunciada()
        {
            // Si la publicidad es denunciada por un usuario debe ser quitada por un Admin
        }

        
        public void PrecioPublicidad()
        {
            if (precioPagar != 0) { Console.WriteLine($"Su precio a pagar es de ${precioPagar}"); Thread.Sleep(1500); }
        }

        public bool PagarPublicidad()
        {
            string decision;
            Console.WriteLine("Desea efectuar el pago?");
            Console.WriteLine("1. SI");
            Console.WriteLine("2. NO");
            decision = Console.ReadLine();

            switch (decision)
            {
                case "1":
                    Pago();
                    return true;
                case "2":
                    Console.WriteLine("Operacion cancelada");
                    Thread.Sleep(1500);
                    return false;
            }

            return false;
        }

        public void Pago()
        {
            string decision;

            if (banco == null && clave == null)
            {
                Console.WriteLine("Ingrese su Banco afiliado: ");
                this.banco = Console.ReadLine();
                Console.WriteLine("Ingrese su clave bancaria: ");
                this.clave = Console.ReadLine();
                Console.WriteLine("Realizando pago...");
                Thread.Sleep(1500);
                //EnvioReciboPublicidad();
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
                        Thread.Sleep(1500);
                        //EnvioReciboPublicidad();
                        break;

                    case "2":
                        Console.WriteLine($"Su cuenta esta afiliada al Banco {banco}");
                        Console.WriteLine("Realizando pago...");
                        Thread.Sleep(1500);
                        //EnvioReciboPublicidad();
                        break;

                    default:
                        Console.WriteLine($"No se ha realizado el pago correctamente");
                        Console.WriteLine("Cancelando operacion...");
                        Thread.Sleep(1500);
                        return;
                }
            }
            Console.WriteLine("Pago exitoso");
            Thread.Sleep(1500);
        }

        public void MostrarPublicidad()
        {
            Console.WriteLine(this.nombre);
            Console.WriteLine("\n\n" + this.descripcion);
        }

    }
}
