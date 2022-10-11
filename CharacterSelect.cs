using rpg_game;

namespace rpgGame;

public class CharacterSelect
{

    public void CreateCharacter()
    {
        Console.WriteLine("Welcome to the game, please choose your character: ");
        Console.WriteLine("1. Knight");
        Console.WriteLine("2. Assassin");
        Console.WriteLine("3. Wizard");

        int characterSelect = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("What is your character's name? ");
            
        string name = Console.ReadLine();

        if (characterSelect == 1)
        {
            Knight knight = new Knight(name);
            Console.WriteLine("Hello " + name + ". You have chosen to be a Knight! 🗡\n");

            knight.PrintStats();
        }

        if (characterSelect == 2)
        {
            Assassin assassin = new Assassin(name);
            Console.WriteLine("Hello " + name + ". You have chosen to be an Assassin! 🥷\n");

            assassin.PrintStats();
        }

        if (characterSelect == 3)
        {
            Wizard wizard = new Wizard(name);
            Console.WriteLine("Hello " + name + ". You have chosen to be a Wizard! 🧙🪄\n");

            wizard.PrintStats();
        }
    }
    
}