using rpg_game.MainCharacter;

namespace rpg_game;

// Factory Pattern

public class CharacterFactory
{
    public Character CreateCharacter(int characterType, string name)
    {
            if (characterType == 1)
            {
                return new Knight(name);
            }

            if (characterType == 2)
            {
                return new Assassin(name);
            }

            if (characterType == 3)
            {
                return new Wizard(name);
            }

            return null;
    }
}