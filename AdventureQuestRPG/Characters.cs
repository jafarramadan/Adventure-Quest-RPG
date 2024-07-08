using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Characters : IBattleStates
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

        public int OriginHealth { get; set; }

        public void PrintName()
        {
            Console.WriteLine($"Player name: {Name}");
        }
    }

    public class Player : Characters
    {
        public Player(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 20;
            Defense = 10;
            //OriginHealth= 100;  
        }
    }

    public abstract class Monster : Characters
    {
        public Monster(string name ,int health,int attackPower,int defense)
        {
            Name = name;
            Health = health;
            AttackPower = attackPower;
            Defense = defense;
           
        }
    }

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

        }
    }
}
