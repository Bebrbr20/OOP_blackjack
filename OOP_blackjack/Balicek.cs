using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public class Balicek
    {

       

        public List<Karta> Karty = new List<Karta>();

        public Balicek(string[] barvy, string[] hodnoty)
        {
            foreach (var barva in barvy)
            {
                foreach (var hodnota in hodnoty)
                {
                    Karty.Add(new Karta(barva, hodnota));
                }
            }
        }

        public List<Karta> Lizni(int Pocet, List<Karta> Karty)
        {
            List<Karta> Ruka = new List<Karta>();


            Random random = new Random();

            for (int i = 0; i < Pocet; i++)
            {
                int num = random.Next(Karty.Count);

                Ruka.Add(Karty[num]);
                Karty.RemoveAt(num);

            }
            return Ruka;
        }

        public static int CountRuka(List<Karta> Karty)
        {
            int soucet = 0;

            foreach(var karta in Karty)
            {
                switch (karta.Symbol)
                {
                    case "A":
                        if (soucet > 11)
                        {
                            soucet += 1;
                        }
                        else
                        {
                            soucet += 11;
                        }
                        break;

                    case "2":
                        soucet += 2;
                        break;
                    case "3":
                        soucet += 3;
                        break;
                    case "4":
                        soucet += 4;
                        break;
                    case "5":
                        soucet += 5;
                        break;
                    case "6":
                        soucet += 6;
                        break;
                    case "7":
                        soucet += 7;
                        break;
                    case "8":
                        soucet += 8;
                        break;
                    case "9":
                        soucet += 9;
                        break;
                    case "10":
                        soucet += 10;
                        break;
                    case "J":
                        soucet += 10;
                        break;
                    case "Q":
                        soucet += 10;
                        break;
                    case "K":
                        soucet += 10;
                        break;
                }
            }
            foreach (var karta in Karty)
            {
                switch (karta.Symbol)
                {
                    case "A":
                        if (soucet > 11)
                        {
                            soucet += 1;
                        }
                        else
                        {
                            soucet += 11;
                        }
                        break;

                    
                }
            }

            return soucet;
        }

        internal static void KartyRuka(List<Karta> Karty)
        {
            Console.Write("Vaše karty jsou: ");
            foreach (var karta in Karty)
            {
                Console.Write(karta.Nazev + " ");
            }
            Console.WriteLine("a celkový součet je " + CountRuka(Karty));
        }
        internal static void KartyRukaDealer(List<Karta> Karty)
        {
            Console.Write("Dealerovy karty jsou: ");
            foreach (var karta in Karty)
            {
                Console.Write(karta.Nazev + " ");
            }
            Console.WriteLine("a celkový součet je " + CountRuka(Karty));
        }

        internal static void KartyDealer(List<Karta> Karty)
        {
            
            Console.WriteLine("Dealer má " + Karty[0].Nazev);
        }

        

    }
}
