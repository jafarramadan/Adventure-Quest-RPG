using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Adventure
    {
        private Player player;
        public List<Monster> monsters;
        private string currentLocation;
        private Zombie zombie;
        private Random _random;
        private List<string> location = new List<string> { "Town", "Forest", "Cave", "Mountain" };

        public Adventure(Player player)
        {
            this.player = player;
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
                        player.inventory.Display(player);
                        break;
                    case "4":
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
                    DropHandleItem();
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
            if (int.TryParse(Console.ReadLine(), out int choise) && choise >= 1 && choise <= locations.Count)
            {
                currentLocation = locations[choise - 1];
                Console.ForegroundColor = ConsoleColor.Green;
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
        public void DropHandleItem()
        {

            Inventory inventory = new Inventory();

            Item dropped;
            int itemType = _random.Next(1, 4);
            switch (itemType)
            {
                case 1:
                    dropped = new Weapon { ItemName = "Sword", AttackBonus = 10, Description = "A sharp sword." };
                    break;
                case 2:
                    dropped = new Armor { ItemName = "Shield", DefeanseArmor = 15, Description = "A sturdy shield." };
                    break;
                case 3:
                    dropped = new Potion { ItemName = "Health Potion", HealthPotion = 20, Description = "Restores health." };
                    break;
                default:
                    dropped = null;
                    break;
            }
            if (dropped is Item)
            {
                bool isExist = player.inventory.items.Any(item => item.ItemName == dropped.ItemName);

                if (!isExist)
                {
                    player.inventory.AddItem(dropped);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\nYou found a {dropped.ItemName}!\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write($"\nYou have a {dropped.ItemName} You can use it!\n");
                    Console.ResetColor();
                }
            }
        }
    }

}
