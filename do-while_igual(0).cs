using System;


class Program {
  public static void Main (string[] args) {

    double soma=0,num;
    int c = 0;
    do
    {
      Console.Write("Digite um valor:");
      num = Convert.ToDouble(Console.ReadLine());
        soma = soma + num;
        c++;
    } while (num!= 0);
    Console.WriteLine(soma);
    Console.ReadKey();
      
    }
  }