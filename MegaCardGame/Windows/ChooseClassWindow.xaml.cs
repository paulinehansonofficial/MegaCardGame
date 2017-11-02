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
using System.Windows.Resources;

namespace MegaCardGame
{
    /// <summary>
    /// Interaction logic for ChooseClassWindow.xaml
    /// </summary>
    public partial class ChooseClassWindow : Window
    {
        Brush DefaultButtonColour = Brushes.SlateGray;

        int characterType = 0;
        BattleWindow battleWindow;

        public ChooseClassWindow()
        {
            InitializeComponent();
        }

        private void Start_click(object sender, RoutedEventArgs e)
        {
            this.battleWindow = new BattleWindow(characterType);
            battleWindow.Show();
            Close();
        }


        private void Quit_click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Set_Class(object sender, RoutedEventArgs e)
        {

            // This sets all of the buttons back to the default colour
            Mage_Button.Background = DefaultButtonColour;
            Warrior_Button.Background = DefaultButtonColour;
            Thief_Button.Background = DefaultButtonColour;

            Start_Button.IsEnabled = true;

            // This gets the button clicked, and sets the colour
            var button = sender as Button;
            string playerClass = button.Content.ToString();
            button.Background = Brushes.Bisque;

            switch (playerClass)
            {
                case "Mage":
                    CharacterDetails_TextBlock.Text = "These Are the mage stats";
                    characterType = 1;
                    break;
                case "Warrior":
                    CharacterDetails_TextBlock.Text = "These are the Warrior stats";
                    characterType = 2;
                    break;
                case "Thief":
                    CharacterDetails_TextBlock.Text = "These are the Thief stats";
                    characterType = 3;
                    break;

            }

        }
    }


}
