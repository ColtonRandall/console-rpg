namespace rpg_game.Enemies;

public class Werewolf : Enemy
{

    // Werewolf special enemy attack
    private int violentMauling;

    public Werewolf() : base(100, 60, "Werewolf 🐺")
    {
        violentMauling = 100;
    }

    // Werewolf special enemy attack
    public override int GetSpecialEnemyAttack()
    {
        return violentMauling;
    }

}