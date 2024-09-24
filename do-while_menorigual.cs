using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp24
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
                num = num - 1;
                Console.WriteLine(num);
                Thread.Sleep(200);
                c++;
            } while (num!=1 && num>1);
            Console.WriteLine(num);
            Console.ReadKey();
        }
    }
}// não armazenar e só aceitar quando digitar menor igual a 1
