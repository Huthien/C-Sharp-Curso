using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlEmpresasEmpleados control = new ControlEmpresasEmpleados();
            Console.WriteLine("CEOS:");
            control.getCEO();
            Console.WriteLine("\nTodos los empleados:");
            control.getEmpleadosOrdenados();

            Console.WriteLine("\nSelecciona la empresa: ");
            string input = Console.ReadLine();
            try
            {
                int inputId = Convert.ToInt32(input); //Se trasnforma el tipo de dato del input
                control.EmpleadosId(inputId);
            }
            catch (Exception) { Console.WriteLine("Has introducido un Id inválido!"); }
        }
    }

    class Empresa 
    { 
        public int Id { get; set; }
        public string Nombre { get; set; }

        public void MuestraDatos()
        {
            Console.WriteLine("Empresa {0} con id: {1}", Nombre,Id);
        }
    }

    class Empleado 
    { 
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public double Salario { get; set; }

        //Clave foránea para empleado:
        public int EmpresaId { get; set; }

        public void MuestraDatos()
        {
            Console.WriteLine("Empleado {0} con id: {1}, cargo: {2}, salario: {3}, " +
                "pertenece a la empresa: {4}", Nombre, Id, Cargo, Salario, EmpresaId);
        }
    }

    class ControlEmpresasEmpleados 
    {
        //Se crean las listas donde almacenar los datos
        List<Empresa> listaEmpresas;
        List<Empleado> listaEmpleados;

        public ControlEmpresasEmpleados() 
        { 
            //Se inician las listas en el constructor:
            listaEmpresas = new List<Empresa>();
            listaEmpleados = new List<Empleado>();

            listaEmpresas.Add(new Empresa { Id = 1, Nombre = "Google" });
            listaEmpresas.Add(new Empresa { Id = 2, Nombre = "PildorasInformáticas" });

            listaEmpleados.Add(new Empleado { Id = 1, Nombre = "Julio Cortez", Cargo = "Secretario", EmpresaId = 1, Salario = 15500});
            listaEmpleados.Add(new Empleado { Id = 2, Nombre = "Marta Guerra", Cargo = "Administración de Ventas", EmpresaId = 1, Salario = 14500 });
            listaEmpleados.Add(new Empleado { Id = 3, Nombre = "Héctor Rodriguez", Cargo = "Secretario", EmpresaId = 2, Salario = 13400 });
            listaEmpleados.Add(new Empleado { Id = 4, Nombre = "Monica Hernández", Cargo = "Contador", EmpresaId = 2, Salario = 16000 });
            listaEmpleados.Add(new Empleado { Id = 5, Nombre = "Felipe Torres", Cargo = "CEO", EmpresaId = 1, Salario = 18000 });
            listaEmpleados.Add(new Empleado { Id = 6, Nombre = "Eugenio Vega", Cargo = "CEO", EmpresaId = 2, Salario = 18500 });
        }

        //Se hace un método  para obtener a aquellos empleados que tienen determinada propiedad
        public void getCEO() 
        {
            //Se usa la instruccion con linq
            IEnumerable<Empleado> ceos = from empleado in listaEmpleados where empleado.Cargo == "CEO" select empleado;
            foreach (Empleado empleado in ceos) empleado.MuestraDatos();
        }

        public void getEmpleadosOrdenados() 
        {
            IEnumerable<Empleado> empleados = from empleado in listaEmpleados orderby empleado.Nombre select empleado;
            foreach (Empleado empleado in empleados) empleado.MuestraDatos();
        }

        public void EmpleadosId(int id) 
        { 
            //Se usa join para obtener datos de dos clases enlazadas por una clave foránea
            IEnumerable<Empleado> empleadosPil = from empleado in listaEmpleados join empresa in listaEmpresas
                                              on empleado.EmpresaId equals empresa.Id 
                                              where empresa.Id == id select empleado;
            foreach (Empleado empleado in empleadosPil) empleado.MuestraDatos();
        }
    }
}

