using OOP_blackjack;
using System;

namespace OOP_blackjack
{
    public class Program
    {
        private Balicek balicek;
        
        static void Main()
        {
            //spuštění hry zde

            Hra hra1  =  new Hra();
            hra1.Hranice();
            
        }
    }
}