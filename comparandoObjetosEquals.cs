
using System;

namespace MeuApp
{
    class MeuApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            var pessoaA = new Pessoa(1,"Daniel");
            var pessoaB = new Pessoa(1,"Daniel");
            Console.WriteLine(pessoaA.Equals( pessoaB));//[3] Comparando pessoaA com pessoaBAtravez do Equals
            
        }
    }
    public class Pessoa : IEquatable<Pessoa> // [1] Implementar interface herdando IEquatable
    {
        public Pessoa(int id, string nome)
        {
            Nome = nome;
            Id = id;
        }
        public int Id { get; set; }
        public string Nome { get; set; }

        public bool Equals(Pessoa other)//[2] interface gerada no parametro posso colocar other ou outro nome ex: pessoa
        {
            return Id == other.Id; // condisao alterada para comparar o Id com other.Id
        }
    }

}