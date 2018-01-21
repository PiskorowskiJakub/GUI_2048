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

namespace GUI_2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
          //  ResourceMain res = new ResourceMain(typeof(ResourceMainPL)) 
        }

        private void start(object sender, RoutedEventArgs e)
        {
            WyborPlanszy WyborPlanszy = new WyborPlanszy();
            WyborPlanszy.Show();
            this.Close();
        }

        private void sterowanie(object sender, RoutedEventArgs e)
        {
            Sterowanie Sterowanie = new Sterowanie();
            Sterowanie.Show();
            this.Close();
        }

        private void informacje(object sender, RoutedEventArgs e)
        {
            Informacje Informacje = new Informacje();
            Informacje.Show();
            this.Close();
        }

        private void wyjscie(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void _ManipulationInertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        {

        }

        
    }
}
