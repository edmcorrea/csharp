
namespace POO
{
   class Program
 {
  delegate void Operations(int num1, int num2);
  static void Main(string[] args)
  {
    #region Classes e Obj (Usando Pessoa)
      // Pessoa p1 = new Pessoa();
      // p1.name = "Edmilson";
      // p1.lastname = "Pinto";
      // p1.year = 25;

      // Console.WriteLine("Pessoa 1: " + p1.name + " " + p1.lastname);

      // p1.Apresentar("Jennifer", 4);
    #endregion

    #region Metodos Com Parametro
      // int valor1 = 100;
      // int valor2 = 100;
      // Metodos m = new Metodos();
      // m.SomarValor(valor1);
      // m.SomarRef(ref valor2);

      // ####O valor passado com "ref" altera o valor original da Aplicação

      // Console.WriteLine(valor1 + " " + valor2);
    #endregion

    #region Metodos Com Return de Valores
      // Metodos m = new Metodos();
      // Console.WriteLine(m.MontarNome("eD", "CORREA"));
    #endregion

    #region Metodos Com SobreCarga (Overloading)
      // Metodos m = new Metodos();
      // ####FUNÇÃO COM NOME DIFERENTE
      // m.SomarValor(5, 6);
      // Console.WriteLine(m.MontarNome("eD", "CORREA"));
    #endregion

    #region Delegate
      // #### FOI DECLARADO O "delegate" FORA DO "main"
      // Matematica m = new Matematica();
      // Operations conta = null;
      // conta += m.Soma;
      // conta += m.Subtrair;
      // conta += m.Multiplicar;
      // conta += m.Dividir;

      // conta(10, 5);
    #endregion

    #region Propriedades
      // Propriety propp = new Propriety();
      // propp.Nome = "Afonso";
      // propp.Sobrenome = "Padilha";
      // propp.Idade = 15;

      // Console.WriteLine(propp.Nome + " " + propp.Sobrenome);
      // Console.WriteLine(propp.Idade);

    #endregion

    #region Herança, Abstract, Override
      Caminhao cn = new Caminhao();
      cn.Acelerar();
    #endregion
  }


 }
} 