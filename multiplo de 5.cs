using System;

class Program {
  public static void Main (string[] args) {
    int num,r;
    Console.WriteLine ("Digite um número");
    num= Convert.ToInt32(Console.ReadLine());
    r = num%5;
    if (r ==0)  {
      
      Console.WriteLine("Esse numero é multiplo de 5!" );
    }
  
    else {
       Console.WriteLine("Esse numero não é multiplo de 5!" );
    }
    Console.ReadKey();
  }
}