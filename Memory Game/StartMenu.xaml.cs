/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: StartMenu.xaml.cs
 * Description: This file is the logic for the Main Menu of the whole
 *              game. It takes the user to the difficulty they chose.
 */

using System;
using System.Collections.Generic;
using System.Linq;
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
    /// Interaction logic for StartMenu.xaml
    /// </summary>
    public partial class StartMenu : Page
    {
        public StartMenu()
        {
            InitializeComponent();
            
        }

        private void Easy_Click(object sender, RoutedEventArgs e)
        {
            
            this.NavigationService.Navigate(new Easypage());
            
        }

        private void Normal_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NormalPage());
        }

        private void Hard_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new HardPage());
        }
    }
}
