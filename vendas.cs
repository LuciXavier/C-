using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite nome de usuario:");
    string nome = Console.ReadLine();
    Console.Write("Digite sua senha:");
    string senha = Console.ReadLine();
    Console.WriteLine("Seja bem vindo!"+nome);
    Console.WriteLine("Quantidade de vendas no mês (R$):");
    int vendas = Convert.ToInt32(Console.ReadLine());

    if (vendas >= 3000)
    {
      Console.WriteLine("Seu sucesso cresce na mesma proporção que a sua mente cresce.");
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Parabéns!");
      Console.WriteLine("Seu prêmio é no valor de R$ 300,00");
    }
    else if (vendas >= 1000 && vendas < 3000)
    {
      Console.WriteLine("Toda conquista começa com a decisão de tentar.");
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine(" Seu prêmio é no valor de R$ 150,00");
    }
    else
    {
      Console.WriteLine("Sua limitação é apenas sua imaginação.");
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Sem prêmios no momento, mas não desista!");  
    }
  }
}