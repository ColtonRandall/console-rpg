namespace rpg_game.MainCharacter
{
    class Wizard : ICharacter
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
            magicSpellAttack = 150;
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
        public void PrintStats()
        {
            Console.WriteLine("---Character stats---");
            Console.WriteLine("Health: " + GetHealth());
            Console.WriteLine("Base damage: " + GetBaseDamage());
            Console.WriteLine("Magic spell attack: " + GetSpecialAttack());
        }

        // Wizard special attack
        public int GetSpecialAttack()
        {
            return magicSpellAttack;
        }

    }
}