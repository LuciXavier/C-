using System;
using System.Threading;

class Program {
  public static void Main (string[] args) {
    Console.Write("Digite a qt da turma:");
    int qt = Convert.ToInt32(Console.ReadLine());
    int c =1;
    double total=0,nota=0;
    while(c<=qt){

      do
      {
        Console.Write("Digite a nota do " +c+ " Aluno:");
        nota = Convert.ToDouble(Console.ReadLine());
      }while(nota<0||nota>10);
      total = nota + total;
      c++;
    }
    double media = total/qt;
    Console.Write("Média dos alunos:"+media);
    Console.ReadKey();
  }
}