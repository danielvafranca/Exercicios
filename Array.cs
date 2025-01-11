using System.Data.Common;
using System.Linq.Expressions;

var meuArray  = new int[5]{1,2,3,4,5};
meuArray[0] = 12;

//meuArray.Clone();
//meuArray.CopyTo();
Console.WriteLine(meuArray.Length);
//-----------------------------------------------------------
Console.WriteLine("for");
for (var item = 0; item < meuArray.Length; item++)// utilizando o Length vai percorrer todo meu Array
{
    Console.WriteLine(meuArray[item]); // qual posicao quero exibir do meu array na trela ? item (meuArray[item]
}
//-------------------------------------------------------------------
Console.WriteLine("Foreach");
foreach (var item in meuArray)
{
    Console.WriteLine(item);
}

//-----------------------------------------------------------
Console.WriteLine("Foreach exemplooo");
var funcionarios = new Funcionario[5];
funcionarios[0] = new Funcionario(){Id=2545, Nome="Andre"};

foreach (var funcionario in funcionarios)
{
    Console.WriteLine(funcionario.Id);
    Console.WriteLine(funcionario.Nome);
}
public struct Funcionario
{
    public int Id {get; set; }
    public string Nome {get; set; }
}