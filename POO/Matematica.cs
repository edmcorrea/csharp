namespace POO
{
  class Matematica
{
  public void Soma(int valor1, int valor2) {
    Console.WriteLine("Soma: " + (valor1 + valor2));
  }

  public void Subtrair(int valor1, int valor2) {
    Console.WriteLine("Subtracao: " + (valor1 - valor2));

  }

  public void Multiplicar(int valor1, int valor2) {
    Console.WriteLine("Multi: " + (valor1 * valor2));

  }
  public void Dividir(int valor1, int valor2) {
    Console.WriteLine("Divisão: " + (valor1 / valor2));
  }

}
}