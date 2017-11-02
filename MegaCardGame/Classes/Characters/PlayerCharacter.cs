using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class PlayerCharacter : Character
    {
        public string characterName;
        public PlayerCharacter player;
        public SpecialAttack specialAttack;

        public PlayerCharacter(string characterName, SpecialAttack specialAttack) : base(50, 50, 10)
        {
            this.specialAttack = specialAttack;
            this.characterName = characterName;
        }

        public int normalAttackDamage()
        {
            return baseDamage;
        }

        public int specialAttackDamage()
        {
            int specialDamage = specialAttack.ReturnSpecialAttackDamage(baseDamage);
            return specialDamage;
        }

    }
}
