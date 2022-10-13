namespace rpg_game
{
    class Knight : Character
    {
        
        // Knight special attack
        private int criticalStrike;
        
        // Parameterless Constructor
        public Knight(string name) : base(name, 100, 50, "Knight 🗡", "Critical Strike")
        {
            criticalStrike = 100;
        }

        
        // Knight special attack
        public override int GetSpecialAttack()
        {
            return criticalStrike;
        }

    }
    
}
