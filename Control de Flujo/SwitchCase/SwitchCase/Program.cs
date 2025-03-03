using System;

namespace SwitchCase
{
    class Program
    {

        static int numMes;
        static void Main(string[] args)
        {
            Console.WriteLine("Elije el número de mes:");
            numMes = int.Parse(Console.ReadLine());
            CheckMonth();
        }

        static void CheckMonth() 
        {
            switch (numMes)
            {
                case 1:
                    Console.WriteLine("Mes de Enero: 31 días");
                    break;
                case 2:
                    Console.WriteLine("Mes de Febrero: 28 días");
                    break;
                case 3:
                    Console.WriteLine("Mes de Marzo: 31 días");
                    break;
                case 4:
                    Console.WriteLine("Mes de Abril: 30 días");
                    break;
                case 5:
                    Console.WriteLine("Mes de Mayo: 31 días");
                    break;
                case 6:
                    Console.WriteLine("Mes de Junio: 30 días");
                    break;
                case 7:
                    Console.WriteLine("Mes de Julio: 31 días");
                    break;
                case 8:
                    Console.WriteLine("Mes de Agosto: 31 días");
                    break;
                case 9:
                    Console.WriteLine("Mes de Septiembre: 30 días");
                    break;
                case 10:
                    Console.WriteLine("Mes de Octubre: 31 días");
                    break;
                case 11:
                    Console.WriteLine("Mes de Noviembre: 30 días");
                    break;
                case 12:
                    Console.WriteLine("Mes de Diciembre: 31 días");
                    break;
                default:
                    break;
            }
               
        }
    }
}