﻿/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: Pausepage.xaml.cs
 * Description: This is the Easy difficulty pause logic. It allows the 
 *              user to resume, restart, or quit the Easy Difficulty
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
    /// Interaction logic for Pausepage.xaml
    /// </summary>
    public partial class Pausepage : Page
    {
        //Pause page for Easy
        public Pausepage()
        {
            InitializeComponent();
        }

        //Resume game
        private void Resume_Click(object sender, RoutedEventArgs e)
        { 
            this.NavigationService.GoBack();
            

        }

        //Restart Game
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Easypage());
            //Starts music
            Sound.PlayBackgroundMusic();
        }

        //Quit Game
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());
            
            //Starts music
            Sound.PlayBackgroundMusic();
        }

    }
}
