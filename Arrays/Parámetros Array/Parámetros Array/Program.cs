using System;

namespace Parámetros_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[4] { 16, 23, 37, 42};
            Console.WriteLine("Array como parámetro usando el método ProcessData:");
            ProcessData(numeros); //Se pasa el array creado como parámetro del método

            Console.WriteLine("\nArray devuelto desde el método ReadData:");
            Console.WriteLine("Crea tu array:\n");
            int[] miArray = ReadData();
            Console.WriteLine("\nTus números de array son: \n");
            foreach (int i in miArray) Console.WriteLine(i);
        }

        static void ProcessData(int[] data) //Se pide un array de parámetro
        {
            Console.WriteLine("Números del array: \n");
            foreach (int i in data) 
            {
                Console.WriteLine(i);
            }; //Se recorre el array pasado como parámetro

            Console.WriteLine("\nNúmeros del array + 10:\n");
            for (int i = 0; i < data.Length; i++) 
            {
                data[i] += 10;
                Console.WriteLine(data[i]);
            }
        }

        static int[] ReadData() //Método que devuelve un array
        {
            Console.WriteLine("Cuántos elementos quieres ingresar?:");
            string answer = Console.ReadLine(); //Se obtiene el input del usuario
            int num = int.Parse(answer);// Se hace un cast a int del input
            int[] datos = new int[num];

            for (int i = 0; i < datos.Length; i++) 
            {
                Console.WriteLine($"Introduzca el dato para el index {i}");
                answer = Console.ReadLine();
                int dato = int.Parse(answer);

                datos[i] = dato;
            }

            return datos;
        }
    }
}
