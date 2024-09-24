using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    int c, max , par = 0;
    double num=0, soma=0, med=0;
    Console.WriteLine("Digite qtd números:");
    max = Convert.ToInt32(Console.ReadLine());
    for (c=1; c<=max; c++)
    {
      Console.Write("Digite o " + c + " º núemro ");
      num = Convert.ToDouble(Console.ReadLine());
      soma = soma +num ;
      med = soma / max;
      if (num % 2 == 0){
        soma =soma + num;
        par++;
    
      }
    }
    Console.WriteLine("Total soma:" +soma);
    med =soma/max;
    Console.WriteLine("Total soma:" +med);
    Console.WriteLine("par:"+ par++);
    Console.ReadKey();
  }
}