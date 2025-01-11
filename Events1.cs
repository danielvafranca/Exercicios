
using System;
using System.Security.Cryptography.X509Certificates;

namespace MeuApp
{
    class MeuApp
    
    {
        
        static void Main(string[] args)
        {
          var room = new Room(3);// [3] vou precisar passar quantos acentos disponiveis a sala tem
          room.RoomSoldOutEvent += OnRoomSoldOut; // Ligando o evento
          room.ReserveSeat(); //[6] -
          room.ReserveSeat();
          room.ReserveSeat();
          room.ReserveSeat();
        }
        static void OnRoomSoldOut(Object sender, EventArgs e)
        {
            Console.WriteLine("Sala Lotada!");
        }

    }
    public class Room
    {
        public Room (int seats)//[2] 
        {
            Seats = seats;
            seatsInUse = 0;

        }
        private int seatsInUse = 0;// [3] 
        public int Seats { get; set; }// [1] 
        public void ReserveSeat()// toda vez que alguem reservar um seat vai ser adicionado 1 nos seatsInUse

        {
            seatsInUse++;
            if(seatsInUse >= Seats)
            {
                //Evento fechado
                OnRoomSoldOut(EventArgs.Empty);
            }
            else
            {
                Console.WriteLine("Assento reservado.");
            }
        }
        public event EventHandler RoomSoldOutEvent;//[4]DEFINIÇÃO
        protected virtual void OnRoomSoldOut(EventArgs e )//[5]  INVOCAÇÃO  
        {
            EventHandler handler = RoomSoldOutEvent;
            handler?.Invoke(this, e);//
        } //
    }

} 
//HOW WORK?  PRIMEIRO DECLARA UM EVENTO ( EventHandler [4]) depois cria um metodo que manipulao evento (OnRoomSoldOut [5)
//[1] criei uma propriedade Seats
//[2] Criei um metodo construtor para receber quantos assentos essa sala tem
//[3] Criei uma propriedade Seats
//[4] Utilizamos o EventHandles para criar um evento            DEFINIÇÃO DO EVENTO
//[5] Utilizamos o On. exemplo.. ao a sala ficar disponivel faca isso = OnRoomSoldOut  
//[6] reservei cadeiras e como passou de 3