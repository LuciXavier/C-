using System;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main()
        {
            double b, h, a;
            Console.WriteLine("Digite o valor:");
            b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor:");
            h= Convert.ToDouble(Console.ReadLine());
            a = b*h;
            Console.WriteLine("A área do retângulo é:" + a);
            Console.ReadKey(); 

          


        }
    }
}
