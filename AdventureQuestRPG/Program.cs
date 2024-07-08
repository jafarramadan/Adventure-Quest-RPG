using System.Numerics;
using System.Threading;

namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Player player = new Player
                {
                    Name = "Hero",
                    Health = 100,
                    AttackPower = 30,
                    Defense = 10
                };

                Adventure adventure = new Adventure(player);

                adventure.InitiatesGame();

            }
            catch (Exception ex) { Console.WriteLine($"An error occurred: {ex.Message}"); }
        }

    }
}
