using System;
using System.Text;
using System.Threading.Tasks;

namespace Saludador
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el valor de la propiedad Nombre:");
            string Nombre = Console.ReadLine();
            Saludador miSaludador = new Saludador(Nombre);
            Console.WriteLine(miSaludador.Saluda());
            /*
            * 4.- Crear una clase "Saludador", que tiene:
            * 	- Una propiedad privada, Nombre
            * 	- Un método público, Saluda(), que devuelve una string que dice: "Hola, " y añade el valor de la propiedad Nombre
            * 	- Un constructor que toma un parámetro nombre y se lo asigna a la propiedad privada Nombre
            */
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
         }
    }
}
