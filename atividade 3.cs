using System;

class Program {
  public static void Main (string[] args) {
     Console.Write("Digite seu nome completo: ");
     string nomeCompleto = Console.ReadLine();
      nomeCompleto = nomeCompleto.Trim();
     int ultimoEspaco = nomeCompleto.LastIndexOf(' ');
     string primeiroNome = nomeCompleto.Substring(0, ultimoEspaco);
     string sobrenome = nomeCompleto.Substring(ultimoEspaco + 1);
    Console.WriteLine("Nome: " + primeiroNome + sobrenome);
  }
}