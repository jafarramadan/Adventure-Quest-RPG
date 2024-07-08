using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventureQuestRPG
{
    public class Adventure
    {
        public BattleSystem battleSystem;
        public Player player;
        List<Monster> monsters;
        string currentLocation = "amman";

        public Adventure(Player player)
        {
            this.player = player;
            battleSystem = new BattleSystem();
            monsters = new List<Monster> { new Zombie(), new BossMonster() };
        }

        public void startAdventure() {

            
            while (true)
            {
                Console.WriteLine($"\nYou are currently in {currentLocation} location");
                Console.WriteLine("choose a number from availble action : \n1-discover a new location \n2-attack a monster \n3-end the game \n");
                string choice = Console.ReadLine().ToLower();
                select(choice);
                if (player.Health <= 0)
                {
                    Console.WriteLine("Game over!");
                    player.Health = 100;
                    break;
                }
               
            }
            Console.WriteLine("Adventure complete!");

        }

        public void select(string choice)
        {
            
            
            switch (choice)
            {
                case "1":
                    discoverLocation();
                    break;
                case "2":
                    randomMonsters();
                    break;
                case "3":
                    endGame();
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;

            }
        }

        public void randomMonsters()
        {
           
            Random  random = new Random();
            Monster enemy = monsters[random.Next(monsters.Count)];
            battleSystem.StartBattle(player, enemy);

        }

        public void discoverLocation()
        {
            List<string> list = new List<string>() { "1-irbid", "2-aqaba", "3-jarash" };
            Console.WriteLine("choose locatin ,just write the number");
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
            string num = Console.ReadLine();
            switch (num)
            {
                case "1":
                    currentLocation = "irbid";
                    break;
                case "2":
                    currentLocation = "aqaba";
                    break;
                case "3":
                    currentLocation = "jarash";
                    break;
                default:
                    Console.WriteLine("Invalid location. Please try again.");
                    discoverLocation();
                    return;

            }
            startAdventure();
        }
        public void endGame()
        {
            Console.WriteLine("the game ended");
            Environment.Exit(0);
        }


    }
}
