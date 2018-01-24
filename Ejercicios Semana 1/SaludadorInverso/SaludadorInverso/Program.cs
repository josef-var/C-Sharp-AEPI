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
            Console.WriteLine("Introduce el saludo a invertir:");
            string saludo = Console.ReadLine();
            Console.WriteLine(saludo.Reverse().ToArray());
            /*
                * 2.- Hacer una aplicación de consola en donde el usuario pone una palabra,
                * frase o número, y el sistema la escribe al revés. 
                * Por ejemplo, si el usuario teclease "Hola, mundo!", el sistema le devolverá: "!odnum ,aloH"
             */
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
