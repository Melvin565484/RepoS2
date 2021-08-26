using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        { // Crear un programa que calcule la nota de un estudiante en base a 3 notas 
          //ingresadas, cada nota equivale a 30 %, 35 %, y 25 %, deberá mostrar las notas
          //ingresadas, notas con el porcentaje aplicado y la nota final.


            double notafinal;
            double nota, nota1, nota2;
            double porcen, porcen1, porcen2;

            Console.WriteLine("Ingresar nota (30%): ");
            nota = int.Parse(Console.ReadLine());
            porcen = (nota * 0.30);
            Console.WriteLine("Nota equivalente: " + porcen);


            Console.WriteLine("==================================================================");
            Console.WriteLine("Ingresar nota (35%): ");
            nota1 = int.Parse(Console.ReadLine());
            porcen1 = (nota * 0.35);
            Console.WriteLine("Nota equivalente: " + porcen1);

            Console.WriteLine("==================================================================");
            Console.WriteLine("Ingresar nota (25%): ");
            nota2 = int.Parse(Console.ReadLine());
            porcen2 = (nota * 0.25);
            Console.WriteLine("Nota equivalente: " + porcen2);


            notafinal = porcen + porcen1 + porcen2;
            Console.WriteLine("Nota final: " + notafinal);

            Console.ReadKey();
        }
    }
}
