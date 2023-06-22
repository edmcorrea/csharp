namespace POO
{
  // O "partial" É UTILIZADO PARA REPARTIR UMA ÚNICA CLASSE EM VÁRIAS E, GRAÇAS A ISSO, TODAS AS PARTES DE CLASSES CONTINUAM CONECTADAS ENTRE SI
  partial class Pessoa
{

  public void Apresentar(string nome, int idade) {
    Console.WriteLine("Olá " + nome + ". Você tem " + idade + " anos de idade, certo?");

  }
}
}