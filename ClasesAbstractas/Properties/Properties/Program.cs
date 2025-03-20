using System;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado("Hernán");

            //Uso del setter de la propertie
            empleado.SALARIO = 1500;
            //Uso del getter de la propertie
            Console.WriteLine($"El salario inicial del empleado es: {empleado.SALARIO}");

            empleado.SALARIO += 500; //Se incrementa el valor y se imprime en pantalla
            Console.WriteLine($"El salario incrementado del empleado es: {empleado.SALARIO}");

            //Si el salario es negativo (menor a 0), entonces a través de la propertie se detecta
            empleado.SALARIO -= 2300;
            Console.WriteLine($"El salario en NEGATIVO del empleado es: {empleado.SALARIO}");
        }
    }

    class Empleado 
    {
        String _nombre;
        double _salario;
        public Empleado(String nombre) => this._nombre = nombre;

        //Se crea el método para evaluar si el salario es menor a 0
        private double evaluaSalario(double salario) 
        {
            if (salario < 0) return 0;
            else return salario;
        }

        //Creación de la propertie:
        public double SALARIO 
        { 
            //Se crea un getter y un setter dentro de la propertie
            get => this._salario; 
            set => this._salario = evaluaSalario(value); 
        }
    }

    //Las properties son útiles en ciertos escenarios pero tienen una sintaxis mas complicada que simplemente
    //encapsular los campos de clase.

    //Colocar un guion bajo en la variable de campo permite distinguirla de otras con el mismo nombre y no figura 
    //en el menú intellisense 

    //Se pueden crear properties de SOLO ESCRITURA (Como las contraseñas) prescindiendo del get en dicha propertie.
    //Lo mismo pasa con properties de SOLO LECTURA, se prescinde del set.
}
