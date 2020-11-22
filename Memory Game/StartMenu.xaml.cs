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

        /*public void Pausechecker()
        {
            Pausepage a = new Pausepage();
            int b = a.Resumecheck();
            if (b == 1)
            {
                this.NavigationService.GoBack();
            }
            else
            {
                int c = a.Restartcheck();
                if (c == 2)
                {
                    this.NavigationService.Refresh();
                }
                else
                {
                    int d = a.Quitcheck();
                    if (d == 3)
                    {
                        this.NavigationService.Navigate(new StartMenu());
                    }
                }
            }
        }*/
    }
}
