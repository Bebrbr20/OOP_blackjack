using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_blackjack
{
    internal class GameMenu
    {
        
        internal static int MainMenu()
            {

            Console.WriteLine("(H)rát");
            Console.WriteLine("(Ž)ebříček");
            Console.WriteLine("(P)ravidla");
            Console.WriteLine("(U)končit hru");

            string input = "";

            input = Console.ReadLine();
         

            switch(input.ToLower())
            {
                case "h":
                    return 1;
                    break;
                case "ž":
                    return 2;
                    break;
                case "p":
                    return 3;
                    break;
                case "u":
                    return 4;
                    break;
                default: return 5;

            };

        }
        public static void PlayerName()
        {
            Console.WriteLine("Vítej ve hře, zadej tvoje jméno :");
        }

        

    }
}
