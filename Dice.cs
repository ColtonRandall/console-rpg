namespace rpg_game;

public class Dice
{
    private Random rnd = new();
    private int playerRoll;
    
    public int RollDice()
    {
        playerRoll = rnd.Next(1, 7);
        while (true)
        {
            Console.WriteLine("press 'r' to roll the dice and start the game: 🎲");
            var response = Console.ReadLine();
            if (response != "r")
            {
                Console.WriteLine("🚨 Please enter a valid response 🚨");
                continue;
            }

            if (response == "r")
            {
                Console.WriteLine("🎲 You rolled a " + playerRoll);
                return playerRoll;
                
            }
        }
    }
}