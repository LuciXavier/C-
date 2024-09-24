using System;


namespace desconto
{
    public class Program
    {
        static void Main(string[] args)
        {

            double desconto, quantidade, valor, total, pagar;
            Console.Write("Qual o produto?");
            string produto = Console.ReadLine();
            Console.Write("Quantidade?");
            quantidade = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Valor?");
            valor = Convert.ToDouble(Console.ReadLine());
            total = quantidade * valor;


            if (quantidade <= 5)
            {
                desconto = 2 / 100;
                pagar = total - desconto;
                Console.WriteLine("Produto:" + produto);
                Console.WriteLine("Quantidade:" + quantidade);
                Console.WriteLine("Total a pagar:" + pagar);
            }
            else if (quantidade > 5 && quantidade <= 10)
            {
                desconto = 3 / 100;
                pagar = total - desconto;
                Console.WriteLine("Produto:" + produto);
                Console.WriteLine("Quantidade:" + quantidade);
                Console.WriteLine("Total a pagar:" + pagar);
            }
            else if (quantidade > 10)
            {
                desconto = 5 / 100;
                pagar = total - desconto;
                Console.WriteLine("Produto:" + produto);
                Console.WriteLine("Quantidade:" + quantidade);
                Console.WriteLine("Total a pagar:" + pagar);
            }
            Console.ReadKey();
        }

    }
}
