namespace rpg_game.Enemies;

public class Vampire : IEnemy
{
    private int health;
    private int baseDamage;
        
    // Vampire special enemy attack
    private int bloodDrain;

    public Vampire()
    {
        health = 50;
        baseDamage = 40;
        bloodDrain = 75;
    }
    
    public int GetHealth()
    {
        return health;
    }

    public int GetBaseDamage()
    {
        return baseDamage;
    }
    
    // Vampire special enemy attack
    public int GetSpecialEnemyAttack()
    {
        return bloodDrain;
    }
    
    public void PrintStats()
    {
        Console.WriteLine("---Vampire stats---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Blood drain attack: " + GetSpecialEnemyAttack());
    }
    
}