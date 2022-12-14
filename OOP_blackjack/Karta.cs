using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
   
    public class Karta
    {
       public string Barva { get; set; }
        public string Symbol { get; set; }

        public string Nazev { get { return Barva + Symbol; } }

        public Karta(string barva, string symbol)
        {
            Barva = barva;
            Symbol = symbol;
        }
    } 

}
