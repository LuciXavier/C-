using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
        inicio:
            Console.WriteLine("         Menu       ");
            Console.WriteLine("║═════════════════════════════════╣");
            Console.WriteLine("1 - Bhaskara.");
            Console.WriteLine("2 - Força");
            Console.WriteLine("3 - Velocidade");
            Console.WriteLine("4 - sair");
            Console.WriteLine("Digite a opção:");
            Console.SetCursorPosition(15, 6);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("║═════════════════════════════════╣");
                    Console.WriteLine("(-b±√(b²-4ac))/(2a)");
                    double a, b, c;
                    Console.WriteLine("Digita o valor de a:");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor de b:");
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o valor de c:");
                    c = Convert.ToDouble(Console.ReadLine());
                    double d = Math.Pow(b, 2) - 4 * a * c;
                    Console.WriteLine("Valor de delta =" + d);
                    double x1 = ((-b - Math.Sqrt(d)) / 2 * a);
                    double x2 = ((-b + Math.Sqrt(d)) / 2 * a);
                    Console.WriteLine("Valor de x1 = " + x1);
                    Console.WriteLine("Valor de x2 = " + x2);
                    break;


                case 2:
                    Console.WriteLine("║═════════════════════════════════╣");
                    Console.WriteLine("(F = m * a)");
                    double m, ac, f;
                    Console.WriteLine("Digite a massa:");
                    m = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a aceleração:");
                    ac = Convert.ToDouble(Console.ReadLine());
                    f = m * ac;
                    Console.WriteLine("Força = " + f);
                    break;

                case 3:
                    Console.WriteLine("║═════════════════════════════════╣");
                    Console.WriteLine("(V = Vo + a*t)");
                    double v0, acl, t, v;
                    Console.WriteLine("Digite a velocidade inicial");
                    v0 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite a aceleração:");
                    acl = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite o tempo:");
                    t = Convert.ToDouble(Console.ReadLine());
                    v = v0 + (acl * t);
                    Console.WriteLine("Velocidade final:" + v);
                    break;
                case 4:
                    Console.WriteLine("Não cadastrado");
                    break;
                default:
                    Console.Clear();
                    goto inicio;

            }
            Console.ReadKey();
        }
    }
}
