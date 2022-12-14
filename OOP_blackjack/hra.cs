using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    public class Hra
    {

        public Balicek Balicek { get; set; }
      
        public  Hra()
        {
        bool pokracovaniHry = true;

        GameMenu.PlayerName();
            var name = Console.ReadLine();

        GameMenu.PlayerAge();
            var age = Convert.ToInt32(Console.ReadLine());

        var hrac = new Hrac(name, 0, age);

       //var krupier = new Krupier(!);

            //balicek = new Balicek();
           
            while (pokracovaniHry)
            {
                Balicek = new Balicek(new string[] { "♥", "♦", "♣", "♠" }, new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "A" });
            }
        }
        
}
}
