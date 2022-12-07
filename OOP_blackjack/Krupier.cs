using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    internal class Krupier
    {
        internal string Jmeno;
        internal string Score;
        internal int Vek;
        //int RodneCislo;

        internal Krupier() { }
        internal Krupier(string _jmeno, string _score, int _vek)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            this.Vek = _vek;
        }



    }
}