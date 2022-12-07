using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public class Hrac
    {
        public string Jmeno;
        public int Score;
        public int Vek;
      

        internal Hrac() { }
        internal Hrac(string _jmeno, string _score, int _vek)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            this.Vek = _vek;
        }



    }
}