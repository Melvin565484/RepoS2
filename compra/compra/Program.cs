using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compra
{
    class Program
    {
        public static bool Medicina { get; private set; }

        static void Main(string[] args)
        {
            //Hacer un programa que calcule el impuesto de un producto, pero coloque un 
            //impuesto del 0 % si el producto es medicina

            bool producto;
            Int32 precio, resultado;
            
           

            Console.WriteLine("Ingrese nombre del producto: ");
            producto = Convert.ToBoolean(Console.ReadLine());
          

            Console.WriteLine("Ingrese precio del producto: ");
            precio = Convert.ToInt32(Console.ReadLine());

            
            
                
            if( producto = Medicina)
            {
                Console.WriteLine(" {0} ", producto);
                Console.WriteLine("Su impuesto es del 0%: {0} ", precio);
            }
                   else
            {
              
                resultado = ((int)(precio * 0.06));
                Console.WriteLine(" {0} ", producto);
                Console.WriteLine("Su impuesto es del 6%: {0} ", resultado);
                Console.WriteLine(" {0} ", producto);
                Console.WriteLine("Su impuesto es del 0%: {0} ", precio);
            }
            Console.ReadKey();

        }

    }
}