using rpgGame;

namespace rpg_game;

public class GameLogic
{

    public void PlayerTurn(Dice dice)
    {
        if (dice.RollDice() <= 4)
        {
            Console.WriteLine("A Zombie approaches, do you fight or run?");
            var response = Console.ReadLine();

            if (response == "r")
            {
                Console.WriteLine("You run away");
            }

            if (response == "f")
            {
                Console.WriteLine("You choose to fight! 🗡");
            }
            
        }
    }
    
    
}