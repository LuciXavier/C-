using System;

class Program {
  public static void Main (string[] args)
  {
    Console.Write("Digite o tamanho do vetor: ");
    int max = Convert.ToInt32(Console.ReadLine());
    int[] a = new int[max];
    int[] b = new int[max];
    int soma = 0;
    for(int i = 0; i < a.Length; i++)
    {
        Console.Write("Digite um valor no indice, "+i+":");
        a[i] = Convert.ToInt32(Console.ReadLine());
        b[i] = a[i]; 
        soma = soma + a[i];

    }
    Console.WriteLine("----Organizar vetor----");
    Array.Sort(a);
    for (int i = 0; i < a.Length; i++)
    {
        Console.WriteLine("O valor no indice, " + i + " é: "+a[i]);
    }
    Console.WriteLine("-----------");
    Console.WriteLine("Vetor original");
     foreach(int valor in b){
       Console.WriteLine("O valor é: "+valor);
    }
    Console.WriteLine("-----------");
    Console.WriteLine("Soma de todos os valores: " + soma);
    Console.ReadKey();
    
    
  }
}