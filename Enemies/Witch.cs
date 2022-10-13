namespace rpg_game.Enemies;

public class Witch : Enemy
{

        
    // Witch special enemy attack
    private int spellCast;

    public Witch() : base(60, 35, "Witch 🧙🏻‍")
    {
        spellCast = 80;
    }

    // Witch special enemy attack
    public override int GetSpecialEnemyAttack()
    {
        return spellCast;
    }
}