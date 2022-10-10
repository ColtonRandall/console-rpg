namespace rpg_game
{
    class Assassin : Character
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
            sneakAttack = 100;
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

        
        // Assassin special attack
        public int GetSpecialAttack()
        {
            return sneakAttack;
        }
    }
    }
