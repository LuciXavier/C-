using System;

class Program
{
  public static void Main (string[] args)
  {
     double num;
    Console.WriteLine ("Digite um número");
    num = Convert.ToDouble(Console.ReadLine());
   
    if (num < 0)
    {
      Console.WriteLine ("Esse numero é negativo");
    }
    
    else if (num>0)
    {
      Console.WriteLine ("Esse numero é positivo");
    }    
    else  
    {
      Console.WriteLine ("Esse é zero:" );
    }
     
    
    Console.ReadKey();
    
  }
      
}
      
