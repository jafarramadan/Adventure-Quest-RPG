# Adventure Quest RPG

AdventureQuestRPG is a console-based RPG game where players embark on adventurous quests, battle monsters, and explore different locations. 


### Features

- **Battle System**: Engage in battles with various monsters.
- **Inventory Management**: Collect and use items to boost your stats.
- **Multiple Locations**: Explore different areas such as Town, Forest, Cave, and Mountain.
- **Boss Battles**: Face challenging boss monsters.

## Classes

- **Program**
  - Entry point of the application. Initializes a player and a zombie, then starts the battle.

- **BattleSystem**
  - Manages the battle logic, including attack calculations and the main battle loop.

- **Characters**
  - Base class for all characters in the game, containing properties like `Name`, `Health`, `AttackPower`, and `Defense`.

- **Player**
  - Inherits from `Characters`. Represents the player with predefined attributes.

- **Monster**
  - Abstract class inheriting from `Characters`. Represents generic monster behavior.

- **Zombie**
  - Inherits from `Monster`. Represents a specific type of monster.

- **BossMonster**
  - A more powerful type of monster.
 
- **Inventory**			
  - Manages the player's inventory of items.

- **IBattleStates**
  - Interface that defines the basic stats for entities that can engage in battle.
 
- **Item**
  - Abstract class for items in the game, with specific subclasses for Weapons, Armor, and Potions.


## How to Run

1. Clone the repository.
2. Open the project in Visual Studio development environment.
3. Run the `AdventureQuestRPG` project to start the game.

## Gameplay

1. The game starts with the player and a zombie.
2. The player and the zombie take turns attacking each other.
3. The battle continues until one of them is defeated.
4. The outcome of each attack and the remaining health of each character are displayed in the console.

## Example

```plaintext
The adventure begins!
Hero turn:
Hero attacks Zombie for 10 damage.
Zombie has 90 health left.

Zombie turn:
Zombie attacks Hero for 5 damage.
Hero has 95 health left.
...
The Game Is Completed!
```

