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

namespace ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Se declara la lista y se añaden los elementos con las propiedades correspondientes:
            List<Poblaciones> listaPob = new List<Poblaciones>();
            listaPob.Add(new Poblaciones() { Pais1 = "Madrid", Pais2 = "Barcelona", Temperatura1 = 12, Temperatura2 = 17 });
            listaPob.Add(new Poblaciones() { Pais1 = "Valencia", Pais2 = "Alicante", Temperatura1 = 19, Temperatura2 = 20 });
            listaPob.Add(new Poblaciones() { Pais1 = "Málaga", Pais2 = "Bilbao", Temperatura1 = 20, Temperatura2 = 7 });
            listaPob.Add(new Poblaciones() { Pais1 = "Sevilla", Pais2 = "Coruña", Temperatura1 = 22, Temperatura2 = 8 });

            //Se le indica de donde vienen los elementos a la lista del listbox 
            Lista.ItemsSource = listaPob;
        }

        //Evento del botón:
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Lista.SelectedItem != null) //Se evalúa que el elemento no sea null
            {
                //Se crea una ventana emergente con la información de los elementos seleccionados:
                MessageBox.Show((Lista.SelectedItem as Poblaciones).Pais1 + " " +
                (Lista.SelectedItem as Poblaciones).Temperatura1 + "°C " +
                (Lista.SelectedItem as Poblaciones).Pais2 + " " +
                (Lista.SelectedItem as Poblaciones).Temperatura2 + "°C ");
            }
            else MessageBox.Show("Selecciona un elemento!!");
        }

        private void TextBlock_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Button_Click(sender, e);
        }
    }

    //Se define la clase
    public class Poblaciones 
    {
        //Se definen las properties de la clase con sus get y set:
        public string Pais1 { get; set; }

        public int Temperatura1 { get; set; }

        public string Pais2 { get; set; }

        public int Temperatura2 { get; set; }

        public int TemperaturaDiff
        {
            get 
            { 
                int tempDiff = Temperatura1 - Temperatura2;
                return Math.Abs(tempDiff); //Math.Abs() devuelve el valor absoluto de un numero, es decir, el numero sin signo
            }
            set { }
        }

    }
}
