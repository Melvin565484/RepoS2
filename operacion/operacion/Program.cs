using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operacion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar a un usuario dos valores (a y b), y el programa mostrará el resultado de 
            //la operación(a+b)*(a - b) y el resultado de la operación a2 - b

            Int16 valora;  
            Int16 valorb;
            Int32 resultado;
            Int32 resultado1;

            Console.WriteLine("Escriba un valor para A ");
            valora = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Escriba un valor para b");
            valorb = Convert.ToInt16(Console.ReadLine());

            resultado = (valora + valorb) * (valora - valorb);

            resultado1 = (valora * 2) - valorb;

            Console.WriteLine("==========================================================");
            Console.WriteLine("Resultado de operacion 1: {0}", resultado);

            Console.WriteLine("==========================================================");
            Console.WriteLine("Resultado de operacion 2: {0}", resultado1);

            Console.ReadKey();
        }
    }
}
