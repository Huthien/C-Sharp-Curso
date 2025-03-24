using System;
using System.Collections.Generic;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de una list (colección de tipo List):
            List<int> list = new List<int>();
            List<int> userList = new List<int>();

            //Se añaden elementos a la lista usando el método Add de las colecciones:
            list.Add(56);
            list.Add(35);
            list.Add(97);

            int[] numeros = new int[5] { 23, 64, 28, 30, 16 };

            //Se pueden agregar elementos de un array en una list:
            for (int i = 0; i < numeros.Length; i++) list.Add(numeros[i]);

            //Se recorren los elementos de la lista a través de un bucle for y se imprimen en pantalla:
            Console.WriteLine("Primer Lista: ");
            for (int i = 0; i < list.Count; i++) Console.WriteLine(list[i]);

            Console.WriteLine("\nLista definida por el usuario: ");
            //Se le pide al usuario la cantidad de elementos que va a tener la lista:
            Console.WriteLine("Introduce la cantidad de valores que quieres almacenar: ");
            int cant = int.Parse(Console.ReadLine());

            //Las list permiten añadir elementos en tiempo de ejecución a diferencia de los array
            //Se le pide al usuario que ingrese los elementos:
            Console.WriteLine("Ingrese los elementos: ");
            for (int i = 0; i < cant; i++) userList.Add(int.Parse(Console.ReadLine()));

            //Se imprimen los valores almacenados en la lista definida por el usuario:
            Console.WriteLine("Los valores de su lista son: ");
            for (int i = 0; i < userList.Count; i++) Console.WriteLine(userList[i]);

            //Se recomienda usar bucles foreach para recorrer los elementos de la lista:
            Console.WriteLine("\nElementos de la lista impresos desde un bucle foreach: ");
            foreach (int i in list) Console.WriteLine(i);

            //Se elimina el ultimo número almacenado:
            list.RemoveAt(list.Count - 1); //Se le resta uno porque el index siempre empieza en 0
            Console.WriteLine("\nLista list sin el último valor: ");
            foreach (int i in list) Console.WriteLine(i);           
        }
    }
}
