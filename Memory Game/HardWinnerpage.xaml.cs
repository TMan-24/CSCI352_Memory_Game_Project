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
    /// Interaction logic for HardWinnerpage.xaml
    /// </summary>
    public partial class HardWinnerpage : Page
    {
        public HardWinnerpage()
        {
            InitializeComponent();
        }

        //Quits game
        private void quits_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new StartMenu());
        }
    }
}
