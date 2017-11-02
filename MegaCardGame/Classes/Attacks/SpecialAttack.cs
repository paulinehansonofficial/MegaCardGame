using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class SpecialAttack : Attack
    {
        public int attackDamageMultiplier = 0;
        public double attackSuccessRate = 0;

        public SpecialAttack(int attackDamageMultiplier, double attackSuccessRate)
        {
            this.attackDamageMultiplier = attackDamageMultiplier;
            this.attackSuccessRate = attackSuccessRate;
        }


        public int ReturnSpecialAttackDamage(int baseDamage)
        {
            Random randomNumber = new Random();

            if (attackSuccessRate * 100 >= randomNumber.Next(1, 101))
            {
                return baseDamage * attackDamageMultiplier;
            }
            else
            {
                return baseDamage * -1;
            }

        }




    }
}
