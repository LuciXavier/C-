using System;

class Program {
  public static void Main (string[] args)
  {
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write("Digite q qt do vetor:");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] a= new int[max];

      for(int i=0; i<a.Length;i++)
      {
        Console.Write("Digite um valor no indice," +i+ ":");
        a[i]=Convert.ToInt32(Console.ReadLine());
      }
      for(int i=0; i<a.Length;i++){
      Console.WriteLine("O valor no indice "+i+" é " +a[i] );
    }
    Console.ReadKey();

    
  }
}