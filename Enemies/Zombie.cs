namespace rpgGame.Enemies;

public class Zombie : IEnemy
{
    private int health;
    private int baseDamage;
        
    // Zombie special enemy attack
    private int infectiousBite;

    public Zombie()
    {
        health = 50;
        baseDamage = 30;
        infectiousBite = 90;
    }
    
    public int GetHealth()
    {
        return health;
    }

    public int GetBaseDamage()
    {
        return baseDamage;
    }
    
    public int GetSpecialEnemyAttack()
    {
        return infectiousBite;
    }
    
    public void PrintStats()
    {
        Console.WriteLine("---Zombie stats---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Infectious bite: " + GetSpecialEnemyAttack());
    }
    
}