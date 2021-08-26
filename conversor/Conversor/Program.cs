using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer   un   programaque   transforme
            //de   grados   centígrados   a   grados Fahrenheit.

            Int32 gradosc;
            Int32 f;

            Console.WriteLine("Ingrese valor en grados centigrados: ");
            gradosc = Convert.ToInt32(Console.ReadLine());

            
                f = ((gradosc * 9 / 5) + 32);

                Console.WriteLine("Conversion realizada, resultado en f: {0} ",f);
            
                Console.ReadKey();
            
            
        }

    }

}
