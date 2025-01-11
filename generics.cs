
using System;
using System.Security.Cryptography.X509Certificates;

namespace MeuApp
{
    class MeuApp
    
    {
        
        static void Main(string[] args)
        {
        //[3] Toda vez que eu for fazer a instancia ele vai esperar um tipo. Datacontext<Person>();
            var person = new Person();
            var payment = new Payment(); 
            var subscription = new subscription(); 
            var context = new Datacontext<Person, Payment, subscription>(); // se chamar para Payment o context.save falaha pos esta o person como parametro 
            context.Save(person);// ele tambem vai esperar uma pessoa como entidade
            context.Save(payment);// ele tambem vai esperar uma pessoa como entidade
            context.Save(subscription);// ele tambem vai esperar uma pessoa como entidade
        }
        
    }
    //preciso salvar todas as informacoes a baixo, por isso coloco o Save como generico
    public class Datacontext<P, PA, S>//[1] Abrimos <>  e colocamos uma definicao "T"
    //Posso limitar... P so consigo usar com person
        where P: Person
        where PA: Payment
        where S: Subscription
    {
        public void Save(P entidade)//[2]
        {

        }
        public void Save(PA entidade)//[2]
        {

        }
        public void Save(S entidade)//[2]
        {

        }
    }
    public class Person{}
    public class Payment{}
    public class Subscription{}
}