using System.Numerics;
using System.Threading;

namespace AdventureQuestRPG
{
    public class Program
    {
        static void Main(string[] args)
        {
            Player player=new Player("jafar");
            Adventure adventure = new Adventure(player);
            adventure.startAdventure();

                   }
    }
}
