using System;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano, atual, idade, id;
            Console.WriteLine("Seu dia do nascimento:");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seu mês de nascimento:");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seu ano de nascimento:");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ano atual:");
            atual = Convert.ToInt32(Console.ReadLine());
            idade = atual - ano;
            id = idade * 365;
            Console.WriteLine("Sua idade em dias:" + id);
            Console.ReadKey();
        }
    }
}
