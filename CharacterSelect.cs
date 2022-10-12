using rpg_game;
using rpg_game.MainCharacter;

namespace rpgGame;

public class CharacterSelect
{

    private readonly CharacterFactory _characterFactory;

    public CharacterSelect(CharacterFactory characterFactory)
    {
        _characterFactory = characterFactory;
    }
    
    

    public void CreateCharacter()
    {
        Console.WriteLine("Welcome to the game, please choose your character: ");
        Console.WriteLine("1. Knight");
        Console.WriteLine("2. Assassin");
        Console.WriteLine("3. Wizard");

        int characterSelect = Convert.ToInt32(Console.ReadLine());
            
        Console.WriteLine("What is your character's name? ");

        string name = Console.ReadLine();

        var character = _characterFactory.CreateCharacter(characterSelect, name);

        Console.WriteLine($@"Hello {character.GetName()}. You have chosen to be a {character.GetCharacterType()} \n");

        character.PrintStats();

    }
    
}