using System;

class Program {
  public static void Main (string[] args) {
    int contador=0;
    Console.BackgroundColor = ConsoleColor.Cyan;
    Console.Clear();
    aqui:
    Console.Write("Dígite um valor:");
    double num = Convert.ToDouble(Console.ReadLine());
    
    if (num >= 10 && num <= 100)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Valor correto!");
      
    }
    else if (contador == 5) {
      Console.WriteLine("Tentativas esgotadas");
    }
    
    else {
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("ocorreu um erro");
      contador = contador +1;
      Console.WriteLine("Número de tentativas:"+contador);
      goto aqui;
        }
    
    Console.ReadKey();
  }
}