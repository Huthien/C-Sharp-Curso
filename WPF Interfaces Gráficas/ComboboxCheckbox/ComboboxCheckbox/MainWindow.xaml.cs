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

namespace ComboboxCheckbox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Personas> lista = new List<Personas>();
            lista.Add(new Personas() { Nombre = "Marta"});
            lista.Add(new Personas() { Nombre = "Hernán"});
            lista.Add(new Personas() { Nombre = "Eugenio"});
            lista.Add(new Personas() { Nombre = "Julia" });
            lista.Add(new Personas() { Nombre = "Carlos" });

            miCombo.ItemsSource = lista;
        }

        private void Todos_Checked(object sender, RoutedEventArgs e)
        {
            Persona1.IsChecked = true;
            Persona2.IsChecked = true;
            Persona3.IsChecked = true;
            Persona4.IsChecked = true;
            Persona5.IsChecked = true;
        }

        private void Todos_Unchecked(object sender, RoutedEventArgs e)
        {
            Persona1.IsChecked = false;
            Persona2.IsChecked = false;
            Persona3.IsChecked = false;
            Persona4.IsChecked = false;
            Persona5.IsChecked = false;
        }

        private void Individual_Check(object sender, RoutedEventArgs e) 
        {
            if (Persona1.IsChecked == true && Persona2.IsChecked == true && Persona3.IsChecked ==
                true && Persona4.IsChecked == true && Persona5.IsChecked == true)
            {
                Todos.IsChecked = true;
            }
            else Todos.IsChecked = null; //Estado del cuadradito cuando no todas las opciones estén seleccionadas
        }

        private void Individual_Uncheck(object sender, RoutedEventArgs e)
        {
            if (Persona1.IsChecked == false && Persona2.IsChecked == false && Persona3.IsChecked ==
                false && Persona4.IsChecked == false && Persona5.IsChecked == false)
            {
                Todos.IsChecked = false;
            }
            else Todos.IsChecked = null;
        }
    }

    public class Personas 
    { 
        public string Nombre { get; set; }
    }
}
