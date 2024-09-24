using System;

class Program {
  public static void Main (string[] args) {
    double num,r;
    Console.WriteLine ("Digite um número");
    num = Convert.ToDouble(Console.ReadLine());
    if (num>20)
    {
      r = num / 2;
      Console.WriteLine("A metade do numero digitado é: " +r);
    
    }
  
      
   else if (num < 20)
    {
      r= num * 2;
     Console.WriteLine("O dobro do numero digitado é: "+r);
    }
   Console.ReadKey();
  }
}