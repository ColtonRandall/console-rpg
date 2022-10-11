namespace rpg_game.Enemies;

public interface IEnemy
{
    public int GetHealth();
    public int GetBaseDamage();
    public int GetSpecialEnemyAttack();
    public void PrintStats();
}