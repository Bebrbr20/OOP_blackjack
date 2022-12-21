using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    // definice classy hráče


    public class Hrac
    {
        public string Jmeno;
        public int Score = 1000;
        
      

        public Hrac() { }
        public Hrac(string _jmeno, int _score)
        {
            this.Jmeno = _jmeno;
            this.Score = _score;
            
        }

        // Vypíše dostupné kredity hráče

        internal static void Kredity(int Score)
        {
            Console.WriteLine("Aktuálně máš"+ Score +"kreditů");

        }


       



    }
}