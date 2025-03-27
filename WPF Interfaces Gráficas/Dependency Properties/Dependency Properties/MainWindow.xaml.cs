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

namespace Dependency_Properties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Se crea una dependency property con el nombre que queramos:
        public int Nueva
        {
            //Se definen el get y el set de la propiedad
            get { return (int)GetValue(NuevaProperty); } //Se devuelve un valor casteado a int de la property registrada
            set { SetValue(NuevaProperty, value); } //Se establece la property creada con su valor
        }

        //Se registra la property con su dependency property pasando los parámetros requeridos:
        // -> Nombre de la property declarada, tipo de dato que maneja, clase en la que se declaró y metadata:
        public static readonly DependencyProperty NuevaProperty = 
            DependencyProperty.Register("Nueva",typeof(int),typeof(MainWindow), new PropertyMetadata(0));
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
