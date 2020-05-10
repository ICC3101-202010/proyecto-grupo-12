using System;
using System.Collections.Generic;
using System.Threading;

namespace Sonic
{
    [Serializable]
    public abstract class ArchivoMultimedia
    {
        public string nombre;
        public int duracion;
        public int numeroReproducciones = 0;
        public double calificacion = 0;
        public int meGusta = 0;
        List<Usuario> meGustaUsuarios = new List<Usuario>();
        List<Usuario> calificacionUsuarios = new List<Usuario>();
        List<int> calificaciones = new List<int>();

        public void MeGusta(Usuario usuario)
        {
            Console.WriteLine("Le has dado me gusta a esta cancion");
            Thread.Sleep(1500);
            meGustaUsuarios.Add(usuario);
            meGusta++;
        }

        public void RevisionMeGusta(Usuario usuario)
        {
            int contador = 0;
            foreach (var i in meGustaUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya le has dado me gusta");
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                MeGusta(usuario);
            }
        }

        public void QuitarMeGusta(Usuario usuario)
        {
            Console.WriteLine("Le has quitado el me gusta a esta cancion");
            Thread.Sleep(1500);
            meGustaUsuarios.Remove(usuario);
            meGusta--;
        }

        public void RevisionQuitarMeGusta(Usuario usuario)
        {
            int contador = 0;
            foreach (var i in meGustaUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    QuitarMeGusta(usuario);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("No le has dado me gusta");
                Thread.Sleep(1500);
            }
        }

        public void Calificacion(Usuario usuario, int calificacion)
        {
            Console.WriteLine("Has calificado esta cancion");
            Thread.Sleep(1500);
            calificacionUsuarios.Add(usuario);
            calificaciones.Add(calificacion);
        }

        public void RevisionCalificacion(Usuario usuario, int calificacion)
        {
            int contador = 0;

            foreach (var i in calificacionUsuarios)
            {
                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    Console.WriteLine("Ya has calificado esta cancion");
                    Thread.Sleep(1500);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Calificacion(usuario, calificacion);
            }
        }

        public void QuitarCalificacion(Usuario usuario, int posicion)
        {
            Console.WriteLine("Has Quitado la calificacion de esta cancion");
            Thread.Sleep(1500);
            calificacionUsuarios.Remove(usuario);
            calificaciones.Remove(calificaciones[posicion]); //Preguntar
        }

        public void RevisionQuitarCalificacion(Usuario usuario)
        {
            int contador = 0;
            int posicion = -1;

            foreach (var i in calificacionUsuarios)
            {
                posicion++;

                if (i.nombreDeUsuario == usuario.nombreDeUsuario)
                {
                    QuitarCalificacion(usuario, posicion);
                    contador++;
                    break;
                }
            }
            if (contador == 0)
            {
                Console.WriteLine("Aun no calificas esta cancion");
                Thread.Sleep(1500);
            }
        }

        public void PromedioCalificion()
        {
            double sumaPromedio = 0;
            double promedio;

            foreach (var i in calificaciones)
            {
                sumaPromedio += i;
            }

            promedio = sumaPromedio / Convert.ToDouble(calificaciones.Count);

            this.calificacion = promedio;
        }

        public void MostrarPromedioCalificion()
        {
            Console.WriteLine($"El promedio de calificaciones de esta cancion es: {this.calificacion}");
            Thread.Sleep(1500);
        }

    }
}
