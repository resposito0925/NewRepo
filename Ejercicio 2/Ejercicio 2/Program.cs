using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido, es un placer saludarle");

            Console.WriteLine("Ingrese un texto cualquiera y presione ENTER, por favor");
            string ingreso = Console.ReadLine();

            Console.WriteLine("Usted ha ingresado: " + ingreso);

            Console.ReadKey();
        }
    }
}
