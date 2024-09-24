using System;

class Program {
  public static void Main (string[] args) {
    double s,p;
    Console.WriteLine ("Digite seu salario");
    s= Convert.ToDouble(Console.ReadLine());
    Console.WriteLine ("Digite o valor da sua prestação");
    p= Convert.ToDouble(Console.ReadLine());
     double limitePrestacao = s * 0.3;
     if (p <= limitePrestacao)
    {
    Console.WriteLine("A prestação do empréstimo está dentro do padrão.");
   }
    else
    {
       Console.WriteLine("A prestação do empréstimo não está dentro do padrão."); 
     }
    Console.ReadKey();
  }
}