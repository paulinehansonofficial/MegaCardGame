using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class NonPlayerCharacter : Character
    {
        public string enemyType;

        public NonPlayerCharacter() : base(0, 0, 0)
        {
            string[] enemyTypes = { "Dragon", "Goblin", "Dwarf", "Ogre", "Swordsman", "Wizard" };

            Random random = new Random();
            int index = random.Next(0, enemyTypes.Length);

            this.enemyType = enemyTypes[index];

            switch (this.enemyType)
                {
                    case "Dragon":
                        this.maxHealthPoints = 40;
                        this.currentHealthPoints = 40;
                        this.baseDamage = 20;
                    break;

                    case "Goblin":
                        this.maxHealthPoints = 40;
                        this.currentHealthPoints = 40;
                        this.baseDamage = 20;
                    break;

                    case "Dwarf":
                        this.maxHealthPoints = 55;
                        this.currentHealthPoints = 55;
                        this.baseDamage = 15;
                    break;

                    case "Ogre":
                        this.maxHealthPoints = 60;
                        this.currentHealthPoints = 60;
                        this.baseDamage = 10;
                    break;

                    case "Swordsman":
                        this.maxHealthPoints = 50;
                        this.currentHealthPoints = 50;
                        this.baseDamage = 15;
                    break;


                    case "Wizard":
                        this.maxHealthPoints = 50;
                        this.currentHealthPoints = 50;
                        this.baseDamage = 15;
                    break;

                }
        }

        




        //public NonPlayerCharacter(string enemyType) : base(100, 80, 10)
        //{
        //    this.enemyType = enemyType;


        //}



    }
}
