namespace rpg_game.Enemies;

public class Witch : IEnemy
{
    private int health;
    private int baseDamage;
        
    // Witch special enemy attack
    private int spellCast;

    public Witch()
    {
        health = 60;
        baseDamage = 35;
        spellCast = 80;
    }
    
    public int GetHealth()
    {
        return health;
    }

    public int GetBaseDamage()
    {
        return baseDamage;
    }
    
    // Witch special enemy attack
    public int GetSpecialEnemyAttack()
    {
        return spellCast;
    }
    
    public void PrintStats()
    {
        Console.WriteLine("---Zombie stats---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Witch's Spell Cast: " + GetSpecialEnemyAttack());
    }
    
}