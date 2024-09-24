using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    double num;
    do
    {
      Console.WriteLine("Digite um valor de 0 a 10:");
      num = Convert.ToDouble(Console.ReadLine());
    } while(num<0 || num>10);
    Console.WriteLine("valor digitado:"+num);
    Console.ReadKey();
  }
}