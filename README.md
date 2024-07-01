# Adventure Quest RPG

Adventure Quest RPG is a simple console-based role-playing game (RPG) written in C#. Players engage in battles with monsters, taking turns to attack until one is defeated.

## Classes

### AdventureQuestRPG

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

