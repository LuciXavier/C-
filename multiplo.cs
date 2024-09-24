using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite o número:");
        int num = Convert.ToInt32(Console.ReadLine());
        int multi3 = num%3;
        int multi7 = num%7;

        if (multi3 == 0 || multi7 == 0)
        {
            Console.WriteLine("Múltiplo de 3 e 7.");
        }

        else
        {
            Console.WriteLine("Não é múltiplo.");
        }
        Console.ReadKey();
    }
}