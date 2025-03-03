using System;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejecuta el código aunque sea una vez a pesar de no cumplirse la condición a evaluar en el while
            int num;
            int aleatorio = new Random().Next(1,100);
            int intentos = 0;

            Console.WriteLine("Entre 1 y 100, adivina el número!!!");
            do
            {
                Console.WriteLine("Introduce un número: ");
                num = int.Parse(Console.ReadLine());
                intentos++;
                if(num > aleatorio) Console.WriteLine("El número es menor...");
                if(num < aleatorio) Console.WriteLine("El número es mayor...");
                }
            while (num != aleatorio);
            Console.WriteLine($"Has adivinado! El número era: {num}");
            Console.WriteLine($"Has necesitado {intentos} intentos.");
        }
    }
}
