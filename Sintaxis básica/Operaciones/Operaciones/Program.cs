using System;

namespace Operaciones
{
    class Program
    {

        static int num1;
        static int num2;
        static void Main(string[] args)
        {
            //SUMA DE DOS NÚMERO ENTEROS CON LLAMADO A MÉTODO
            Console.WriteLine("SUMA DE DOS NÚMEROS:");
            Console.WriteLine("Inserte un número: ");
            num1 = userInput();
            Console.WriteLine("Inserte otro número: ");
            num2 = userInput();
            Console.WriteLine($"La suma de los números es: {Suma(num1, num2)}");

            //RESTA DE DOS NÚMEROS ENTEROS CON LLAMADA A MÉTODO
            Console.WriteLine("\nRESTA DE DOS NÚMEROS:");
            Console.WriteLine("Inserte un número: ");
            num1 = userInput();
            Console.WriteLine("Inserte otro número: ");
            num2 = userInput();
            Console.WriteLine($"La resta de los números es: {Resta(num1, num2)}");

            //MULTIPLICACIÓN DE DOS NÚMEROS ENTEROS CON LLAMADA A MÉTODO
            Console.WriteLine("\nMULTIPLICACIÓN DE DOS NÚMEROS:");
            Console.WriteLine("Inserte un número: ");
            num1 = userInput();
            Console.WriteLine("Inserte otro número: ");
            num2 = userInput();
            Console.WriteLine($"La multiplicación de los números es: {Multiplicación(num1, num2)}");

            //DIVISIÓN DE DOS NÚMEROS ENTEROS CON LLAMADA A MÉTODO
            Console.WriteLine("\nDIVISIÓN DE DOS NÚMEROS:");
            Console.WriteLine("Inserte un número: ");
            num1 = userInput();
            Console.WriteLine("Inserte otro número: ");
            num2 = userInput();
            Console.WriteLine($"La división de los números es: {División(num1, num2)}");
        }

        static int Suma(int num1, int num2) => num1 + num2;
        static int Resta(int num1, int num2) => num1 - num2;
        static int Multiplicación(int num1, int num2) => num1 * num2;
        static int División(int num1, int num2) => num1 / num2;

        static int userInput()
        {
            int input = int.Parse(Console.ReadLine());
            return input;
        }
    }
}
