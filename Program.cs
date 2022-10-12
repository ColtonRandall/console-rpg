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
     * [] Depending on the roll, the player will move forward, encounter an enemy, or stumble upon treasure
     * [] When facing an enemy, the player can either fight or run
     * [] Fighting an enemy = randomise enemy health out of 100 and randomise attack points from both player and enemy
     * [] Fighting an enemy, determine IF the player or enemy successfully hits the other, and how much damage they deal/take.
     * [] Determine if a critical/special attack was performed
     * [] Defeating an enemy = XP and chance of dropping a health potion
     *
     */

    class Program
    {
        static void Main(string[] args)
        {
            // Create a new character
            var character = new CharacterSelect(new CharacterFactory()); // Inversion of control - giving CharacterSelect a CharacterFactory to use. Instead of being dependent on which factory. 
            character.CreateCharacter();

            // Create a new Zombie enemy
            var zombie = new Zombie();
            Console.WriteLine("\nBe careful, there's a zombie 🧟‍ out there!\n ");
            zombie.PrintStats();

            // Roll the dice to start the game
            var dice = new Dice();
            dice.RollDice();

            var logic = new GameLogic();
            logic.PlayerTurn(dice);
        }
    }
}