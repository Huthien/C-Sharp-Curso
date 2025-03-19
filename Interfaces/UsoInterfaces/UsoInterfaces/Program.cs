using System;

namespace UsoInterfaces
{
    //Ejemplo del uso de interfaces en una aplicación sencilla
    class Program
    {
        static void Main(string[] args)
        {
            //Creación de dos objetos de tipo AvisosTrafico:
            Console.WriteLine("Aviso Genérico:");
            AvisosTrafico av1 = new AvisosTrafico();
            av1.MostrarAviso();

            Console.WriteLine("\nAviso Personalizado:");
            AvisosTrafico av2 = new AvisosTrafico("Jefatura Provincial de Transporte", "Sanción de velocidad: $300", "19-3-2025");
            av2.MostrarAviso();

            Console.WriteLine("\nFecha Actual:");
            Console.WriteLine(av2.getFecha()); //Muestra la fecha

        }
    }
}
