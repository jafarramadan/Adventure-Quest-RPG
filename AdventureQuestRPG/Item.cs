﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public abstract class Item
    {
        
        public string ItemName { get; set; } = string.Empty;    
        public string Description { get; set; } = string.Empty;
        public Item(string ItemName, string Description) {
            Description = 
        }
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
