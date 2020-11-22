/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: MainWindow.xaml.cs
 * Description: This file is the logic for the Main window for the program.
 *              It starts a new instance of start menu at runtime.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Memory_Game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            //Loads the game to the window
            Loaded += loadGame;

            //Starts music
            Sound.PlayBackgroundMusic();
            
        }

        //Loads a new instance of StartMenu
        private void loadGame(object sender, RoutedEventArgs e)
        {
            Main.NavigationService.Navigate(new StartMenu());
        }

        
    }
}
