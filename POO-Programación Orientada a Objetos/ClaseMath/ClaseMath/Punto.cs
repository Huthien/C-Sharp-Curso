using System;

namespace ClaseMath
{
    partial class Punto //Constructores
    {
        private int x, y;
        private static int contador = 0; //Variable estática modificable a través de la clase
        public Punto() 
        { 
            this.x = 0;
            this.y = 0;
            contador++;
        }
        public Punto(int x, int y) 
        {
            this.x = x;
            this.y = y;
            contador++;
        }
    }

    partial class Punto //Métodos
    {
        public double CalculaDistancia(Punto point)
        {
            int xDiff = this.x - point.x;
            int yDiff = this.y - point.y;

            //Se aplica teorema de pitágoras con el uso de la clase Math:
            double distancia = Math.Sqrt(Math.Pow(xDiff, 2) + Math.Pow(yDiff, 2));
            return distancia;
        }

        //Método static que accede a la variable estática de campo contador para modificar su valor:
        public static int Cont() => contador;
    }
}
