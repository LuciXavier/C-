using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("nota atd1:");
    double atd1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota Aatd2:");
    double atd2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota Aatd3:");
    double atd3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota reg:");
    double reg = Convert.ToDouble(Console.ReadLine());
    double med = (atd1 + atd2 +atd3+ reg)/4;
    Console.WriteLine("Média:"+ Math.Round(med,2));

    if (med >= 7)
    {
      Console.ForegroundColor = ConsoleColor.DarkGreen;
      Console.WriteLine("Aprovado!");
    }
    
    else if (med>=4 && med < 7)
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Recuperação!");
    }

    else{
      Console.ForegroundColor = ConsoleColor.DarkRed;
      Console.WriteLine("Reprovado!");
    }




    
  }
}