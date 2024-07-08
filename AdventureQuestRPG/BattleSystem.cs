using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventureQuestRPG
{

    public class BattleSystem
    {
        

    
        public int Attack(IBattleStates attacker, IBattleStates target)
            
        {
            int damage = attacker.AttackPower - target.Defense;
            if (damage < 0) damage = 0;

            target.Health -= damage;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{attacker.Name} attacks {target.Name} for {damage} damage." +
                $"\n{target.Name} has {target.Health} health left.");
            return damage;
        }

        public string StartBattle(Player player, Monster enemy)
        {
            while (player.Health > 0 && enemy.Health > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n{player.Name} turn:");
                Console.ResetColor();
                Console.WriteLine($"{player.Name} AttackPower: {player.AttackPower}, Defense: {player.Defense}");
                Attack(player, enemy);
                if (enemy.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nGreat! You defeated the {enemy.Name}!");
                    Console.ResetColor();
                    return player.Name;
                }

                Console.WriteLine($"\n{enemy.Name} turn:");
                Console.WriteLine($"{enemy.Name} AttackPower: {enemy.AttackPower}, Defense: {enemy.Defense}");
                Attack(enemy, player);
                if (player.Health <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"You were defeated by the {enemy.Name}.");
                    Console.ResetColor();
                    return enemy.Name;
                }
            }
            return "";
        }
    }

}