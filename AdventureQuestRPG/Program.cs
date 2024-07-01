using System.Numerics;
using System.Threading;

namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player("Hero");
            Monster zombie = new Zombie("Zombie");
            BattleSystem battleSystem = new BattleSystem();

            Console.WriteLine("The adventure begins!");
            battleSystem.StartBattle(player, zombie);
        }
    }
}
