using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;

            do
            {
                Console.WriteLine("\nPresione cualquier tecla para que se vea en la pantalla, o presione la tecla X para salir.");

                // Your code could perform some useful task in the following loop. However,
                // for the sake of this example we'll merely pause for a quarter second.

                while (Console.KeyAvailable == false)
                    Thread.Sleep(250); // Loop until input is entered.

                cki = Console.ReadKey(true);
                Console.WriteLine("Usted presiono '{0}'.", cki.Key);
            } while (cki.Key != ConsoleKey.X);
        }
    }
}
