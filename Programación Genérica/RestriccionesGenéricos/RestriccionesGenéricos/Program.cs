using System;
using System.Runtime.Remoting.Messaging;

namespace RestriccionesGenéricos
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleados<Director> director = new Empleados<Director>(2);
            director.Agregar(new Director(3500));
            director.Agregar(new Director(4000));

            Empleados<Secretario> secretarios = new Empleados<Secretario>(4);
            secretarios.Agregar(new Secretario(2500));
            secretarios.Agregar(new Secretario(2400));
            secretarios.Agregar(new Secretario(2680));
            secretarios.Agregar(new Secretario(2350));


            //Al almacenar estudiantes da error porque la clase no implementa la interfaz requerida por la clase genérica:
            //Empleados<Estudiante> estudiante = new Empleados<Estudiante>();
        }
    }

    interface IParaEmpleados 
    {
        double getSalario();
    }

    //Se crea una clase genérica con restricciones. Solo implementa objetos OBLIGADOS a tener salario (interfaz)
    //Se usa la palabra where para indicar que filtre aquellas clases que usen la interfaz indicada
    class Empleados<T> where T :IParaEmpleados
    {
        private int i = 0;
        private T[] empleados;

        //Se crea el constructor y se pasa un parámetro int para el index del array
        public Empleados(int z) => empleados = new T[z];

        //Método para agregar objetos al array:
        public void Agregar(T obj) 
        { 
            empleados[i] = obj;
            i++;
        }

        public T getEmpleado(int i) => empleados[i]; 
    }
    class Director : IParaEmpleados
    {
        private double salario;
        public Director(double salario) => this.salario = salario;
        public double getSalario() => salario;
    }

    class Secretario :IParaEmpleados
    {
        private double salario;
        public Secretario(double salario) => this.salario = salario;
        public double getSalario() => salario;
    }

    class Estudiante //Esta clase no hereda de la interfaz porque un estudiante no tiene salario.
    {
        public Estudiante() { }
    }
}
