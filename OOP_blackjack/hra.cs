using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_blackjack
{
    public class Hra
    {

        public Balicek Balicek { get; set; }

        internal static int GameStart(int bet)
        {

            int winning = 0;

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
            else if (Balicek.CountRuka(hracBalicek) == 21)
            {
                hit = false;
                Console.WriteLine("Vyhrál jsi " + bet * 2 + ", máš blackjack");
                winning += bet * 2;
            }

            bool doubleBet = false;
            if (hit == true)
            {
                bool intswitch = true;
                do
                {
                    int prubeh = GameMenu.InGameMenu(hracBalicek);
                    
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
                            while (Balicek.CountRuka(krupierBalicek) < 19)
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
                        case 3:
                            doubleBet = true;
                            lizni = Balicek.Lizni(1, Balicek.Karty);
                            hracBalicek.AddRange(lizni);

                            Balicek.KartyRuka(hracBalicek);
                            if (Balicek.CountRuka(hracBalicek) >= 21)
                            {
                                intswitch = false;
                            }

                            while (Balicek.CountRuka(krupierBalicek) < 19)
                            {
                                Console.WriteLine("Krupiér si líže...");
                                System.Threading.Thread.Sleep(1000);

                                List<Karta> liznik = new List<Karta>();

                                liznik = Balicek.Lizni(1, Balicek.Karty);
                                krupierBalicek.AddRange(liznik);

                            }
                            intswitch = false;
                            break;


                    };

                } while (intswitch == true);



                Console.WriteLine("Konec hry!");
                System.Threading.Thread.Sleep(1000);
                Balicek.KartyRukaDealer(krupierBalicek);
                Balicek.KartyRuka(hracBalicek);
                Console.WriteLine();

                if (Balicek.CountRuka(hracBalicek) > 21)
                {
                    Console.WriteLine("Prohrál jsi " + bet + ", máš přes 21");
                    winning -= bet;
                    hit = false;


                }
                else if (Balicek.CountRuka(krupierBalicek) > 21)
                {
                    if(doubleBet == true)
                    {
                        bet = bet * 2;
                    }
                    Console.WriteLine("Vyhrál jsi " + bet * 2 + ", dealer má přes 21");
                    winning += bet * 2;
                    hit = false;
                }
                else if (Balicek.CountRuka(hracBalicek) > Balicek.CountRuka(krupierBalicek))
                {
                    if (doubleBet == true)
                    {
                        bet = bet * 2;
                    }
                    Console.WriteLine("Vyhrál jsi " + bet * 2 + ", měl jsi více než dealer!");
                    winning += bet * 2;
                }
                else if (Balicek.CountRuka(hracBalicek) == Balicek.CountRuka(krupierBalicek))
                {
                    Console.WriteLine("Nerozodno, měl jsi stejně jako dealer!");
                    
                }
                else
                {

                    Console.WriteLine("Prohrál jsi " + bet + ", dealer má více!");
                    winning -= bet;
                }

                Console.WriteLine();


            }


            return winning;

        }

        internal static string SaveToLeaderboard(string Jmeno, int Score)
        {
            string newFileName = "../../../leaderboard.csv";

            string clientDetails = Jmeno + "," + Score + Environment.NewLine;


            if (!File.Exists(newFileName))
            {

                File.WriteAllText(newFileName, clientDetails);
                File.AppendAllText(newFileName, clientDetails);
            }
            else
            {
                File.AppendAllText(newFileName, clientDetails);
            }



            return "Úspěšně zaznamenáno!";
        }

        void DisplayLeaderboard()
        {
            string[] leaderbord = System.IO.File.ReadAllLines(@"../../../leaderboard.csv");
            List<int> poradi = new List<int>();
            foreach (string s in leaderbord)
            {
                char lastCharacter = s[s.Length - 1];
                poradi.Add(lastCharacter);

            }
            foreach (char item in poradi)
            {
                //Console.WriteLine(item);
            }
            foreach (string item in leaderbord)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("Stiskněte libovolnou klávesu pro ukončení\n\n->");
            Console.ReadLine();


        }

        internal static void DoubleHand()
        {

        }

        public void Hranice()
        {
            bool pokracovaniHry = true;

            GameMenu.PlayerName();
            var name = Console.ReadLine();
        


            var hrac = new Hrac(name, 1000);

            var krupier = new Krupier("Karel");

            int bet = 0;

            Krupier.Welcome(hrac.Jmeno, krupier.Jmeno);

            System.Threading.Thread.Sleep(1000);

            bool mainMenuRes = true;
            while (mainMenuRes == true)
            {
                var res = GameMenu.MainMenu();

                switch (res)
                {
                    case 1:
                        bool betStatus = true;
                        while (betStatus == true && hrac.Score > 0)
                        {
                            Hrac.Kredity(hrac.Score);

                            Console.WriteLine("Kolik si chceš vsadit?");
                            string input = Console.ReadLine();
                            int.TryParse(input, out bet);
                            if (bet <= hrac.Score)
                            {
                                betStatus = false;
                            }
                            else
                            {
                                Console.WriteLine("Nesmíte si vsadit více než máte!");
                            }
                            
                        }
                        if(hrac.Score > 0)
                        {
                            int winnings = GameStart(bet);
                            hrac.Score += winnings;
                        }
                        else
                        {
                            Console.WriteLine("Máte 0 kreditů, hra pro vás tímto končí.");
                            Console.WriteLine("Chcete zaznamenat své score?");
                            bool saveResponse2 = true;
                            do
                            {
                                int response = GameMenu.SaveScore();

                                switch (response)
                                {
                                    case 1:
                                        SaveToLeaderboard(hrac.Jmeno, hrac.Score);
                                        System.Environment.Exit(1);
                                        break;
                                    case 2:
                                        System.Environment.Exit(1);
                                        break;
                                }
                            } while (saveResponse2 == true);
                        }
                        
                        break;
                    case 2:
                        DisplayLeaderboard();
                        break;
                    case 3:
                        GameMenu.Pravidla();
                        
                        break;
                    case 4:
                        Console.WriteLine("Chcete zaznamenat své score?");
                        bool saveResponse = true;
                        do
                        {
                            int response = GameMenu.SaveScore();

                            switch (response)
                            {
                                case 1:
                                    SaveToLeaderboard(hrac.Jmeno, hrac.Score);
                                    saveResponse = false;
                                    System.Environment.Exit(1);
                                    break;

                                case 2:
                                    System.Environment.Exit(1);
                                    saveResponse = false;
                                    break;
                            }
                        } while (saveResponse == true);
                        break;


                };

            }

        }
        
    }

}
