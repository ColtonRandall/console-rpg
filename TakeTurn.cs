namespace rpg_game;

public class TakeTurn : Dice
{
    private Random rnd = new();
    private int playerRoll;
    private bool rollingDice = true;


    public override int RollDice()
    {
        while (rollingDice)
        {
            playerRoll = rnd.Next(1, 7);
            Console.WriteLine("\npress 'r' to roll the dice 🎲");
            var response = Console.ReadLine();

            if ((response != "r") && (response != "q"))
            {
                Console.WriteLine("🚨 Please enter a valid response 🚨");
                continue;
            }

            if (response == "r")
            {
                Console.WriteLine("🎲 You rolled a " + playerRoll);
                return playerRoll;
            }

            if (response != "q") continue;
            Console.WriteLine("❌ You quit the game - Thanks for playing!");
            Environment.Exit(0);
        }
        rollingDice = false;
        return playerRoll;
    }
}