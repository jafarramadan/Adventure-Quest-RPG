using AdventureQuestRPG;
namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacksMonster()
        {
            Player player = new Player("Winner");
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            battle.Attack(player, monster);
            int health = monster.Health;

            Assert.Equal(90, health);
        }
        [Fact]
        public void MonsterAttacksPlayer()
        {
            Player player = new Player("Winner");
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            battle.Attack(monster, player);
            int health = player.Health;

            Assert.Equal(95, health);
        }

        [Fact]
        public void PlayerBattleWinner()
        {
            Player player = new Player("Winner");
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            string actual = battle.StartBattle(player, monster);

            Assert.Equal("Winner", actual);
        }
    }
}