using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
namespace AdventureQuestRPG
{
    public class Adventure
    {
<<<<<<< HEAD
        public BattleSystem battleSystem;
        public Player player;
        List<Monster> monsters;
        string currentLocation = "amman";
=======
        private Player player;
        public List<Monster> monsters;
        private string currentLocation;
        private Zombie zombie;
        private Random _random;
        private List<string> location = new List<string> { "Town", "Forest", "Cave", "Mountain" };
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a

        public Adventure(Player player)
        {
            this.player = player;
<<<<<<< HEAD
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


=======
            monsters = new List<Monster>()
            {
            new Zombie("Zombie"),
            new Zombie("Goblin"),
            new Zombie("Hag"),
            new Zombie("Ogre"),
            new Zombie("Bloaters"),
            new Zombie("Belchers"),
            new Zombie("Bones on a Loan"),
            new BossMonster()
            };
            currentLocation = "Town";
            _random = new Random();
        }
        public void InitiatesGame()
        {
            bool isRun = true;
            while (isRun)
            {
                Console.Write($"\nYou are in: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{currentLocation}\n");
                Console.ResetColor();
                Console.WriteLine("Choose an action:\n" +
                    " 1) Adventure the Monster.\n" +
                    " 2) Move to the next Town.\n" +
                    " 3) View Inventory that you have.\n" +
                    " 4) Exit the Game.");

                Console.Write(" Answer Here: ");
                string? chios = Console.ReadLine();
                switch (chios)
                {
                    case "1":
                        AdventureMonster();
                        break;
                    case "2":
                        Move(location);
                        break;
                    case "3":
                        isRun = false;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nPlease choose a valid option.");
                        Console.ResetColor();
                        break;
                }
            }
        }
        public string AdventureMonster()
        {
            int encountersMonsters = _random.Next(0, monsters.Count);
            if (encountersMonsters <= monsters.Count)
            {
                BattleSystem battle = new BattleSystem();
                Monster monster = monsters[encountersMonsters];
               
                monster.RestHealthMonster();

                Console.WriteLine($"You Attack a {monster.Name}");

                battle.StartBattle(player, monster);
                string result = battle.StartBattle(player, monster);

                if (monster.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nYou defeated the {monster.Name}!");
                    Console.ResetColor();
                }
                return result;
            }
            else
            {
                Console.WriteLine("No monster to attack.");
            }
            return "";

        }

        public string Move(List<string> locations)
        {
            
            Console.WriteLine("Choose a location to move to:");     
            for (int i = 0; i < locations.Count; i++)
            {
                Console.WriteLine($"{i + 1}) {locations[i]}");
            }
            Console.Write("Answer Here: ");
            if(int.TryParse(Console.ReadLine(), out int choise) && choise >= 1 && choise <= locations.Count)
            {
                currentLocation = locations[choise - 1];
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine($"You are moved to {currentLocation}");
                Console.ResetColor();   
                return currentLocation;
            }
            else
            {
                Console.WriteLine("Invalid choise");
                return currentLocation;
            }
        } 
         
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
    }
}
