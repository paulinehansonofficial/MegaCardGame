using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCardGame
{
    public class GameController
    {
        public NonPlayerCharacter enemy;
        public PlayerCharacter player;
        public SpecialAttack special;

        public int PlayerSelectClass(int characterType)
        {
            switch (characterType)
            {
                case 1:
                    player = new Mage();
                    break;
                case 2:
                    player = new Warrior();
                    break;
                case 3:
                    player = new Thief();
                    break;
            }

            return characterType;
        }

        public void CheckBothHealth()
        {
            if (enemy.currentHealthPoints <= 0 || player.currentHealthPoints <= 0)
            {
                EndGameWindow gameOver = new EndGameWindow();
                if (enemy.currentHealthPoints <= 0)
                {
                    gameOver.Winner.Text = "Player Wins";
                }

                else
                {
                    gameOver.Winner.Text = enemy.enemyType + " Wins";
                }

                gameOver.ShowDialog();
                System.Windows.Application.Current.Shutdown();
            }
        }

        public void SendNormalAttack()
        {
            enemy.recieveAttack(player.baseDamage);
            CheckBothHealth();
            player.recieveAttack(enemy.baseDamage);
        }

        public void SendSpecialAttack()
        {
            int spkdam = player.specialAttackDamage();
            string type = player.GetType().ToString().Split('.')[1];

            if (spkdam >= 0)
            {
                enemy.recieveAttack(spkdam);
            }
            else if (type == "Mage")
            {
                player.recieveAttack(spkdam * -1);
            }
            else if (type == "Thief")
            {
                enemy.recieveAttack(Convert.ToInt32(player.baseDamage * .5));
            }

            CheckBothHealth();
            player.recieveAttack(enemy.baseDamage);
            CheckBothHealth();
        }
    }

}
