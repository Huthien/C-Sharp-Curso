using System;
using System.IO.Pipes;

namespace CondicionalIF
{
    class Program
    {
        static int input;
        static string answer;
        static bool carnet = false;
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce tu edad: ");
            input = int.Parse(Console.ReadLine());
            CheckAge();
        }

        static void CheckAge() 
        { 
            if (input < 18)
            {
                Console.WriteLine("Acceso denegado -- SOLO MAYORES DE 18");
            }
            else if (input >= 18) 
            { 
                Console.WriteLine("Acceso concedido!");
                Console.WriteLine("Deseas ver tus beneficios?: ");
                UserAnswer();
                if (answer == "y")
                {
                    CheckBenefits();
                }
                else if (answer == "n") 
                {
                    Console.WriteLine("Que tengas un buen día!");
                }
            }
        }

        static void CheckBenefits() 
        {
            if (!carnet)
            {
                Console.WriteLine("CARNET NO REGISTRADO. Se necesita registro de carnet para autorizar el uso del vehículo");
                Console.WriteLine("Desea iniciar el trámite de carnet?: ");
                UserAnswer();
                if (answer == "y")
                {
                    Console.WriteLine("Se inició el trámite. Se le enviará un email dentro de las siguientes 72 horas para confirmar y realizar el formulario.");
                    Console.WriteLine("Gracias por utilizar nuestros servicios! Que tenga un buen dia!");
                }
                else if (answer == "n") 
                {
                    Console.WriteLine("Gracias por utilizar nuestros servicios! Que tenga un buen día!");
                }
            }
            else { Console.WriteLine("CARNET REGISTRADO. Su vehículo se encuentra autorizado y habilitado para su uso."); }
        }

        static void UserAnswer() 
        {
            answer = Console.ReadLine();
        }
    }
}
