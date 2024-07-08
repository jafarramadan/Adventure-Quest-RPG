using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Player : IBattleStates
    {
        public string? Name { get; set; }
        public int Health { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public Inventory inventory { get; set; }
        public Player()
        {
            inventory = new Inventory();
        }

        public void RestPlayer()
        {
            inventory.items.Clear();
            Name = "Hero";
            Health = 100;
            AttackPower = 30;
            Defense = 10;
        }

        public void UseItem(Item item)
        {

            if (item is Potion potion)
            {
                Health += potion.HealthPotion;
                Console.WriteLine($"\nYou used a {item.ItemName} and gained {potion.HealthPotion} health.\n");

            }
            else if (item is Weapon weapon)
            {
                AttackPower += weapon.AttackBonus;
                Console.WriteLine($"\nYou are now equipped {weapon.ItemName} and gained {weapon.AttackBonus} attack power\n");
            }
            else if (item is Armor armor)
            {
                Defense += armor.DefeanseArmor;
            }
            inventory.RemoveItem(item);
        }

    }

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
    }

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
    }

}
