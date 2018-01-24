using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Saludador
{
    class Saludador
    {
        // Una propiedad privada, Nombre
        private string Nombre { get; set; }

        //Un método público, Saluda()
        public string Saluda()
        {
            return ("Hola, " + Nombre);
        }
        
        //Un constructor que toma un parámetro nombre y se lo asigna a la propiedad privada Nombre
        public Saludador(string nombre)
        {
             Nombre = nombre;
        }
    }
}
