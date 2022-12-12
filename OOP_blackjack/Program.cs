using OOP_blackjack;
using System;

namespace OOP_blackjack
{
    public class Program
    {
        private Balicek balicek;
        public void Hrat()
        {
            bool pokracovaniHry = true;

            GameMenu.PlayerName();
            var name = Console.ReadLine();

            GameMenu.PlayerAge();
            var age = Convert.ToInt32(Console.ReadLine());

            var hrac =  new Hrac(name, 0, age);

            var krupier = new Krupier();

            balicek = new Balicek();
        }
    }
}