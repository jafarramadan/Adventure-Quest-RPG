using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{
    public class Inventory
    {
        public List<Item> items;
        public Inventory()
        {
            items = new List<Item>();
        }
        public void AddItem(Item AddItems)
        {
            items.Add(AddItems);
            Console.WriteLine($"{AddItems.ItemName} added to Inventory");

        }
        public void RemoveItem(Item remove)
        {
            items.Remove(remove);
            Console.WriteLine($"You use the: {remove.ItemName}");

        }
        public void Display(Player player)
        {
            if (items.Count > 0)
            {
                int count = 0;
                Console.WriteLine(" \nInventory:");
                foreach (var item in items)
                {
                    count++;
                    Console.WriteLine($"\n{count}) {item.ItemName} - {item.Description}\n");
                }

                Console.Write("Enter the name of item here: ");
                string choise = Console.ReadLine()?.ToLower();

                if (!string.IsNullOrEmpty(choise))
                {
                    var itemFound = items.FirstOrDefault(i => i.ItemName.ToLower() == choise);
                    if (itemFound != null)
                    {
                        player.UseItem(itemFound);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nItem not found.");
                        Console.ResetColor();

                    }
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("\nThere are no items to display.\nFight monsters to get items\n");
                Console.ResetColor();
            }
        }
    }


}
