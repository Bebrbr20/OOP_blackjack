using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public enum Barva
    {
        srdcová,
        piková,
        trefová,
        kárová
    }
    public enum Vzor
    {
        eso,
        jednička,
        dvojka,
        trojka,
        čtyřka,
        pětka,
        šestka,
        sedmička,
        osmička,
        devítka,
        desítka,
        žolík,
        královna,
        král
    }
    public class Karta
    {
        public Barva Barva { get; }
        public Vzor Vzor { get; }
        public string HodnotaJmeno { get; }
        public int Hodnota { get; set; }
        public char EmojiSymbol { get; }

        public Karta(Barva barva, Vzor vzor)
        {
            Barva = barva;
            Vzor = vzor;

            switch (Barva)
            {
                case Barva.srdcová:
                    EmojiSymbol = '♣';

                    break;
                case Barva.piková:
                    EmojiSymbol = '♠';

                    break;
                case Barva.trefová:
                    EmojiSymbol = '♦';

                    break;
                case Barva.kárová:
                    EmojiSymbol = '♥';

                    break;
            }

            switch (Vzor)
            {
                case Vzor.desítka:
                    Hodnota = 10;
                    HodnotaJmeno = "10";
                    break;
                case Vzor.žolík:
                    Hodnota = 10;
                    HodnotaJmeno = "J";
                    break;
                case Vzor.královna:
                    Hodnota = 10;
                    HodnotaJmeno = "Q";
                    break;
                case Vzor.král:
                    Hodnota = 10;
                    HodnotaJmeno = "K";
                    break;
                case Vzor.eso:
                    Hodnota = 11;
                    HodnotaJmeno = "A";
                    break;
                default:
                    Hodnota = (int)vzor + 1;
                    HodnotaJmeno = Hodnota.ToString();
                    break;
            }
        }
        public void VypisKartu(Karta _karta)
        {
            Console.WriteLine(_karta.EmojiSymbol + _karta.HodnotaJmeno);
        }
    }

}
