using System;
using System.Collections.Generic;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaración de una linkedList:
            LinkedList<int> list = new LinkedList<int>();

            Console.WriteLine("Uso de AddFirst():");
            //Por cada número en el array se lo agrega primero, por ende se verán de abajo hacia arriba en forma de stack:
            foreach (int num in new int[] {10,22,35}) list.AddFirst(num);
            foreach (int num in list) Console.WriteLine(num);

            Console.WriteLine("\nUso de AddLast(): ");
            //Por cada número en el array, los agrega de arriba hacia abajo en la lista:
            foreach(int num in new int[] {24,45}) list.AddLast(num);
            foreach (int num in list) Console.WriteLine(num);

            Console.WriteLine("\nLinkedListNode:");
            //Se crea una linkedListNode y se le dice que es igual al primer valor de la lista list
            //mientras que nodo sea diferente de null, nodo cambia de posición.
            //Ésto es igual a un bucle for normal pero usando los nodos de la LinkedListNode:
            for (LinkedListNode<int> nodo = list.First; nodo != null; nodo = nodo.Next)
            { 
                int numero = nodo.Value;
                Console.WriteLine(numero);
            }

            //Se pueden eliminar elementos con una LinkedListNode:
            Console.WriteLine("\nEliminando con LinkedListNode:");
            LinkedListNode<int> miNodo = new LinkedListNode<int>(12);
            //Se agrega un valor:
            list.AddFirst(miNodo);
            //Se elimina un valor:
            list.RemoveLast();
            foreach (int num in list) Console.WriteLine(num);
        }
    }
}
