using AdventureQuestRPG;
namespace AdventureQuestRPGTests
{
    public class UnitTest1
    {
        [Fact]
        public void PlayerAttacksMonster()
        {
            Player player = new Player()
            {
                Name = "Winner",
                Health = 100,
                AttackPower = 30,
                Defense = 10
            }; ;
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            battle.Attack(player, monster);
            int health = monster.Health;

            Assert.Equal(80, health);
        }

        [Fact]
        public void MonsterAttacksPlayer()
        {
            Player player = new Player()
            {
                Name = "Winner",
                Health = 100,
                AttackPower = 30,
                Defense = 10
            }; ;
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            battle.Attack(monster, player);
            int health = player.Health;

            Assert.Equal(95, health);
        }

        [Fact]
        public void PlayerBattleWinner()
        {
            Player player = new Player()
            {
                Name = "Winner",
                Health = 100,
                AttackPower = 30,
                Defense = 10
            };
            Monster monster = new Zombie("Zombie");
            BattleSystem battle = new BattleSystem();
            string actual = battle.StartBattle(player, monster);

            Assert.Equal("Winner", actual);
        }

        [Fact]
        public void TestMovingToNewLocation()
        {
            List<string> location = new List<string> { "Town", "Forest", "Cave", "Mountain" };

            Player player = new Player
            {
                Name = "Winner",
                Health = 100,
                AttackPower = 30,
                Defense = 10
            };

            var adventure = new Adventure(player);

            using (var sw = new StringWriter())
            using (var sr = new StringReader("2"))  // choose the index form List "Forest"
            {
                Console.SetOut(sw);
                Console.SetIn(sr);

                string result = adventure.Move(location);

                Assert.Equal("Forest", result);
            }
        }

        [Fact]
        public void TestEncounteringBossMonster()
        {
            Player player = new Player
            {
                Name = "Hero",
                Health = 100,
                AttackPower = 30,
                Defense = 10
            };

            Adventure adventure = new Adventure(player);

            adventure.AdventureMonster(); 

            Assert.Contains(adventure.monsters, m => m is BossMonster);
        }
    }

}


