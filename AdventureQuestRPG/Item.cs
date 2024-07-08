using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public abstract class Item
    {
        public string ItemName { get; set; }
        public string Description { get; set; }
    }

    public class Weapon : Item
    {
        public int AttackBonus { get; set; }
    }
    public class Armor : Item
    {
        public int DefeanseArmor { get; set; }
    }
    public class Potion : Item
    {
        public int HealthPotion { get; set; }
    }
}
