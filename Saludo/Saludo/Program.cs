using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    class Program
    {
        //Crear un programa en C# que escriba un saludo y
        //muestre su nombre (ej. "Hola, Alberto")

        static void Main(string[] args)
        {
            String nombre;

             Console.WriteLine("Ingrese su nombre");

              nombre = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Saludos {0}",nombre);
            Console.ReadKey();

        }
    }
}
