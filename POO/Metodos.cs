namespace ClassesObjetos
{
  class Metodos
{
  public string name = "Fred";
  public string lastname = "Cachumba";
  public int year;

  public void SomarValor(int valor) {
    valor += 100;
    Console.WriteLine("Valor (Não Ref)" + valor);
  }

  public void SomarRef(ref int valor) {
    valor += 100;
    Console.WriteLine("Valor (Ref)" + valor);
  }
}
}