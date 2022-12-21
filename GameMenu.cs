using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    internal class GameMenu
    {

        // Hlavní menu vypíše hlavní nabídku, ze které může hrác vybírat + obsahuje logiku na ošetření vstupu.

        internal static int MainMenu()
            {
            Console.WriteLine("(H)rát");
            Console.WriteLine("(Ž)ebříček");
            Console.WriteLine("(P)ravidla");
            Console.WriteLine("(U)končit hru");

            string input = "";

            input = Console.ReadLine();
         

            switch(input.ToLower())
            {
                case "h":
                    return 1;
                    break;
                case "ž":
                    return 2;
                    break;
                case "p":
                    return 3;
                    break;
                case "u":
                    return 4;
                    break;
                default: return 5;

            };

        }

        // Fce se dotáže na název hráče

        public static void PlayerName()
        {
            Console.WriteLine("Vítej ve hře, zadej tvoje jméno :");
        }

        // tato funkce vypíše pravidla hry blackjack

        public static void Pravidla()
        {
            Console.WriteLine("Blackjack nebo také black jack je karetní hra často provozovaná v kasinu.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Předchůdcem blackjacku je francouzská karetní hra vingt-et-un („dvacet jedna“), která se objevila ve francouzských kasinech kolem roku 1700.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Každý hráč na začátku hry obdrží dvě karty a pak mu krupiér nabízí další karty.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Hráč se po každé rozhoduje, zda bude chtít další, nebo ne. ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Každý hráč na začátku hry obdrží dvě karty a pak mu krupiér nabízí další karty.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Základní princip hry je, že hráč chce mít hodnotu karet blíže 21 než krupiér, ale přitom 21 nepřekročit. ");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Vyhrává ten, kdo má po ukončení hry v ruce nejvyšší součet, aniž by překročil 21.");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Hráč, který má v ruce součet karet větší než 21, je takzvaně „trop“ neboli „přes“.");
        }

        // V průběhu hry se tato fce dotazuje na akci hráče. Obsahuje logiku pro ošetření vstupu a případnou možnost pro double

        internal static int InGameMenu(List<Karta> hracBalicek)
        {

            Console.WriteLine("(L)íznout");
            Console.WriteLine("(S)tát");
            if (hracBalicek.Count == 2)
            {
                Console.WriteLine("(D)ouble bet");
            }
            string input = "";

            input = Console.ReadLine();


            switch (input.ToLower())
            {
                case "l":
                    return 1;
                    break;
                case "s":
                    return 2;
                    break;
                case "d":
                    return 3;
                    break;
                    
          
                default: return 10;

            };

        }

        // Funkce se dotáže, zda-li chce hráč uložit svůj postup ve hře. Také obsahuje logiku pro ošetření vstupu.

        internal static int SaveScore()
        {

            Console.WriteLine("(A)no");
            Console.WriteLine("(N)e");


            string input = "";

            input = Console.ReadLine();


            switch (input.ToLower())
            {
                case "a":
                    return 1;
                    break;
                case "n":
                    return 2;
                    break;

                default: return 10;

            };

        }



    }
}
