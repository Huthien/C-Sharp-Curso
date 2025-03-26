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

namespace PrimeraInterfaz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window //Clase ventana principal que hereda de la clase ventana (Window)
    {
        public MainWindow()
        {
            InitializeComponent();
            Grid grid = new Grid(); //Instancia de un objeto de tipo Grid
            this.Content = grid; //Le decimos que el contenido va a estar dentro del grid

            Button button = new Button(); //Instancia del botón  
            WrapPanel wrap = new WrapPanel(); //Instancia del Wrap Panel

            //Se instancian los textos que estarán en el Wrap Panel y se define el texto en cada uno
            TextBlock txt1 = new TextBlock();
            TextBlock txt2 = new TextBlock();
            TextBlock txt3 = new TextBlock();
            txt1.Text = "Click";
            txt2.Text = "Me";
            txt3.Text = "Please";

            //Con la propiedad Foreground cambiamos el color del texto 
            txt1.Foreground = Brushes.Coral; //La propiedad brushes se usa para cambiar el color
            txt2.Foreground = Brushes.Red;
            txt3.Foreground = Brushes.IndianRed;
            //Se agregan los textos al Wrap Panel:
            wrap.Children.Add(txt1);
            wrap.Children.Add(txt2);
            wrap.Children.Add(txt3);

            button.Content = wrap; //Se añade el Wrap Panel en el botón

            //Propiedades del botón:
            button.Height = 100;
            button.Width = 200;
            button.HorizontalAlignment = HorizontalAlignment.Center;
            button.VerticalAlignment = VerticalAlignment.Center;
            //Con la propiedad Background cambiamos el color del fondo del botón.
            button.Background = Brushes.Bisque;

            grid.Children.Add(button);//Añadimos al botón creado como hijo del grid.
            
        }
    }
}
