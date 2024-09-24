using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
        INICIO:
            Console.Write("Digite seu salário:");
            double sal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("╔═════════════════════╗");
            Console.WriteLine("║      Seu cargo      ║");
            Console.WriteLine("║ 1 -Gerente          ║");
            Console.WriteLine("║ 2 -Analista         ║");
            Console.WriteLine("║ 3 -Técnico          ║");
            Console.WriteLine("║ Digite a opção:     ║");
            Console.SetCursorPosition(17, 6);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    double aumento = sal * 0.1;
                    double salfinal = sal + aumento;
                    Console.WriteLine("Seu novo salário:"+salfinal);
                    Console.WriteLine("Seu antigo salário:"+sal);
                    double diferenca = salfinal - sal;
                    Console.WriteLine("Diferença:"+diferenca);
                    break;
                case 2:
                    double aumento2 = sal * 0.2;
                    double salfinal2 = sal + aumento2;
                    Console.WriteLine("Seu novo salário:" + salfinal2);
                    Console.WriteLine("Seu antigo salário:" + sal);
                    double diferenca2 = salfinal2 - sal;
                    Console.WriteLine("Diferença:" + diferenca2);
                    break;
                case 3:
                    double aumento3 = sal * 0.3;
                    double salfinal3 = sal + aumento3;
                    Console.WriteLine("Seu novo salário:" + salfinal3);
                    Console.WriteLine("Seu antigo salário:" + sal);
                    double diferenca3 = salfinal3 - sal;
                    Console.WriteLine("Diferença:" + diferenca3);
                    break;
                default:
                    Console.Clear();
                    goto INICIO;
            }
            Console.ReadKey();
        
       }
    }
}
