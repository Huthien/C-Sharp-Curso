using System;

namespace ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Distancia();
        }

        static void Distancia() 
        {
            //Se crean dos objetos de tipo Punto cuya clase está declarada en el archivo Punto.cs
            Punto origen = new Punto();
            Punto destino = new Punto(128, 80);
            //Se obtiene la distancia entre la posición del punto origen y la posición del 
            //punto destino:
            double distancia = origen.CalculaDistancia(destino);
            Console.WriteLine($"La distancia entre los puntos es de: {distancia}");
            Console.WriteLine($"Número de puntos: {Punto.Cont()}");
        }
    }
}
