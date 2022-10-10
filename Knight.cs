﻿namespace rpg_game
{
    class Knight : Character
    {
        private string name;
        private int health;
        private int baseDamage;
        
        // Knight special attack
        private int criticalStrike;

        public Knight(string name)
        {
            this.name = name;
            health = 100;
            baseDamage = 50;
            criticalStrike = 100;
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

        public int GetSpecialAttack()
        {
            return criticalStrike;
        }
    }
    
}
