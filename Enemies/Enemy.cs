namespace rpg_game.Enemies;

public abstract class Enemy
{
    private int health;
    private int baseDamage;
    private string type;

    protected Enemy(int health, int baseDamage, string type)
    {
        this.health = health;
        this.baseDamage = baseDamage;
        this.type = type;
    }
    
    public int GetHealth()
    {
        return health;
    }
    
    public int GetBaseDamage()
    {
        return baseDamage;
    }
    
    public abstract int GetSpecialEnemyAttack();
    
    public void PrintStats()
    {
        Console.WriteLine($@" ---{type} stats: ---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Blood drain attack: " + GetSpecialEnemyAttack());
    }

}