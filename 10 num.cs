using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    int c ;
    double num=0, soma=0, med=0;
    Console.WriteLine("Digite 10 números:");
    for (c=1; c<=10; c++)
    {
      Console.Write("Digite o " + c + " º núemro ");
      num = Convert.ToDouble(Console.ReadLine());
      soma = soma +num ;
      med = soma / 10;
    }
    Console.WriteLine("Total soma:" +soma);
    med =soma/10;
    Console.WriteLine("Total soma:" +med);
    Console.ReadKey();
  }
}