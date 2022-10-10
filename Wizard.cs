namespace rpg_game
{
    class Wizard : Character
    {
        private string name;
        private int health;
        private int baseDamage;
        
        // Wizard special attack
        private int magicSpellAttack;

        public Wizard(string name)
        {
            this.name = name;
            health = 100;
            baseDamage = 20;
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

        // Wizard special attack
        public int GetSpecialAttack()
        {
            return magicSpellAttack;
        }
    }
}