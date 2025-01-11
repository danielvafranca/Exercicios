
using System;
using System.Security.Cryptography.X509Certificates;

namespace MeuApp
{
    class MeuApp
    {
        static void RealizaPagamento(double valor) // toda vez que for delegar, a assinatura tem q ser a mesma (os dois tem void e double de entrada)
        {
            Console.WriteLine($"Pago o valor de{valor}");
        }
        static void Main(string[] args)
        {
          var pagar = new Pagamento.Pagar(RealizaPagamento); // "quem resolve a parte de pagamento é Realizar pagamento."   
          pagar(25);// agora estamos de fato realizar a funcao efetuar pagamento.       
        }
    }
    public class Pagamento
    {
        public delegate void Pagar(double valor);// toda vez que chamar a funcao pagar quero apontar para outra funcao que estara em outro lugar  do programa  ou em outra classe
        
            //[1]Remover o codigo
            
        
    }
   

} 