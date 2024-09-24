using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.WriteLine("         Menu       ");
            Console.WriteLine("║═════════════════════════════════╣");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("Digite a opção:");
            Console.SetCursorPosition(15, 6);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Soma");
                    double soma1, soma2, result;
                    Console.WriteLine("Digita o 1º valor:");
                    soma1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite 2º valor:");
                    soma2 = Convert.ToDouble(Console.ReadLine());
                    result = soma1 + soma2;
                    Console.WriteLine("Resultado:"+result);
                    break;


                case 2:

                    double sub1, sub2, r;
                    Console.WriteLine("Digite o 1º valor:");
                    sub1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor:");
                    sub2 = Convert.ToDouble(Console.ReadLine());
                    r = sub1 - sub2;
                    Console.WriteLine("Resultado:"+r);
                    break;

                case 3:

                    double mult1, mult2, multi;
                    Console.WriteLine("Digite o valor");
                    mult1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor");
                    mult2 = Convert.ToDouble(Console.ReadLine());
                    multi = mult1 * mult2; ;
                    Console.WriteLine("Resultado:"+multi);
                    break;
                case 4:

                    double valor1, valor2, resultado;
                    Console.WriteLine("Digite o 1º valor");
                    valor1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o 2º valor");
                    valor2 = Convert.ToDouble(Console.ReadLine());
                    resultado = valor1 / valor2; ;
                    Console.WriteLine("Resultado da multiplicação:" + resultado);
                    break;
                default:
                    Console.Clear();
                    goto inicio;

            }
            Console.ReadKey();
         }
    }
}
