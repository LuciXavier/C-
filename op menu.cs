using System;

class Program {
  public static void Main (string[] args) {
    int op;
    Console.WriteLine ("##########");
    Console.WriteLine ("#   MENU  #");
    Console.WriteLine ("# 1 REDES #");
    Console.WriteLine("# 2 ARQ.S #");
    Console.WriteLine ("# 3 B.D #");
    op = Convert.ToInt32(Console.ReadLine());
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.Clear();
    if (op == 1)
    {
      Console.Write("Prof.Gilmar");
    }
    else if (op == 2)
    {
      Console.WriteLine("Porf.Marcos");
    }
    else if (op == 3)
    {
      Console.WriteLine("Porf.Simone");
    }
    else
    {
      Console.WriteLine("disciplina não cadastrada");
    }
    Console.ReadKey();
    
  }
}