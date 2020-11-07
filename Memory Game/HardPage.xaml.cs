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
using System.Windows.Threading;

namespace Memory_Game
{
    /// <summary>
    /// Interaction logic for HardPage.xaml
    /// </summary>
    public partial class HardPage : Page
    {
        private int Increment = 0;
        public HardPage()
        {
            InitializeComponent();
        }
        
        //Timer
        private void Hard_Loaded(object sender, RoutedEventArgs e)
        {
            DispatcherTimer dt = new DispatcherTimer();
            dt.Interval = TimeSpan.FromSeconds(1);
            dt.Tick += Dt_Tick;
            dt.Start();

            Music_on.Visibility = Visibility.Hidden;
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            Increment++;
            Timer.Content = Increment.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());
        }

        private void Music_on_Click(object sender, RoutedEventArgs e)
        {
            Sound.PlayBackgroundMusic();
            Music_on.Visibility = Visibility.Hidden;
            Music_off.Visibility = Visibility.Visible;
        }

        private void Music_off_Click(object sender, RoutedEventArgs e)
        {
            Sound.MuteBackgroundMusic();
            Music_on.Visibility = Visibility.Visible;
            Music_off.Visibility = Visibility.Hidden;
        }
    }
}
