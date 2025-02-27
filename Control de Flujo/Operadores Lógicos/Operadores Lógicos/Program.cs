using System;

namespace Operadores_Lógicos
{
    class Program
    {
        static double primerTri;
        static double segundoTri;
        static double tercerTri;
        static void Main(string[] args)
        {
            //Se piden los valores de las notas 
            Console.WriteLine("A continuación se le pedirá que introduzca las valores obtenidos en los trimestres del presente año");
            Console.WriteLine("Nota registrada del primer trimestre: ");
            primerTri = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota registrada del segundo trimestre: ");
            segundoTri = double.Parse(Console.ReadLine());
            Console.WriteLine("Nota registrada del tercer trimestre: ");
            tercerTri = double.Parse(Console.ReadLine());

            if (primerTri < 1 || primerTri > 10 || segundoTri < 1 || segundoTri > 10 || tercerTri < 1 || tercerTri > 10)
            {
                Console.WriteLine("ERROR - Has introducido un número inválido");
            }
            else CheckNotes();
        }

        //Se hace una revisión de que la suma de las tres notas de como resultado 21 o más en promedio
        static void CheckNotes() 
        {
            double resultado = (primerTri + segundoTri + tercerTri) / 3;
            if (resultado >= 7 ) 
            {
                Console.WriteLine("Felicitaciones! Has aprobado la materia!");
                Console.WriteLine($"La nota de promedio es de: {resultado}");
            }
            else Console.WriteLine("Lo siento, deberás recursar la materia...");
        }
    }
}
