using rpg_game;

namespace rpgGame
{
    /*
     * Considerations:
     * - Player to choose a character
     * - Characters have different health and attack stats (interface?)
     * - Create enemies to fight (Interface?)
     * - Allow player to roll a dice (randomise 1-6)
     * - Dependin on the roll, the player will move forward, encounter an enemy, or stumble upon treasure
     * - When facing an enemey, the player can either fight or run
     * - FIghting an enemy = randomise enemey health out of 100 and randomise attack points from both player and enemy
     * - Defeating an enemy = XP and chance of dropping a health potion
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            Knight knight = new Knight(); 

            Console.WriteLine("Welcome to the game, please choose your character: ");
            Console.WriteLine("Knight");
            Console.WriteLine("Assassin");
            Console.WriteLine("Wizard");

            Console.WriteLine("Your player name is: " + knight.GetName());
        } 

    }
}