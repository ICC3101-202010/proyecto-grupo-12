using System;

namespace Sonic
{
    static class Barra
    {
        const char _block = '■';
        public static void WriteProgressBar(int percent, string tiempo, bool update = false)
        {
            if (update)
                Console.Clear();
            Console.BackgroundColor = ConsoleColor.White; Console.ForegroundColor = ConsoleColor.Black; Console.WriteLine("REPRODUCTOR"); Console.BackgroundColor = ConsoleColor.Black; Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(Environment.NewLine);
            Console.Write("[");
            var p = (int)((percent / 1f) + .5f);
            for (var i = 0; i < 100; ++i)
            {
                if (i >= p)
                    Console.Write(' ');
                else
                    Console.Write(_block);
            }
           
            
            Console.Write("] {0,3:##0}", tiempo);
        }
    }
}