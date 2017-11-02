using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaCardGame;

namespace MegaCardGame
{
    public class Character
    {
        public int baseDamage;
        public int currentHealthPoints;
        public int maxHealthPoints;

        public Character(int maxHealthPoints, int currentHealthPoints, int baseDamage)
        {
            this.maxHealthPoints = maxHealthPoints;
            this.currentHealthPoints = currentHealthPoints;
            this.baseDamage = baseDamage;
        }

        public void recieveAttack(int baseDamage)
        {
            currentHealthPoints = (currentHealthPoints - baseDamage);

        }

        public int returnAttackDamage()
        {
            return baseDamage;
        }

    }
}
