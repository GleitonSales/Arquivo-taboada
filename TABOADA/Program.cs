using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TABOADA
{
    class Program
    {
        static void Main(string[] args)
        {
           /*
            Console.WriteLine("Digite um número da taboada");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($" 1 X { numero } = { numero * 1}");
            Console.WriteLine($" 2 X { numero } = { numero * 2}");
            Console.WriteLine($" 3 X { numero } = { numero * 3}");
            Console.WriteLine($" 4 X { numero } = { numero * 4}");
            Console.WriteLine($" 5 X { numero } = { numero * 5}");
            Console.WriteLine($" 6 X { numero } = { numero * 6}");
            Console.WriteLine($" 7 X { numero } = { numero * 7}");
            Console.WriteLine($" 8 X { numero } = { numero * 8}");
            Console.WriteLine($" 9 X { numero } = { numero * 9}");
            Console.WriteLine($" 10 X { numero } = { numero * 10}");
            Console.ReadKey();
            return;
           */

            Console.WriteLine("Digite um número da taboada");
            int numero = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($" {i} X {numero} = {numero * i}");                              
            }

            Console.ReadKey();



        }
    }
}
