using rpg_game.Enemies;
using rpgGame;

namespace rpg_game
{
    /*
     * Considerations:
     * ✅ Player to choose a character 
     * ✅  Characters have different health and attack stats (interface?)
     * ✅  Create enemies to fight (Interface? Zombie, Werewolf, Vampire, Witch)
     * ✅  Allow player to roll a dice (randomise 1-6)
     * ✅ Depending on the roll, the player will move forward, encounter an enemy, or stumble upon treasure
     * [] Randomise the likelihood of finding treasure
     * [] Create simple test file
     * [] When facing an enemy, the player can either fight or run
     * [] Fighting an enemy = randomise enemy health out of 100 and randomise attack points from both player and enemy
     * [] Fighting an enemy, determine IF the player or enemy successfully hits the other, and how much damage they deal/take.
     * [] Determine if a critical/special attack was performed
     * [] Defeating an enemy = XP and chance of dropping a health potion
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new character
            var character =
                new CharacterSelect(
                    new CharacterFactory()); // Inversion of control - giving CharacterSelect a CharacterFactory to use. Instead of being dependent on which factory. 
            character.CreateCharacter();

            while (true)
            {
            // Roll the dice to start the game
            var dice = new TakeTurn();
            int diceRoll = dice.RollDice();

            switch (diceRoll)
                {
                    case 1:
                        // find a health potion or treasure -- TODO: Randomise this
                        Console.WriteLine("You stumble upon a treasure ⚱️");
                        continue;
                    case > 1 and < 4:
                    {
                        // Create a new enemy -- TODO: randomise which enemy will be created 
                        var zombie = new Zombie();
                        Console.WriteLine("\nBe careful, there's a zombie 🧟‍ out there!\n ");
                        zombie.PrintStats();

                        // Chance of a zombie encounter -- TODO: randomise this?
                        continue;
                    }
                    case > 4 and <= 6:
                        Console.WriteLine("You move forward");
                        continue;
                }
            }
        }
    }
}

