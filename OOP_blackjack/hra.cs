namespace OOP_blackjack
{
    public class Hra
    {

        public Balicek Balicek { get; set; }
        

        public void Hranice()
        {
            bool pokracovaniHry = true;

            GameMenu.PlayerName();
            var name = Console.ReadLine();
        


            var hrac = new Hrac(name, 1000);

            var krupier = new Krupier("Karel");

            Krupier.Welcome(hrac.Jmeno, krupier.Jmeno);

            System.Threading.Thread.Sleep(1000);

            int mainMenuRes = 10;
            do
            {
                mainMenuRes = GameMenu.MainMenu();

                switch (mainMenuRes)
                {
                    case 1:                 
                        GameStart();
                        break;
                    case 2:
                        
                        break;
                    case 3:
                        GameMenu.Pravidla();
                        continue;
                    case 4:
                        GameStart();
                        break;


                };

            } while (mainMenuRes >= 5);

        }
        internal static void GameStart()
        {
            bool hit = true;
               var Balicek = new Balicek(new string[] { "♥", "♦", "♣", "♠" }, new string[] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" });
               var hracBalicek = Balicek.Lizni(2, Balicek.Karty);
               var krupierBalicek = Balicek.Lizni(2, Balicek.Karty);

            if (Balicek.CountRuka(hracBalicek) > 21)
            {
                Console.WriteLine("Prohrál jsi, máš přes 21");
                hit = false;
            }
            Console.WriteLine(Balicek.CountRuka(hracBalicek));

            Console.ReadLine();
           
        }
    }

}
