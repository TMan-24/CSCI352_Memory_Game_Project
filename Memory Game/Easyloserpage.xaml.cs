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
    /// Interaction logic for Easyloserpage.xaml
    /// </summary>
    public partial class Easyloserpage : Page
    {
        public Easyloserpage()
        {
            InitializeComponent();
        }

        //Restart Game
        private void Restart_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Easypage());
        }

        //Quit game
        private void Quit_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());
        }
    }
}
