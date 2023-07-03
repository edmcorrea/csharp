namespace MediaAlunosPOO
{
  class Alunos {
    public string Nome { get; set; }
    private double[] _notas;

    public double Media {
      get {
        return CalcularMedia();
      }
    }

    public Alunos(string nome, int qttprovas) {
      Nome = nome;
      _notas = new double[qttprovas];
    }

    public void InsertNotas() {
      for (int i = 0; i < _notas.Length; i++)
      {
        Console.WriteLine("Insira a Nota #" + (i+1)+": ");
        _notas[i] = double.Parse(Console.ReadLine());
      }
    }

    private double CalcularMedia() {
      double total = 0;
      for (int i = 0; i < _notas.Length; i++)
      {
      Console.WriteLine("func calcularMedia: "+_notas[i]);
        total += _notas[i];
      }
      return total / (_notas.Length*10);
    }
  }
}