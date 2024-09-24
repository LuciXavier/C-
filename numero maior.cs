using System;

class Program {
  public static void Main (string[] args) {
    double num1,num2,r;
    Console.WriteLine ("Digite um número:");
    num1= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite um número:");
    num2= Convert.ToDouble(Console.ReadLine());
    
   
    if (num1>num2)
    {
      r = num1;
       Console.WriteLine ("Esse é o numero maior:"+r );  
    }
      
    else 
   {
       r = num2;
       Console.WriteLine ("Esse é o numero maior:" +r);  
   }
       
    Console.ReadKey();
  }
}