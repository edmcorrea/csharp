
namespace POO {
  class Propriety {
    // EXISTE 2 JEITOS DE TRABALHAR COM PROPRIEDADES NO C#;
    
    // #1
    private string _nome = "";
    private int _idade;

    // #2
    public string Sobrenome {get; set;} = ""; // NESSE CASO, PODE-SE OMITIR O "SET" CASO NÃO PRECISE ATRIBUIR VALOR A ELE. FICARIA CONFORME ABAIXO: 
    // public string Sobrenome {get; }

    public string Nome {
      get {
        return _nome;
      }
      set {
        _nome = value;
      }
    }

    public int Idade {
      get {
        return _idade;
      }
      set {
        if (value < 18) Console.WriteLine("Idade deve ser superior a 18");
        else _idade = value;
      }
    }
  }
}
