using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    internal class Krupier
    {
        

        internal string Jmeno;


        internal Krupier(string _jmeno)
        {
            this.Jmeno = _jmeno;
           
        }

        internal static void Welcome(string JmenoH, string JmenoK)
        {
            Console.WriteLine("Zdravím " + JmenoH+", jsem Váš krupiér "+ JmenoK);
          
        }


    }
}