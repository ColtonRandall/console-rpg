namespace rpg_game;

public abstract class Character
{
    protected string name;
    protected int health;
    protected int baseDamage;
    protected string type;

    public Character(string name, int health, int baseDamage, string type)
    {
        this.name = name;
        this.health = health;
        this.baseDamage = baseDamage;
        this.type = type;
    }
    
    public string GetName()
    {
        return name;
    }
    
    public int GetHealth()
    {
        return health;
    }
    
    public int GetBaseDamage()
    {
        return baseDamage;
    }

    public string GetCharacterType()
    {
        return type;
    }

    public abstract int GetSpecialAttack();

    public void PrintStats()
    {
        Console.WriteLine("--- " + name + " stats---");
        Console.WriteLine("Health: " + GetHealth());
        Console.WriteLine("Base damage: " + GetBaseDamage());
        Console.WriteLine("Sneak attack: " + GetSpecialAttack());;
    }

}