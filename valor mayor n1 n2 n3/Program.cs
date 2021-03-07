using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace valor_mayor_n1_n2_n3
{
    class Program
    {
        static void Main(string[] args)
        {

            double n1;
            double n2;
            double n3;

            Console.WriteLine("Valor mayor.");
            Console.WriteLine(" ");

            Console.WriteLine("Escribe el valor del primer numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del segundo numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el valor del tercer numero: ");
            n3 = Convert.ToDouble(Console.ReadLine());


            if (n1 > n2 && n1 > n3)
            {
                Console.WriteLine("El numero " + n1 + " es mayor.");
            }
            else
            {
                if (n2 > n1 && n2 > n3)
                {
                    Console.WriteLine("El numero " + n2 + " es mayor.");
                }
                else
                {
                    Console.WriteLine("El numero " + n3 + " es mayor.");
                }
            }

            Console.ReadKey();
        }

    }
}
