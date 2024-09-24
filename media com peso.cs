using System;

class Program {
  public static void Main (string[] args) {
    Console.Write("nota atd1:");
    double atd1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota Aatd2:");
    double atd2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota Aatd3:");
    double atd3 = Convert.ToDouble(Console.ReadLine());
    Console.Write("nota reg:");
    double reg = Convert.ToDouble(Console.ReadLine());
    double med = (atd1* 0.1 )+(atd2 * 0.3) +(atd3*0.3)+ (reg*0.3);
    Console.WriteLine("Média:"+med);

    if (med < 7){
      Console.Write("Digitar exame:");
      double exame = Convert.ToDouble(Console.ReadLine());
      med = (med + exame)/2;
      if (med >= 5){
        Console.WriteLine("Aprovado!");
      }
      else
      {
        Console.WriteLine("Reprovado!");
      }
    }
    else
    {
      Console.WriteLine("Aprovado!");
    }
    //
    if (med >=9){
      Console.WriteLine("Conceito A");
    }
    else if (med >=7.5 && med < 9)
    {
      Console.WriteLine("Conceito B");
    }
    else if (med >=6 && med < 7.5)
    {
      Console.WriteLine("Conceito C");
    }
    else
    {
      Console.WriteLine("Conceito D");
    }

    
  }
}