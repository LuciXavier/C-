using System;


class Program {
  public static void Main (string[] args) {
    int c = 0;
    Double num;
    do
    {
        Console.Write("Digite um número:");
        num = Convert.ToDouble(Console.ReadLine());
        c++;
    }
    while (num!=1 || num>1);
    }
  }