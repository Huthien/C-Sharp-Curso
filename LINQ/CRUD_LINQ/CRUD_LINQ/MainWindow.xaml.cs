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
using CRUD_LINQ.GestionPedidosDataSetTableAdapters;

namespace CRUD_LINQ
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            miConexiónSQl = ConfigurationManager.ConnectionStrings["CRUD_LINQ.Properties.Settings.CrudLinqSql"].ConnectionString;
            dataContext = new DataClasses1DataContext(miConexiónSQl);
            //InsertaEmpresas();
            //InsertaEmpleados();
            //InsertaCargos();
            //InsertaEmpleadoCargo();
            //ActualizaEmpleado();
            EliminaEmpleado();
        }

        string miConexiónSQl;
        //Se crea el DataContext con el mapeo de los datos a utilizar:
        DataClasses1DataContext dataContext;

        public void InsertaEmpresas() 
        {
            //Borra los datos de la tabla antes de la ejecución del código del método
            //para evitar que se creen copias de empresas que ya han sido insertadas en 
            //la base de datos:
            dataContext.ExecuteCommand("delete from Empresa");

            //Se crea una instancia de Empresa:
            Empresa emp1 = new Empresa();
            emp1.nombre = "PíldorasInformáticas";
            //Se inserta el objeto en la tabla Empresa (Se inserta el registro):
            dataContext.Empresas.InsertOnSubmit(emp1);

            Empresa emp2 = new Empresa();
            emp2.nombre = "Google";
            dataContext.Empresas.InsertOnSubmit(emp2);

            dataContext.SubmitChanges();//Se suben los cambios al DataContext
            Principal.ItemsSource = dataContext.Empresas;
        }

        public void InsertaEmpleados() 
        { 
            //Uso de Lambda en vez de la sintaxis de instrucción sql
            Empresa emp1 = dataContext.Empresas.First(em => em.nombre.Equals("PíldorasInformáticas"));
            Empresa emp2 = dataContext.Empresas.First(em => em.nombre.Equals("Google"));

            List<Empleado> listaEmpleados = new List<Empleado>();
            listaEmpleados.Add(new Empleado { nombre = "Marta", apellido = "Suarez", empresaId = emp1.Id });
            listaEmpleados.Add(new Empleado { nombre = "Jorge", apellido = "Hernández", empresaId = emp1.Id });
            listaEmpleados.Add(new Empleado { nombre = "Julio", apellido = "Torres", empresaId = emp2.Id });
            listaEmpleados.Add(new Empleado { nombre = "Gabriela", apellido = "Lemos", empresaId = emp2.Id });

            dataContext.Empleados.InsertAllOnSubmit(listaEmpleados);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleados;
        }

        public void InsertaCargos() 
        { 
            dataContext.Cargos.InsertOnSubmit(new Cargo { nombreCargo= "Director/a" });
            dataContext.Cargos.InsertOnSubmit(new Cargo { nombreCargo = "Administrativo/a" });
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Cargos;
        }

        public void InsertaEmpleadoCargo() 
        {
            dataContext.ExecuteCommand("delete from CargoEmpleado");
            //Almacenamiento de cargos en una lista a partir del Id
            //para adherir a la tabla desde el dataContext:
            List<CargoEmpleado> carEmp = new List<CargoEmpleado>();

            carEmp.Add(new CargoEmpleado { empleadoId = 1, cargoId = 1 });
            carEmp.Add(new CargoEmpleado { empleadoId = 2, cargoId = 2 });

            //Otra forma de almacenar cargo-empleados es buscando al empleado por nombre y se
            //agrega el cargo:
            carEmp.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em => 
            em.nombre.Equals("Julio")), Cargo = dataContext.Cargos.First(ce => ce.Id.Equals(1)) });

            carEmp.Add(new CargoEmpleado { Empleado = dataContext.Empleados.First(em =>
            em.nombre.Equals("Gabriela")), Cargo = dataContext.Cargos.First(ce => ce.Id.Equals(2)) });
            

            //Se puede almacenar de la misma manera obejtos de tipo empleado y pasándole el id
            //o nombre de cargo desde la instancia

            dataContext.CargoEmpleados.InsertAllOnSubmit(carEmp);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.CargoEmpleados;
        }

        public void ActualizaEmpleado() 
        { 
            Empleado emp = dataContext.Empleados.First(em => em.nombre.Equals("Gabriela"));
            emp.nombre = "Gabriela Ludmila";

            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleados;
        }

        public void EliminaEmpleado() 
        { 
            Empleado emp = dataContext.Empleados.First(em => em.nombre.Equals("Julio"));
            dataContext.Empleados.DeleteOnSubmit(emp);
            dataContext.SubmitChanges();
            Principal.ItemsSource = dataContext.Empleados;
        }
    }
}
