using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;

namespace ConexiónGestiónPedidos
{
    /// <summary>
    /// Interaction logic for Modifica.xaml
    /// </summary>
    public partial class Modifica : Window
    {
        public Modifica(int elId)
        {
            InitializeComponent();
            z = elId;

            string miConexion = ConfigurationManager.ConnectionStrings["ConexiónGestiónPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;
            miConexionSQL = new SqlConnection(miConexion);
        }

        SqlConnection miConexionSQL;
        private int z;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "UPDATE Cliente SET nombre=@nombre WHERE Id=" + z;
            SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSQL);

            miConexionSQL.Open();

            sqlCommand.Parameters.AddWithValue("@nombre", modificaNombre.Text);
            sqlCommand.ExecuteNonQuery();

            miConexionSQL.Close();
            this.Close();
        }
    }
}
