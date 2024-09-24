using System;

class Program {
  public static void Main (string[] args)
  {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Digite q qt do vetor:");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] a= new int[max];
    int soma=0;

      for(int i=0; i<a.Length;i++)
      {
        Console.Write("Digite um valor no indice," +i+ ":");
        a[i]=Convert.ToInt32(Console.ReadLine());
        soma = soma + a[i];
      }
      for(int i=0; i<a.Length;i++){} 
    Console.WriteLine("soma dos valores: " + soma);
    Console.ReadKey();

    
  }
}