using System;
using System.Security.Cryptography.X509Certificates;

namespace MeuApp
{
    class MeuApp
    
    {
        
        static void Main(string[] args)
        {
            //var payment = new IEnumerable<Payment>();// Mais cru praticamente lista de leitura
            // var payment = new ICollection<Payment>();// usar com  interface
            //var payment = new List<Payment>(); // mais completo
            IList<Payment> payments = new List<Payment>(); // mais completo add e remove itens da lista
            // payments.Add(new Payment());
            // payments.Remove(new Payment());
            payments.ToList();
            payments.AsEnumerable();
            payments.ToArray();
        }
        
    }
    public class Payment{}
   
}