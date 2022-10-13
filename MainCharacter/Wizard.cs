namespace rpg_game.MainCharacter
{
    class Wizard : Character
    {
        
        // Wizard special attack
        private int magicSpellAttack;

        public Wizard(string name) : base(name, 30, 20, "Wizard 🧙‍", "Magic Spell Attack")
        {
            magicSpellAttack = 150;
        }


        // Wizard special attack
        public override int GetSpecialAttack()
        {
            return magicSpellAttack;
        }

    }
}