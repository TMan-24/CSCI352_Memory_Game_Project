/*
 * Arthur: Tony Anderson, Vrushank Mali
 * Date: 11/22/2020
 * Filename: Easypage.xaml.cs
 * Description: This file is the easy page logic. It starts a timer, 
 *              shows the pictures for 5 seconds and then hides
 *              them, shows the pictures when the cover button
 *              is clicked, checks if there is a match (gives a score 
 *              if there is, resets pictures if there is not), lets the 
 *              user pause, mute and unmute music, and finally either,
 *              when all matches are made, goes to the winner page, or
 *              if the timer goes to zero, goes to the loser page.
 *    
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
using System.Windows.Threading;

namespace Memory_Game
{
    /// <summary>
    /// Interaction logic for Easypage.xaml
    /// </summary>
    public partial class Easypage : Page
    {
        //Timer int
        private int Increment = 66;

        //ALL BOOL VALUES
        bool Once = true;
        bool label1 = true;
        bool label2 = true;
        bool label3 = true; 
        bool label4 = true; 
        bool label5 = true; 
        bool label6 = true; 
        bool label7 = true;
        bool label8 = true;
        bool End1 = true;
        bool End2 = true;
        bool End3 = true;
        bool End4 = true; 
        bool End5 = true;
        bool End6 = true;
        bool End7 = true;
        bool End8 = true;


        public Easypage()
        {
            InitializeComponent();
            
        }

        //Creating New Timer
        DispatcherTimer dt = new DispatcherTimer();

        //Loader
        private void Easy_Loaded(object sender, RoutedEventArgs e)
        {
            //Showing pictures for 5 secs
            if (Once == true)
            {
                Label1.Visibility = Visibility.Visible;
                Label2.Visibility = Visibility.Visible;
                Label3.Visibility = Visibility.Visible;
                Label4.Visibility = Visibility.Visible;
                Label5.Visibility = Visibility.Visible;
                Label6.Visibility = Visibility.Visible;
                Label7.Visibility = Visibility.Visible;
                Label8.Visibility = Visibility.Visible;
            }

            //Timer
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
            dt.Start();

            //hiding the music on (unmute button)
            Music_on.Visibility = Visibility.Hidden;
        }

        //Timer ticker
        private void Dt_Tick(object sender, EventArgs e)
        {
            //Hidding the pictures after 5 seconds
            if (Increment == 61)
            {
                Once = false;
                Label1.Visibility = Visibility.Hidden;
                Label2.Visibility = Visibility.Hidden;
                Label3.Visibility = Visibility.Hidden;
                Label4.Visibility = Visibility.Hidden;
                Label5.Visibility = Visibility.Hidden;
                Label6.Visibility = Visibility.Hidden;
                Label7.Visibility = Visibility.Hidden;
                Label8.Visibility = Visibility.Hidden;
            }

            //Actively checking for matches
            checker();

            //When all matches have been made
            if (End1 == false && End2 == false && End3 == false && End4 == false
                       && End5 == false && End6 == false && End7 == false && End8 == false)
            {
                GameEnder();
            }
            
            //Timer
            Increment--;

            //Loser end
            if (Increment == 0)
            {
                dt.Stop();
                this.NavigationService.Navigate(new Easyloserpage());
            }

            //To show the timer to the screen
            Timernum.Content = Increment.ToString();
        }

        //Winner end
        private void GameEnder()
        {
            //Stops timer
            dt.Stop();

            //fixing null exception
            End1 = true;
            End2 = true;
            End3 = true;
            End4 = true;
            End5 = true;
            End6 = true;
            End7 = true;
            End8 = true;

            //going to the winner page
            this.NavigationService.Navigate(new EasyWinnerpage());
        }

        //Checker for all matches or misses
        private void checker()
        {
            //label 1 and label 6
            if (label1 == false && label6 == false)
            {
                Label1.Visibility = Visibility.Hidden;
                Label6.Visibility = Visibility.Hidden;
                Picture1.Visibility = Visibility.Hidden;
                Picture6.Visibility = Visibility.Hidden;
                label1 = true;
                label6 = true;
                End1 = false;
                End6 = false;

                //Adding the score
                Scorenum.Content = Convert.ToString(Convert.ToInt32(Scorenum.Content) + 10);
            }
            else
            {
                if (label1 == false)
                {
                    if (label2 == false || label3 == false || label4 == false
                        || label5 == false || label7 == false || label8 == false)
                    {
                        Label1.Visibility = Visibility.Hidden;
                        Label2.Visibility = Visibility.Hidden;
                        Label3.Visibility = Visibility.Hidden;
                        Label4.Visibility = Visibility.Hidden;
                        Label5.Visibility = Visibility.Hidden;
                        Label6.Visibility = Visibility.Hidden;
                        Label7.Visibility = Visibility.Hidden;
                        Label8.Visibility = Visibility.Hidden;

                        //Setting all values to true so they can be checked again
                        label1 = true;
                        label2 = true;
                        label3 = true;
                        label4 = true;
                        label5 = true;
                        label6 = true;
                        label7 = true;
                        label8 = true;
                    }
                }
                if (label6 == false)
                {
                   if (label2 == false || label3 == false || label4 == false
                        || label5 == false || label7 == false || label8 == false)
                    {
                        Label1.Visibility = Visibility.Hidden;
                        Label2.Visibility = Visibility.Hidden;
                        Label3.Visibility = Visibility.Hidden;
                        Label4.Visibility = Visibility.Hidden;
                        Label5.Visibility = Visibility.Hidden;
                        Label6.Visibility = Visibility.Hidden;
                        Label7.Visibility = Visibility.Hidden;
                        Label8.Visibility = Visibility.Hidden;

                        //Setting all values to true so they can be checked again
                        label1 = true;
                        label2 = true;
                        label3 = true;
                        label4 = true;
                        label5 = true;
                        label6 = true;
                        label7 = true;
                        label8 = true;
                    }
                }

            }

            //label 2 and label 8
            if (label2 == false && label8 == false)
            {
                Label2.Visibility = Visibility.Hidden;
                Label8.Visibility = Visibility.Hidden;
                Picture2.Visibility = Visibility.Hidden;
                Picture8.Visibility = Visibility.Hidden;
                label2 = true;
                label8 = true;
                End2 = false;
                End8 = false;

                //Adding the score
                Scorenum.Content = Convert.ToString(Convert.ToInt32(Scorenum.Content) + 10);
            }

            if (label2 == false)
            {
                if (label1 == false || label3 == false || label4 == false
                        || label5 == false || label6 == false || label7 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
            }
            if (label8 == false)
            {
                if (label1 == false || label3 == false || label4 == false
                        || label5 == false || label6 == false || label7 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
             }

            //label 3 and label 7
            if (label3 == false && label7 == false)
            {
                Label3.Visibility = Visibility.Hidden;
                Label7.Visibility = Visibility.Hidden;
                Picture3.Visibility = Visibility.Hidden;
                Picture7.Visibility = Visibility.Hidden;
                label3 = true;
                label7 = true;
                End3 = false;
                End7 = false;

                //Adding the score
                Scorenum.Content = Convert.ToString(Convert.ToInt32(Scorenum.Content) + 10);
            }

            if (label3 == false)
            {
                if (label1 == false || label2 == false || label4 == false
                        || label5 == false || label6 == false || label8 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
            }
            if (label7 == false)
            {
                if (label1 == false || label2 == false || label4 == false
                        || label5 == false || label6 == false || label8 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
            }

            //label 4 and label 5
            if (label4 == false && label5 == false)
            {
                Label4.Visibility = Visibility.Hidden;
                Label5.Visibility = Visibility.Hidden;
                Picture4.Visibility = Visibility.Hidden;
                Picture5.Visibility = Visibility.Hidden;
                label4 = true;
                label5 = true;
                End4 = false;
                End5 = false;

                //Adding the score
                Scorenum.Content = Convert.ToString(Convert.ToInt32(Scorenum.Content) + 10);
            }

            if (label4 == false)
            {
                if (label1 == false || label2 == false || label3 == false
                        || label6 == false || label7 == false || label8 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
            }
            if (label5 == false)
            {
                if (label1 == false || label2 == false || label3 == false
                        || label6 == false || label7 == false || label8 == false)
                {
                    Label1.Visibility = Visibility.Hidden;
                    Label2.Visibility = Visibility.Hidden;
                    Label3.Visibility = Visibility.Hidden;
                    Label4.Visibility = Visibility.Hidden;
                    Label5.Visibility = Visibility.Hidden;
                    Label6.Visibility = Visibility.Hidden;
                    Label7.Visibility = Visibility.Hidden;
                    Label8.Visibility = Visibility.Hidden;

                    //Setting all values to true so they can be checked again
                    label1 = true;
                    label2 = true;
                    label3 = true;
                    label4 = true;
                    label5 = true;
                    label6 = true;
                    label7 = true;
                    label8 = true;
                }
            }
        }

        //Pause Screen
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dt.Stop();
            this.NavigationService.Navigate(new Pausepage());
            
        }

        //Unmute button logic
        private void Music_on_Click(object sender, RoutedEventArgs e)
        {
            Sound.PlayBackgroundMusic();
            Music_on.Visibility = Visibility.Hidden;
            Music_off.Visibility = Visibility.Visible;
        }

        //Mute Button logic
        private void Music_off_Click(object sender, RoutedEventArgs e)
        {
            Sound.MuteBackgroundMusic();
            Music_on.Visibility = Visibility.Visible;
            Music_off.Visibility = Visibility.Hidden;
        }

        //Picture Button logic 1 - 8
        private void Pic1_Click_1(object sender, RoutedEventArgs e)
        {
            Label1.Visibility = Visibility.Visible;
            label1 = false;
            
        }

        private void Pic2_Click_2(object sender, RoutedEventArgs e)
        {
            Label2.Visibility = Visibility.Visible;
            label2 = false;
            
        }

        private void Pic3_Click_3(object sender, RoutedEventArgs e)
        {
            Label3.Visibility = Visibility.Visible;
            label3 = false;
            
        }

        private void Pic4_Click_4(object sender, RoutedEventArgs e)
        {
            Label4.Visibility = Visibility.Visible;
            label4 = false;
            
        }

        private void Pic5_Click_5(object sender, RoutedEventArgs e)
        {
            Label5.Visibility = Visibility.Visible;
            label5 = false;
            
        }

        private void Pic6_Click_6(object sender, RoutedEventArgs e)
        {
            Label6.Visibility = Visibility.Visible;
            label6 = false;
            
        }

        private void Pic7_Click_7(object sender, RoutedEventArgs e)
        {
            Label7.Visibility = Visibility.Visible;
            label7 = false;
            
        }

        private void Pic8_Click_8(object sender, RoutedEventArgs e)
        {
            Label8.Visibility = Visibility.Visible;
            label8 = false;
        }
    }
}
