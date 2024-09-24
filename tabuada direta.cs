using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    int c;
    double num, r ;
    for (c=1; c<=10; c++)
    {
      for(num = 0; num <=10; num ++){
        r = c * num;
      Console.ForegroundColor = ConsoleColor.DarkBlue;
      Console.WriteLine("Tabuada de " + c);
      Console.WriteLine("║"+ num + " x " +c+ " = " + r + "║");
      Thread.Sleep(500);
      }
      Console.WriteLine("---------");
    }
    
    Console.ReadKey();
  }
}