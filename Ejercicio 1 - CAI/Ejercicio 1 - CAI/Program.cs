using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1___CAI
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();

            p1.Nombre = "Fabrizio";
            p1.Apellido = "Ghilardini";
            p1.Edad = 23;

            Console.WriteLine("Nombre Completo: " + p1.NombreCompleto);
            Console.WriteLine("Edad: " + p1.Edad.ToString());

            Console.ReadKey();
        }
    }
}
