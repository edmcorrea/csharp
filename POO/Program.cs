
namespace ClassesObjetos
{
   class Program
 {
  static void Main(string[] args)
  {
    #region Classes e Obj (Usando Pessoa)
      Pessoa p1 = new Pessoa();
      p1.name = "Edmilson";
      p1.lastname = "Pinto";
      p1.year = 25;

      // Console.WriteLine("Pessoa 1: " + p1.name + " " + p1.lastname);

      // p1.Apresentar("Jennifer", 4);
    #endregion

    #region Metodos
      // int valor1 = 100;
      // int valor2 = 100;
      // Metodos m = new Metodos();
      // m.SomarValor(valor1);
      // m.SomarRef(ref valor2);

      // O valor passado com "ref" altera o valor original da Aplicação

      // Console.WriteLine(valor1 + " " + valor2);
    #endregion
  }


 }
} 