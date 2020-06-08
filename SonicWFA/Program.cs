using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SonicWFA
{

    public delegate void EntrarSesion();
    static class Program
    {
        public static bool abierto = true;

        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        /// 

        [STAThread]

        static void Main()
        {
           
            Sonic sonic = new Sonic();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new UsuarioForm());
        }
    }
}
