
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
    //prop
    {  
         public Pagamento()// construtor tem sempre o nome da classe (ctor)
        {
            Console.WriteLine("Iniciando o pagamento")
        }
        public DateTime Vencimento;
//-----------------------------------------------------------------------
    //      public DateTime Vencimento 
    // {   get {return Vencimento;}// tem sempre que retornar
    //     set{}
    // }

        //propfull
       private DateTime myVar;
       public DateTime MyProperty
       {
        get { return myVar; }
        set { myVar = value; }
       }
    //-=-==-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
        public void Pagar(string numero){}
        public void Pagar(string numero,DateTime vencimento){}
       
    }
    public class Address
    {
        string ZipCode;
    }
    
}
    
