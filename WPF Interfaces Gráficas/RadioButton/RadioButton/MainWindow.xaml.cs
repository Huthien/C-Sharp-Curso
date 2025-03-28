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

namespace RadioButton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //Eventos que se generan al hacer click en los radiobutton:
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            Rojo.Visibility = Visibility.Visible;
            Amarillo.Visibility = Visibility.Hidden;
            Verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            Amarillo.Visibility = Visibility.Visible;
            Rojo.Visibility = Visibility.Hidden;
            Verde.Visibility = Visibility.Hidden;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            Verde.Visibility = Visibility.Visible;
            Amarillo.Visibility = Visibility.Hidden;
            Rojo.Visibility = Visibility.Hidden;
        }
    }
}
