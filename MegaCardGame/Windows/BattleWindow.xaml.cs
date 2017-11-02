using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Resources;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MegaCardGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class BattleWindow : Window
    {
        GameController controller;

        public BattleWindow(int characterType)
        {

            InitializeComponent();


            controller = new GameController();
            controller.PlayerSelectClass(characterType);
            controller.enemy = new NonPlayerCharacter();


            this.PlayerName.Content = controller.player.characterName;
            this.EnemyName.Content = controller.enemy.enemyType;
            this.PlayerHP.Content = (controller.player.currentHealthPoints.ToString() + "HP");
            this.EnemyHP.Content = (controller.enemy.currentHealthPoints.ToString() + "HP");
        }

        private void Special_attack_click(object sender, RoutedEventArgs e)
        {
            controller.SendSpecialAttack();
            PlayerHP.Content = (controller.player.currentHealthPoints.ToString() + "HP");
            EnemyHP.Content = (controller.enemy.currentHealthPoints.ToString() + "HP");
        }

        private void Normal_attack_click(object sender, RoutedEventArgs e)
        {
            controller.SendNormalAttack();
            PlayerHP.Content = (controller.player.currentHealthPoints.ToString() + "HP");
            EnemyHP.Content = (controller.enemy.currentHealthPoints.ToString() + "HP");
        }

    }
}
