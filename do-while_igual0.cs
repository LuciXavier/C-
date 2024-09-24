using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double num;
            int c = 0;
            Console.Write("Digite um valor:");
            num = Convert.ToDouble(Console.ReadLine());
            do
            {
                Console.WriteLine(num + "-" + 1);
                num = num - 1;
                Thread.Sleep(200);
                c++;
            } while (num!= 0);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }// armazenar e quando digitar 0 mostrar a soma do guardado
}
