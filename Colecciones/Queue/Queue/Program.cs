using System;
using System.Collections.Generic;

namespace Queue_and_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara una colección de tipo Queue:
            Queue<string> nombres = new Queue<string>();

            //Se agregan elementos usando el método Enqueue() :
            foreach (string s in new string[] { "Marta", "Gerardo", "Hugo"}) nombres.Enqueue(s);
            Console.WriteLine("Nombres: ");
            foreach (string s in nombres) Console.WriteLine(s);

            //Se eliminan elementos usando el método Dequeue() :
            nombres.Dequeue(); //Elimina el primer elemento en entrar, por ende es el primer en ser eliminado
            Console.WriteLine("\nNombres: ");
            foreach (string s in nombres) Console.WriteLine(s);

            //Se declara una colección de tipo Stack:
            Stack<int> numeros = new Stack<int>();

            //Se agregan elementos usando el método Push() :
            foreach (int num in new int[] {12,23,34,45}) numeros.Push(num);
            Console.WriteLine("\nNúmeros:");
            foreach (int num in numeros) Console.WriteLine(num);

            //Se eliminan elementos usando el método Pop() :
            numeros.Pop(); //Elimina el último elemento en entrar, por ende es el primero en ser eliminado
            Console.WriteLine("\nNúmeros:");
            foreach (int num in numeros) Console.WriteLine(num);
        }
    }
}
