using System;

namespace Throw
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero de mes:");
            int num = int.Parse(Console.ReadLine());
            //Se hace un try catch para manejar la excepcion lanzada en el default del switch
            try { Console.WriteLine(NombreMes(num)); }
            catch (Exception e){ Console.WriteLine($"Mensaje de la excepción: {e.Message}"); }
            //En el catch se captura la excepción y se imprime el mensaje de la misma
            Console.WriteLine("Aqui continúa el programa");
        }

        public static string NombreMes(int mes)
        {
            switch (mes) 
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";
                default:
                    throw new ArgumentOutOfRangeException();
                    //Se le dice que lance un objeto de tipo excepción a través del
                    //constructor de la clase y el programa se cae
            }
        }
    }

  
}
