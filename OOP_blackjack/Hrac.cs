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
        
      

        public Hrac() { }
        public Hrac(string _jmeno, int _score)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            
        }

        internal static void Kredity(string Score)
        {
            Console.WriteLine("Aktuálně máš"+ Score +"kreditů");

        }


       



    }
}