/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: NormalWinnerpage.xaml.cs
 * Description: This file is the results logic for normal when the player
 *              wins. It allows them to quit.
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
    /// Interaction logic for NormalWinnerpage.xaml
    /// </summary>
    public partial class NormalWinnerpage : Page
    {
        public NormalWinnerpage()
        {
            InitializeComponent();
        }

        //Quits game
        private void quits_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());
            
            //Starts music
            Sound.PlayBackgroundMusic();
        }
    }
}
