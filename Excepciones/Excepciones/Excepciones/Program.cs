using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    class Program
    {
        static int num;
        static string answer;
        static void Main(string[] args)
        {
            Console.WriteLine("Números al cuadrado!");
            while (answer != "n") 
            {
                Console.WriteLine("Introduce un número: ");
                try { num = int.Parse(Console.ReadLine()); }
                //Se puede hacer un catch con una Exepcion Genérica, pero no otorga información suficiente
                //sobre cuál fué el problema
                catch (Exception e) when (e.GetType() != typeof(OverflowException)) 
                { 
                    Console.WriteLine("Número inválido, se tomará como valor default el 0\n");
                    Console.WriteLine("<---"+e.Message+"--->\n");
                }
                catch (OverflowException e) 
                { 
                    Console.WriteLine("El número es demasiado grande!!! Se tomará como valor default el 0\n");
                    Console.WriteLine("<---"+e.Message+"--->\n");
                }

                Console.WriteLine($"{num} elevado al cuadrado es: {Math.Pow(num,2)}");
                Console.WriteLine("Otra vez?");
                answer = (Console.ReadLine());
            }
            Console.WriteLine("Que tengas un buen dia!");
        }
    }
}
