using System;

namespace Métodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SE LLAMA AL MÉTODO QUE CORRESPONDE DEPENDIENDO SUS PARÁMETROS:

            Console.WriteLine("Llamada del método suma con dos parámetros int: ");
            Console.WriteLine($"El resultado de la suma es: {Suma(5, 7)}");
            Console.WriteLine("\nLlamada del método suma con tres parámetros int: ");
            Console.WriteLine($"El resultado de la suma es: {Suma(6, 8, 3)}");
            Console.WriteLine("\nLlamada del método suma con un parámetro double y un parámetro int: ");
            Console.WriteLine($"El resultado de la suma es: {Suma(2.5, 8)}");
        }

        //SOBRECARGA DE MÉTODOS:
        static int Suma(int num1, int num2) => num1 + num2;
        static int Suma(int num1, int num2, int num3) => num1 + num2 + num3;
        static double Suma(double num1, int num2) => num1 + num2;
    }
}
