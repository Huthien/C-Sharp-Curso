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
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader; //Para la conexión con sql

namespace ConexiónGestiónPedidos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Se establece la cadena de conexión con la base de datos
            string miConexion = ConfigurationManager.ConnectionStrings["ConexiónGestiónPedidos.Properties.Settings.GestionPedidosConnectionString"].ConnectionString;

            //Se instancia la conexión pasando como parámetro la conexión creada con la base de datos
            miConexionSQL = new SqlConnection(miConexion);

            MuestraClientes(); //Se llama al método
            MuestraTodosPedidos();
        }

        SqlConnection miConexionSQL; //Se declara la conexión con SQL

        private void MuestraClientes()
        {
            try
            {
                //Se indica que al información viene de una tabla
                string consulta = "SELECT * FROM CLIENTE";

                //Para almacenar información que viene de una tabla se usa una estructura de Data Table
                SqlDataAdapter miAdapterSQL = new SqlDataAdapter(consulta, miConexionSQL);

                //Se usa el adaptador creado con la consulta de la conexion 
                using (miAdapterSQL)
                {
                    //Se crea un data table para almacenar la información de la tabla:
                    DataTable clientesTabla = new DataTable();
                    //Se le dice al adaptador que llene la data table:
                    miAdapterSQL.Fill(clientesTabla);
                    //Se indica de que campo de la tabla se está obteniendo al información:
                    ListaClientes.DisplayMemberPath = "nombre";
                    //Se indica el campo clave:
                    ListaClientes.SelectedValuePath = "Id";
                    //Se especifica el origen de los datos con los que se rellena la lista:
                    ListaClientes.ItemsSource = clientesTabla.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void ListaClientes_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            MuestraPedidos();
        }
        private void MuestraPedidos() 
        {
            try
            {
                //Se hace una consulta paramétrica 
                string consulta = "SELECT * FROM PEDIDO P INNER JOIN CLIENTE C ON C.ID=P.cCliente WHERE C.ID = @ClienteId";

                //Para ejecutar la consulta sql con parámetro:
                SqlCommand sqlComando = new SqlCommand(consulta, miConexionSQL);
                SqlDataAdapter miAdapterSQL = new SqlDataAdapter(sqlComando);

                using (miAdapterSQL)
                {

                    sqlComando.Parameters.AddWithValue("@ClienteId", ListaClientes.SelectedValue);
                    DataTable pedidosTabla = new DataTable();
                    miAdapterSQL.Fill(pedidosTabla);
                    PedidosClientes.DisplayMemberPath = "fechaPedido";
                    PedidosClientes.SelectedValuePath = "Id";
                    PedidosClientes.ItemsSource = pedidosTabla.DefaultView;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void MuestraTodosPedidos()
        {
            try
            {
                //Consulta de campo nuevo calculado:
                string consulta = "SELECT *, CONCAT(cCliente, ' ' , fechaPedido, ' ', formaPago) AS INFOPEDIDOS FROM PEDIDO";
                SqlDataAdapter miAdapterSQL = new SqlDataAdapter(consulta, miConexionSQL);

                using (miAdapterSQL)
                {
                    DataTable todosPedidos = new DataTable();
                    miAdapterSQL.Fill(todosPedidos);
                    TodosPedidos.DisplayMemberPath = "INFOPEDIDOS";
                    TodosPedidos.SelectedValuePath = "Id";
                    TodosPedidos.ItemsSource = todosPedidos.DefaultView;
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Evento del botón borrar que elimina un registro de pedido:
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string consulta = "DELETE FROM PEDIDO WHERE ID=@PEDIDOID";
            SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSQL);

            miConexionSQL.Open();

            sqlCommand.Parameters.AddWithValue("@PEDIDOID", TodosPedidos.SelectedValue);
            sqlCommand.ExecuteNonQuery();

            miConexionSQL.Close();
            MuestraTodosPedidos();
        }

        //Evento del botón Agregar que agrega un cliente nuevo a la lista
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (InsertaCliente.Text != "")
            {
                string consulta = "INSERT INTO CLIENTE(nombre) VALUES (@nombre)";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSQL);

                miConexionSQL.Open();

                sqlCommand.Parameters.AddWithValue("@nombre", InsertaCliente.Text);
                sqlCommand.ExecuteNonQuery();

                miConexionSQL.Close();
                MuestraClientes();
                InsertaCliente.Text = "";
            }
        }

        //Evento del botón eliminar que borra un cliente de la lista
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (ListaClientes.SelectedValue != null)
            {
                string consulta = "DELETE FROM CLIENTE WHERE ID = @CLIENTEID";
                SqlCommand sqlCommand = new SqlCommand(consulta, miConexionSQL);

                miConexionSQL.Open();

                sqlCommand.Parameters.AddWithValue("@CLIENTEID", ListaClientes.SelectedValue);
                sqlCommand.ExecuteNonQuery();

                miConexionSQL.Close();
                MuestraClientes();
            }
        }

        //Evento del botón Modificar que modifica el nombre del cliente
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (ListaClientes.SelectedValue != null)
            {
                Modifica modifica = new Modifica((int)ListaClientes.SelectedValue);
                
                try
                {
                    string consulta = "SELECT nombre FROM CLIENTE WHERE Id=@ClId";
                    SqlCommand command = new SqlCommand(consulta, miConexionSQL);
                    SqlDataAdapter miAdapterSQL = new SqlDataAdapter(command);

                    using (miAdapterSQL)
                    {
                        command.Parameters.AddWithValue("@ClId", ListaClientes.SelectedValue);
                        DataTable dt = new DataTable();
                        miAdapterSQL.Fill(dt);
                        modifica.modificaNombre.Text = dt.Rows[0]["nombre"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                modifica.ShowDialog();
            }
        }

        //Evento que ejecuta la main window cuando vuelve a estar en foco (primer plano)
        private void Window_Activated(object sender, EventArgs e)
        {
            MuestraClientes();
        }
    }
}
