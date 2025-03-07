using System;

namespace POO
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara e inicia una variable objeto de tipo Circulo con la palabra reservada new:

            Circulo circulo = new Circulo(); 
            Console.WriteLine("Área de un círculo!");
            Console.WriteLine("Introduce el radio de tu círculo: ");
            double userInput = double.Parse(Console.ReadLine());

            //Se llama al método AreaCircular de la clase Circulo desde la clase Programa con cw:
            Console.WriteLine(circulo.AreaCircular(userInput));
        }
    }

    class Circulo 
    {
        
        private const double pi = 3.1416; 

        //El modificador de acceso public nos permite acceder al método desde fuera de la clase:
        public double AreaCircular(double radio)
        {
            return Math.Pow(radio, 2) * pi; 
            //En el curso se utilizo pi * radio * radio, pero yo decidí usar el método Math.Pow
            //para calcular el radio al cuadrado y luego multiplicarlo por la variable pi
        }   
    }
}
