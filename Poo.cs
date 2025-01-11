using System;
using System.ComponentModel;

namespace Program  
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            //(Herança 2)  instanciar é o ato de transformar a classe no objeto
            var pagamentoBoleto = new PagamentoBoleto();
            pagamentoBoleto.Vencimento = DateTime.Now;
            pagamentoBoleto.Pagar();
            pagamentoBoleto.NumeroBoleto="123344";
        }
    }
    class Pagamento// pegar informaçoes de pagamento,, açoens que o pagamenrto pode realizar e eventos que podem ter  e trazer para classe se chama encapsulamento
    {   //Propriedade
        public DateTime Vencimento;//propriedade
        //Métodos
        public void Pagar(){
            ConsultarSaldoDoCartao("12345");
        }//evento

       private void ConsultarSaldoDoCartao(string numero){}//como so está usando em um lugar consigo refatorar 
        
    }
    // Herança------------(Herança 1)
    class PagamentoBoleto : Pagamento// Pagamento boleto herda de pagamento as caracteristicas nem precisa colocar o codigo dnv
    {
        
        
        public string NumeroBoleto;
        

    }
}
/*  Modificadores: 
    private - so da para enchergar nas classes( se nao colocar nada na frente de classe ela por padrao é privado)
    protected
    internal
    piblic

*/