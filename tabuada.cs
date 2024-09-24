using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    int c;
    double num, r;
    Console.WriteLine("Qual tabuada:");
    num = Convert.ToInt32(Console.ReadLine());
    for (c=0; c<=10; c++)
    {
      r = num * c;
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.Write("Tabuada de " + num);
      Console.WriteLine("║" + r + "║");
      Thread.Sleep(100);
    }
    Console.ReadKey();
  }
}