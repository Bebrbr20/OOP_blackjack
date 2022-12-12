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
        public int Score = 0;
        public int Vek;
      

        public Hrac() { }
        public Hrac(string _jmeno, int _score, int _vek)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            this.Vek = _vek;
        }



    }
}