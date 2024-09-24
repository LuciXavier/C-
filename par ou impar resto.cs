using System;

class Program {
  public static void Main (string[] args) {
    double num,r;
    Console.Write("Digite um numero:");
    num = Convert.ToDouble(Console.ReadLine());
    r = num % 2;
    if (r == 0)
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("par");
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.WriteLine("impar");
    }
    Console.ReadKey();
    
  }
}