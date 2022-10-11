using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpg_game
{
    interface ICharacter
    {
        public string GetName();
        public int GetHealth();
        public int GetBaseDamage();
        public int GetSpecialAttack();
        public void PrintStats();
    }
}
