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
        return null;
    }


    public override int GetSpecialEnemyAttack()
    {
        return infectiousBite;
    }
}