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
    }
}
