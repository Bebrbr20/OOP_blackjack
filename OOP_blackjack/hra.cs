using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public class Hra
    {

        public Balicek Balicek { get; set; }

        public void Hranice()
        {
            bool pokracovaniHry = true;

            GameMenu.PlayerName();
            var name = Console.ReadLine();



            var hrac = new Hrac(name, 1000);

            var krupier = new Krupier("Karel");

            Krupier.Welcome(hrac.Jmeno, krupier.Jmeno);

            System.Threading.Thread.Sleep(1000);

            int mainMenuRes = 10;
            do
            {
                mainMenuRes = GameMenu.MainMenu();

                switch (mainMenuRes)
                {
                    case 1:
                        GameStart();
                        break;


                };

            } while (mainMenuRes >= 5);
           
        }
        internal static void GameStart()
        {
            Balicek = new Balicek(new string[] { "♥", "♦", "♣", "♠" }, new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q","K", "A" });

        }
    }
    
}
