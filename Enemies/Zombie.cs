namespace rpg_game.Enemies;

public class Zombie : Enemy
{
 
        
    // Zombie special enemy attack
    private int infectiousBite;

    public Zombie() : base(50, 30, "Zombie 🧟‍")
    {
        infectiousBite = 90;
    }

    public int ChanceOfZombie()
    {
        var random = new Random();
        int chanceOfZombieEncounter = random.Next(1, 10);
        Console.WriteLine(chanceOfZombieEncounter);
        return chanceOfZombieEncounter;
    }


    public override int GetSpecialEnemyAttack()
    {
        return infectiousBite;
    }
}