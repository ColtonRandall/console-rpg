using rpg_game;

namespace rpgGame
{
    /*
     * Considerations:
     * ✅ Player to choose a character 
     * [] Characters have different health and attack stats (interface?)
     * [] Create enemies to fight (Interface?)
     * [] Allow player to roll a dice (randomise 1-6)
     * [] Depending on the roll, the player will move forward, encounter an enemy, or stumble upon treasure
     * [] When facing an enemy, the player can either fight or run
     * [] Fighting an enemy = randomise enemy health out of 100 and randomise attack points from both player and enemy
     * [] Defeating an enemy = XP and chance of dropping a health potion
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            int characterSelect;
            string name;

            Console.WriteLine("Welcome to the game, please choose your character: ");
            Console.WriteLine("1. Knight");
            Console.WriteLine("2. Assassin");
            Console.WriteLine("3. Wizard");

            characterSelect = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your character's name? ");
            name = Console.ReadLine();

            if (characterSelect == 1)
            {
                Knight knight = new Knight(name);
                Console.WriteLine("Hello " + name + ". You have chosen to be a Knight! 🗡\n");
                
                // TODO remove below
                Console.WriteLine("---Character stats---");
                Console.WriteLine("Health: " + knight.GetHealth());
                Console.WriteLine("Base damage: " + knight.GetBaseDamage());
                Console.WriteLine("Critical strike: " + knight.GetSpecialAttack());
            }

            if (characterSelect == 2)
            {
                Assassin assassin = new Assassin(name);
                Console.WriteLine("Hello " + name + ". You have chosen to be an Assassin! 🥷\n");
                Console.WriteLine("---Character stats---");
                Console.WriteLine("Health: " + assassin.GetHealth());
                Console.WriteLine("Base damage: " + assassin.GetBaseDamage());
                Console.WriteLine("Sneak attack: " + assassin.GetSpecialAttack());
            }

            if (characterSelect == 3)
            {
                Wizard wizard = new Wizard(name);
                Console.WriteLine("Hello " + name + ". You have chosen to be a Wizard! 🧙🪄\n");
                Console.WriteLine("---Character stats---");
                Console.WriteLine("Health: " + wizard.GetHealth());
                Console.WriteLine("Base damage: " + wizard.GetBaseDamage());
                Console.WriteLine("Magic spell attack: " + wizard.GetSpecialAttack());
            }
        }
    }
}