namespace rpg_game.Enemies;

public class Werewolf : IEnemy
{
    private int health;
    private int baseDamage;
        
    // Werewolf special enemy attack
    private int violentMauling;

    public Werewolf()
    {
        health = 100;
        baseDamage = 60;
        violentMauling = 100;
    }
    
    public int GetHealth()
    {
        return health;
    }

    public int GetBaseDamage()
    {
        return baseDamage;
    }
    
    // Werewolf special enemy attack
    public int GetSpecialEnemyAttack()
    {
        return violentMauling;
    }
    
    public void PrintStats()
    {
        Console.WriteLine("---Werewolf stats---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Violent mauling: " + GetSpecialEnemyAttack());
    }
    
}