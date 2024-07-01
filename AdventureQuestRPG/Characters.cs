using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Characters
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }

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
        }
    }

    public abstract class Monster : Characters
    {
        public Monster(string name)
        {
            Name = name;
            Health = 100;
            AttackPower = 15;
            Defense = 10;
        }
    }

    public class Zombie : Monster
    {
        public Zombie(string name) : base(name)
        {
            Name = name;
        }
    }
}
