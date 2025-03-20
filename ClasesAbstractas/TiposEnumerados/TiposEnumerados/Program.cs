using System;

namespace TiposEnumerados
{
    //Se declara el enum. Suelen declararse en el namespace:
    enum Bonus { Bajo = 500, Normal = 1000, Bueno = 1500, Extra = 2500 }; //Son constantes sin tipo de dato, no son string!
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea un objeto del tipo del enum creado y se le dice que es igual a una de las constantes del enum:
            Bonus puntos = Bonus.Normal;
            //Para guardar un valor nulo en un objeto de tipo enum se coloca el ? al final del nombre del enum
            //Bonus? puntaje = null; 
            Console.WriteLine($"Bonus de puntos: {puntos}"); //Imprime el tipo de bonus que se recibe

            //Para obtener el valor almacenado en la constante hay que hacer un casting:
            double puntaje = (double)puntos;
            Console.WriteLine($"\nBonus de puntos: {puntaje}");

            //Los valores se pueden incremtentar:
            double nuevoPuntaje = 1500 + puntaje;
            Console.WriteLine($"\nEl nuevo puntaje es: {nuevoPuntaje}");

            //Se crea un objeto Jugador
            Jugador jugador = new Jugador(Bonus.Extra, 1500);
            Console.WriteLine($"\nEl puntaje del jugador es: {jugador.getPuntaje()}");
        }
    }

    class Jugador 
    {
        private double puntaje, bonus;

        public Jugador(Bonus bonus, double puntaje) //Se pide un objeto de tipo enum como parámetro
        {
            this.bonus = (double)bonus; //Se hace un casting 
            this.puntaje = puntaje;
        }

        public double getPuntaje() => puntaje + bonus;
    }
}
