namespace MediaAlunosPOO
{
  class Program {
    static void Main() {
      Console.WriteLine("## MÉDIA ALUNOS CALCULATOR   ###");
      Console.WriteLine("Insira a quantidade de alunos:");
      int qtddAlunos = int.Parse(Console.ReadLine());

      Console.WriteLine();

      Alunos[] arrAlunos = new Alunos[qtddAlunos];

      for (int i = 0; i < qtddAlunos; i++) {
        Console.Write("Nome do Aluno #" + (i+1)+ ": ");
        string nome = Console.ReadLine();

        Console.Write("Quantidade de Provas do Aluno #" + (i+1)+ ": ");
        int qtddProvas = int.Parse(Console.ReadLine());

        arrAlunos[i] = new Alunos(nome, qtddAlunos);

        Console.WriteLine("Insira as notas do aluno " + nome);
        arrAlunos[i].InsertNotas();
      }

      Console.Clear();

      double sumMedias = 0;

      foreach (Alunos aluno in arrAlunos)
      {
        Console.WriteLine("Aluno: " + aluno.Nome + " com Média " + aluno.Media + " foi adicionado");
        sumMedias += aluno.Media;
      }

      Console.WriteLine("Média geral dos alunos: " + sumMedias / arrAlunos.Length);
  }
  }
}