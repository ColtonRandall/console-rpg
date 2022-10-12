namespace rpg_game
{
    class Assassin : Character
    {

        // Assassin special attack
        private int sneakAttack;

        public Assassin(string name) : base(name, 100, 35, "Assassin")
        {
            sneakAttack = 130;
        }
        


        
        // Assassin special attack
        public override int GetSpecialAttack()
        {
            return sneakAttack;
        }

    }
    }
