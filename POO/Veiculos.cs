namespace POO
{
  abstract class Veiculo {
    public string Cor {get; set; } = "branco";
    public string Marca {get; set;} = "Volkswage";
    public abstract void Acelerar();
  }
}