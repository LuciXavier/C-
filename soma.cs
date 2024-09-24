using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    int soma=0, c=0;
    do
    {
      soma=soma + c;
      Console.WriteLine(soma);
      Thread.Sleep(200);
      c++;
    } while(c<=10);
    Console.WriteLine(soma);
    
    Console.ReadKey();
  }
}