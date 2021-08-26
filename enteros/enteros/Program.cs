using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enteros
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa  que  pida  al  usuario  dos
            //números  enteros.  Si  el  segundo  no  es  cero, mostrará el resultado de dividir
            //entre el primero y el segundo. Por el contrario, si el segundo número es cero,
            //escribirá "Error: No se puede dividir entre cero".

            Int32 nentero;
            Int32 nentero1;
            int resultado;

            Console.WriteLine("Ingrese valor entero: ");
            nentero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese valor entero: ");
            nentero1 = Convert.ToInt32(Console.ReadLine());

         

            if(nentero1 > 0)
            {
                resultado = (nentero / nentero1);
                Console.WriteLine("Resultado de operacion: ", resultado);
            }
            else
            {
                Console.WriteLine("Error: No se puede dividir entre cero...");
            }
            Console.ReadKey();
        }
    }
}
