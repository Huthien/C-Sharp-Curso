using System;

namespace Bucle_While
{
    class Program
    {
        static int rdmNum;
        static int intentos;
        static int points;
        static int total;
        static void Main(string[] args)
        {
            intentos = 5;
            Console.WriteLine("Consigue al menos 400 puntos para ganarme!");
            Console.WriteLine("Tirar el dado?: ");
            string answer = Console.ReadLine();
            while (answer != "n" && intentos > 0)
            {
                rdmNum = new Random().Next(1,7);
                intentos--;
                Console.WriteLine($"Has sacado un: {rdmNum}");
                CheckNumber();
                SumPoints(total);
                if (intentos > 0)
                {
                    Console.WriteLine("Tirar el dado otra vez?");
                    answer = Console.ReadLine();
                }
                else Console.WriteLine("Te has quedado sin intentos");
            }
            Console.WriteLine($"Tienes un puntaje final de: {total} puntos!");
            CheckPoints();
            Console.WriteLine("Que tengas un buen dia!");
        }

        static void CheckNumber() 
        {
            if (rdmNum == 6)
            {
                points = 100;
                Console.WriteLine("YOU WIN 100 POINTS!!!");
            }
            else if (rdmNum > 3 && rdmNum < 6) 
            {
                points = 50;
                Console.WriteLine("YOU WIN 50 POINTS"); 
            }
            else if (rdmNum > 1 && rdmNum <= 3) 
            {
                points = 25;
                Console.WriteLine("YOU WIN 25 POINTS"); 
            }
            else 
            {
                points = 5;
                Console.WriteLine("YOU WIN 5 POINTS"); 
            }
        }

        static int SumPoints(int resultado) 
        {
            total = resultado + points;
            return total;
        }

        static void CheckPoints() 
        {
            if (total < 100) Console.WriteLine("Has perdido!!!!");
            else if (total > 100 && total < 200) Console.WriteLine("Pudo haber sido mejor!");
            else if (total > 200 && total < 400) Console.WriteLine("No está mal!");
            else if (total > 400) Console.WriteLine("ME HAS GANADO!!! Buen trabajo!");
        }
    }
}
