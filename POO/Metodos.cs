namespace POO
{
  class Metodos
{
  public string name = "Fred";
  public string lastname = "Cachumba";
  public int year = 2020;

  public void SomarValor(int valor) {
    valor += 100;
    Console.WriteLine("Valor (Não Ref)" + valor);
  }

  public void SomarRef(ref int valor) {
    valor += 100;
    Console.WriteLine("Valor (Ref)" + valor);
  }

  public string MontarNome(string nome, string sobrenome) {
    return nome + sobrenome;
  }

  public void SomarValor(int valor1, int valor2) {
    int resultado = valor1 + valor2;
    valor1 += valor2;
    Console.WriteLine(resultado);
  }

}
}