using System;

class Program {
  public static void Main (string[] args) {
    string nome;
    Console.Write("Digite nome de usuario:");
    nome = Console.ReadLine();
    if (nome == "luciana")
    {
      Console.ForegroundColor = ConsoleColor.Cyan;
      Console.WriteLine("Digite a senha:");
      string senha = Console.ReadLine();
      
      if (senha == "1234")
      {
        Console.WriteLine("ok");
      }
      else
      {
        Console.WriteLine("incorreta");
      }
   }
    else{
      Console.ForegroundColor = ConsoleColor.DarkGray;
      Console.WriteLine("Não cadastrado");
    }
    Console.ReadKey();
    
  }
}