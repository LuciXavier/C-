using System;
using System.Threading;

class Program {
  public static void Main (string[] args)
  {
    int[] a= new int[5]{10,12,3,-9,8};

      for(int i=0; i<5;i++)
      {
        Console.WriteLine
        (a [i]);
        Thread.Sleep(200);
      }
    Console.ReadKey();

    
  }
}