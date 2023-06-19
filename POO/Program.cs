
namespace ClassesObjetos
{
   class Program
 {
  static void Main(string[] args)
  {
    Pessoa p1 = new Pessoa();
    p1.name = "Edmilson";
    p1.lastname = "Pinto";
    p1.year = 25;

    Console.WriteLine("Pessoa 1: " + p1.name + " " + p1.lastname);
  }
 }
}