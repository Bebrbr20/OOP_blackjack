using OOP_blackjack;
using System;

namespace OOP_blackjack
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Vítej ve hře, zadej tvoje jméno :");
            string name = Console.ReadLine();

            Console.WriteLine("Zadej tvůj věk :");
            string age = Console.ReadLine();

            Hrac Hrac1 = new Hrac()
            {
                Jmeno = name,
                Score = 0,
                Vek = age
            };

            
        }
    }
}