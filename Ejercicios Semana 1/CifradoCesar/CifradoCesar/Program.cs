using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el texto a cifrar:");
            string mensaje = Console.ReadLine();
            if (mensaje.Length == 0)
            {
                Console.WriteLine("No hay nada que cifrar, pulse una tecla para salir");
                Console.ReadKey();
                Environment.Exit(0);
            }

            string cifrado = string.Empty;
            foreach (char c in mensaje)
            {
                cifrado += (char)(((c - 'a' + 1) % 26) +'a');
            }
            Console.WriteLine(cifrado);
            /*
			* 3.- El chungo.Cifrado y descifrado por el sistema CESAR.
            * Usaremos el CESAR + 1, que es cifrar una palabra poniendo el carácter
            * que está una posición más adelante. Si pusiésemos 'B', nos saldría 'C'.Si pusiésemos 'Y', nos saldría 'Z'
            * PASOS
            *	- Hacer solo el cifrado(Más adelante desciframos, que es lo mismo)
            *	- No atender en principio a los casos 'extremos'. (si pone 'Z', deberá salir 'A').Lo haremos después también
            *   - Solo con palabras mayúsculas del abecedario.No se contemplan ni frases enteras, ni números
            */
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
