using System;

namespace atv_c_
{
    internal class Program
    {
        static void Main(string[] args)// atvidade 1 maior ou menor que vinte
        {
            Console.Write("Digite um número:");
            double num = Convert.ToDouble(Console.ReadLine());
            if (num > 20)
            {
                 double atv1 = num / 2;
                Console.WriteLine("A metade de seu número é:"+atv1);
            }
            
            else if (num < 20){
                 double atv1  = num * 2;
                Console.WriteLine("O dobro do numero digitado é: " + atv1);
            }

            //atividade 2 maior e menor
            Console.Write("Digite um número:");
            double atv4num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um número:");
            double atv4num2 = Convert.ToDouble(Console.ReadLine());

            if (atv4num > atv4num2)
            {
                double r = atv4num;
                Console.WriteLine("O número maior é:" + atv4num);
            }

            else
            {

                Console.WriteLine("O número maior é:" + atv4num2);
            }

            // atividade 3 múltiplo de cinco
            Console.WriteLine("Digite um número:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int atv2= num1 % 5;
            if (atv2 == 0)
            {
                Console.WriteLine("É multiplo de 5");
            }
            else
            {
                Console.WriteLine("Esse numero não é multiplo de 5!");
            }

            //atividade 4 prestação
            Console.WriteLine("Digite seu salário:");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o valor da sua prestação:");
            double prest = Convert.ToDouble(Console.ReadLine());
            double limitePrestacao = sal * 0.3;

            if (prest <= limitePrestacao)
            {
                Console.WriteLine("Empréstimo autorizado");
            }
            else
            {
                Console.WriteLine("Empréstimo não autorizado");
            }

            //atvidade 5 negativo,positivo,= a zero
            Console.Write("Digite um número");
            double atv3 = Convert.ToDouble(Console.ReadLine());
            if (atv3 < 0)
            {
                Console.WriteLine("Negativo");
            }

            else if (atv3 > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                Console.WriteLine("Zero:");
            }
  
            Console.ReadKey();
        
        }

    }
}
