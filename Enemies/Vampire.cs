namespace rpg_game.Enemies;

public class Vampire : Enemy
{

    // Vampire special enemy attack
    private int bloodDrain;

    public Vampire() : base(50, 40, "Vampire 🧛🏻‍")
    {
        bloodDrain = 75;
    }

    // Vampire special enemy attack
    public override int GetSpecialEnemyAttack()
    {
        return bloodDrain;
    }
}