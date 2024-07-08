using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
<<<<<<< HEAD
    public class Characters : IBattleStates
=======
    public class Player : IBattleStates
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
<<<<<<< HEAD

        public int OriginHealth { get; set; }

        public void PrintName()
=======
        public Inventory inventory { get; set; }
        public Player()
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
        {
            inventory = new Inventory();
        }

        public void RestPlayer()
        {
            Name = "Hero";
            Health = 100;
            AttackPower = 30;
            Defense = 10;
            //OriginHealth= 100;  
        }

<<<<<<< HEAD
    public abstract class Monster : Characters
    {
        public Monster(string name ,int health,int attackPower,int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
           
=======

        public abstract class Monster : IBattleStates
        {
            public string? Name { get; set; }
            public int Health { get; set; }
            public int MaxHealth { get; set; }
            public int AttackPower { get; set; }
            public int Defense { get; set; }
            public Monster(string name)
            {
                Name = name;
                Health = 100;
                MaxHealth = 100;
                AttackPower = 15;
                Defense = 10;
            }

            public void RestHealthMonster()
            {
                Health = MaxHealth;
            }
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
        }

<<<<<<< HEAD
    public class Zombie : Monster
    {
        public Zombie() : base("zombie",100,20,10)
        {
            
        }
    }

    public class BossMonster : Monster
    {
        public BossMonster() : base("BossMonster", 150, 50, 25)
        {

=======
        public class Zombie : Monster
        {
            public Zombie(string name) : base(name) { }
        }

        public class BossMonster : Monster
        {
            public BossMonster() : base("Boss Monster")
            {
                Health = 100;
                AttackPower = 40;
                Defense = 20;
            }
>>>>>>> 1c72a2afbb38fb6888a694b98ab8c5844ae9932a
        }
    }
}
