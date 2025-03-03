using System;

namespace Operadores_Lógicos
{
    class Program
    {
        static double primerTri;
        static double segundoTri;
        static double tercerTri;
        static int faltas;
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
            Console.WriteLine("Posees faltas? De ser asi introduce la cantidad de faltas: ");
            faltas = int.Parse(Console.ReadLine());

            if (primerTri < 1 || primerTri > 10 || segundoTri < 1 || segundoTri > 10 || tercerTri < 1 || tercerTri > 10)
            {
                Console.WriteLine("Has introducido una nota inválida --- Las notas no pueden ser menor a 1");
            }
            else CheckNotes();
        }

        //Se hace una revisión de que la suma de las tres notas de como resultado 21 o más en promedio
        static void CheckNotes() 
        {
            double resultado = (primerTri + segundoTri + tercerTri) / 3;
            if (resultado >= 7 && faltas < 10)
            {
                Console.WriteLine("Felicitaciones! Has aprobado la materia!");
                Console.WriteLine($"La nota de promedio es de: {resultado}");
            }
            else if (resultado >= 7 && faltas >= 10)
            {
                Console.WriteLine("Debido a las faltas deberás cursar 3 días de presencial y rendir un exámen educativo que se deberá aprobar con un nota mayor a 7 para validar el promedio de alumno regular");
            }
            else Console.WriteLine("Lo siento, deberás recursar la materia...");
        }
    }
}
