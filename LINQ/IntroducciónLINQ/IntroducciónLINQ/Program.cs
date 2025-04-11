using System;
using System.Collections.Generic;
using System.Linq;

namespace IntroducciónLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //Se utiliza Linq para acceder a las datos del array y filtrar cuales son pares:
            IEnumerable<int> numPares = from num in numeros where num % 2 == 0 select num;
            foreach(int i in numPares) Console.WriteLine(i);
        }
        //En este caso linq permite recorrer un array para filtrar sus valores sin tener que
        //utilizar un bucle foreach
        //Linq permite simplificar el código y hacerlo más legible
        //Linq permite el uso de lambda

    }
}
