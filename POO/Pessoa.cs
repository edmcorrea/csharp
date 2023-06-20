namespace ClassesObjetos
{
  class Pessoa
{
  public string name = "Fred";
  public string lastname = "Cachumba";
  public int year;

  public void Apresentar(string nome, int idade) {
    Console.WriteLine("Olá " + nome + ". Você tem " + idade + " anos de idade, certo?");

  }
}
}