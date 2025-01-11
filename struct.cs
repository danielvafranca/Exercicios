using System.Data.Common;

Product mouse = new Product(1, "Mouse", 399);
Console.WriteLine(mouse.Name);
Console.WriteLine(mouse.Id);
Console.WriteLine(mouse.Price);
struct Product
{

  public int Id;
  public string Name; 
  public double Price;

  public double PriceInDolar(double dolar)
  {
    return Price * dolar;
  }

  public Product(int id, string name, double price)
  {
    Id = id;
    Name = name;
    Price = price;
  }

}

//-------------------------------------------------------------
using System.Data.Common;
using System.Diagnostics.Contracts;
using System.Globalization;
//Passo 2
Pessoa pessoainf = new Pessoa();

pessoainf.Nome = "Daniel";
pessoainf.Cor = "Amarelo";
pessoainf.Idade = 24 ;
pessoainf.Peso = 83.40;
Console.WriteLine(); 

struct Pessoa // Passo 1
    public string Nome;
    public string Cor;
    public int Idade;
    public double Peso;
}