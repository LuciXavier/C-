using System;
using System.Threading;

class Program {
  public static void Main (string[] args) 
  {
    int i;
    for (i = 0 ; i <= 4; i++){ 
      Console.WriteLine(i);
      Thread.Sleep(200);
    }
    Console.ReadKey();
  }
}