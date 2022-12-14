using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public class hra
    {
        public static void Hra()
        {
        bool pokracovaniHry = true;

        GameMenu.PlayerName();
            var name = Console.ReadLine();

        GameMenu.PlayerAge();
            var age = Convert.ToInt32(Console.ReadLine());

        var hrac = new Hrac(name, 0, age);

        var krupier = new Krupier();

            //balicek = new Balicek();

            while (pokracovaniHry)
            {
                
            }
        }
        
}
}
