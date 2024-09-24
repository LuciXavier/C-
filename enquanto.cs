using System;

class Program {
  public static void Main (string[] args) {
    int n,c,r;
    Console.WriteLine ("Digite um valor:");
    n= Convert.ToInt32(Console.ReadLine());
    c =0;
    while (c <= 10){
      r=n*c;
      Console.WriteLine(r);
      c++;
    }
    Console.ReadKey();
  }
}