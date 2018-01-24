using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorBreakdown
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int Entero, Divisor;
            Console.WriteLine("Introduce el número que deseas descomponer:");
            Entero = int.Parse(Console.ReadLine());
            if (Entero < 0)
            {
                Console.WriteLine("Por ser un numero negativo no tiene factorial, pulse una tecla para salir");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nEl Factorial de " + Entero + " es: ");
                for (Divisor = 2; 1 < Entero; Divisor++)
                {
                        while (Entero % Divisor == 0)
                        {
                            Entero /= Divisor;
                            Console.Write(Divisor + " * ");
                        }
                }
            }
            /*
             * 1.- Hacer una aplicación de consola en donde se introduce un número entero
             * y se devuelven todos sus factores. 
             * Por ejemplo, si el usuario introduce el 102,el sistema dirá: 102 = 2 * 3 * 17. 
             * Si el usuario mete el 48, el sistema dirá: 48 = 2 * 2 * 2 * 2 * 3
             */
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
