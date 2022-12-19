using System;
using System.Linq;
using System.Collections.Generic;

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

            bool mainMenuRes = true;
            while (mainMenuRes == true)
            {
                var res = GameMenu.MainMenu();

                switch (res)
                {
                    case 1:                 
                        GameStart();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        GameMenu.Pravidla();
                        
                        break;
                    case 4:
                       System.Environment.Exit(1);
                        break;


                };

            }

        }
        internal static void GameStart()
        {
            bool hit = true;
               var Balicek = new Balicek(new string[] { "♥", "♦", "♣", "♠" }, new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" });
            
            var hracBalicek = Balicek.Lizni(2, Balicek.Karty);
               var krupierBalicek = Balicek.Lizni(1, Balicek.Karty);

            Balicek.KartyDealer(krupierBalicek);

            Balicek.KartyRuka(hracBalicek);

            if (Balicek.CountRuka(hracBalicek) > 21)
            {
                Console.WriteLine("Prohrál jsi, máš přes 21");
                hit = false;
            }
       
            if(hit == true)
            {
                bool intswitch = true;
                do
                {
                    int prubeh = GameMenu.InGameMenu();
                    Random random = new Random();
                    switch (prubeh)
                    {
                        case 1:
                            
                                List<Karta> lizni = new List<Karta>();

                                lizni = Balicek.Lizni(1, Balicek.Karty);
                                hracBalicek.AddRange(lizni);

                                Balicek.KartyRuka(hracBalicek);
                            if (Balicek.CountRuka(hracBalicek) >= 21)
                            {                        
                                intswitch = false;
                            }

                            break;
                        case 2:
                            while (Balicek.CountRuka(krupierBalicek) < 20)
                            {
                                Console.WriteLine("Krupiér si líže...");
                                System.Threading.Thread.Sleep(1000);
                               
                                List<Karta> liznik = new List<Karta>();

                                liznik = Balicek.Lizni(1, Balicek.Karty);
                                krupierBalicek.AddRange(liznik);

                               // Balicek.KartyRuka(krupierBalicek);
                            }
                            intswitch = false;
                            break;


                    };

                } while (intswitch == true);



                Console.WriteLine("Konec hry!");
                System.Threading.Thread.Sleep(1000);
                Balicek.KartyDealer(krupierBalicek);
                Balicek.KartyRuka(hracBalicek);

                if(Balicek.CountRuka(hracBalicek) > 21)
            {
                    Console.WriteLine("Prohrál jsi, máš přes 21");
                    hit = false;
                }
                else if (Balicek.CountRuka(krupierBalicek) > 21)
                {
                    Console.WriteLine("Vyhrál jsi, dealer má přes 21");
                    hit = false;
                }
                else if (Balicek.CountRuka(hracBalicek) > Balicek.CountRuka(krupierBalicek))
                {
                    Console.WriteLine("Vyhrál jsi, měl jsi více než dealer!");
                }
                else
                {
                    Console.WriteLine("Prohrál jsi, dealer má více!");
                }
            }


            

        }

        

    }

}
