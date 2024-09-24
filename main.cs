using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Digite um valor:");
        double num = Convert.ToDouble(Console.ReadLine());
        double raiz = Math.Sqrt(num);
        Console.WriteLine("raiz: " + Math.Round(raiz, 2));
        double quadrado = Math.Pow(num, 2);
        Console.WriteLine(" Quadrado =:" + quadrado);
        Console.ReadKey();
    }
}

Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();
        nome = nome.Trim();
        Console.WriteLine("Nome sem espaço:" + nome);
        string nome_ma = nome.ToUpper();
        Console.WriteLine("Nome maiúsculo:" + nome_ma);
        string nome_mi = nome.ToLower();
        Console.WriteLine("Nome minúsculo:" + nome_mi);
        Console.ReadKey();

public static void Main(string[] args)
    {
        Console.Write("Digite seu nome:");
        string nome = Console.ReadLine();
        nome = nome.Trim();
        Console.WriteLine("Nome sem espaço:" + nome);
        string nome_ma = nome.ToUpper();
        Console.WriteLine("Nome maiúsculo:" + nome_ma);
        string nome_mi = nome.ToLower();
        Console.WriteLine("Nome minúsculo:" + nome_mi);
        int pos =  nome.IndexOf("a");
       Console.WriteLine("posição:"+pos);
       string nome_tro = nome.Replace("a","v");
      Console.WriteLine("nome trocado:"+nome_tro);
        Console.ReadKey();