/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: Pausepage2.xaml.cs
 * Description: This is the Normal difficulty pause logic. It allows the 
 *              user to resume, restart, or quit the Normal Difficulty
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
    /// Interaction logic for Pausepage2.xaml
    /// </summary>
    public partial class Pausepage2 : Page
    {
        //Pause for Normal page
        public Pausepage2()
        {
            InitializeComponent();
        }

        //Resume Game
        private void Resume_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.GoBack();
        }

        //Restarts game
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new NormalPage());

        }

        //Quits game
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());

        }
    }
}
