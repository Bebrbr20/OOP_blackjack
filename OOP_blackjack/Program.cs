using OOP_blackjack;
using System;

namespace OOP_blackjack
{
    public class Program
    {
        private Balicek balicek;
        static void Main()
        {
            Hra hra1  =  new Hra();
            hra1.Hranice();
            Karta k1 = new Karta("s", "10");

            Console.WriteLine(k1.Nazev);
           // k1.Nazev = "";
        }
    }
}