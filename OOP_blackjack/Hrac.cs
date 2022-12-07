using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hrac
{
    internal class Hrac
    {
        internal string Jmeno;
        internal string Score;
        internal int Vek;
        //int RodneCislo;

        internal Hrac() { }
        internal Hrac(string _jmeno, string _score, int _vek)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            this.Vek = _vek;
        }



    }
}