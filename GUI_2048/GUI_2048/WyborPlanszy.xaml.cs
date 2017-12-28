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
using System.Windows.Shapes;

namespace GUI_2048
{
    /// <summary>
    /// Interaction logic for WyborPlanszy.xaml
    /// </summary>
    public partial class WyborPlanszy : Window
    {
        public WyborPlanszy()
        {
            InitializeComponent();
        }
        private void Plansza4x4(object sender, RoutedEventArgs e)
        {
            Plansza4x4 Plansza4x4 = new Plansza4x4();
            Plansza4x4.Show();
            this.Close();
        }

        private void wyjscie(object sender, RoutedEventArgs e)
        {
            MainWindow wyjscie = new MainWindow();
            wyjscie.Show();
            this.Close();
        }
    }
}
