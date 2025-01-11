
/*  Modificadores: 
    private - so da para enchergar nas classes( se nao colocar nada na frente de classe ela por padrao é privado)
    piblic - já posso ver fora da classe
    protected
    internal
   

*/
using System;

namespace MeuApp
{
    class MeuApp
    {
        static void Main(string[] args)
        {
            var pagamento = new Pagamento();
            Console.WriteLine("hello world");
            
        }
    }
    public class Pagamento
    {
       
        void Pagar(){}
    }
    public class PagamentoBoleto : Pagamento
    {
        public DateMyProperty { get; set; }
    }
}
    
