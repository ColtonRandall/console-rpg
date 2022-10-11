namespace rpg_game
{
    class Assassin : ICharacter
    {
        private string name;
        private int health;
        private int baseDamage;

        // Assassin special attack
        private int sneakAttack;

        public Assassin(string name)
        {
            this.name = name;
            health = 100;
            baseDamage = 35;
            sneakAttack = 130;
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
            Console.WriteLine("Sneak attack: " + GetSpecialAttack());;
        }
        
        // Assassin special attack
        public int GetSpecialAttack()
        {
            return sneakAttack;
        }

    }
    }
