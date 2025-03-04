using System;

namespace Checked
{
    class Program
    {
        static string answer;
        static int option;
        static int num;
        static int resultado;
        static void Main(string[] args)
        {
            Console.WriteLine("Métodos checked en excepciones");
            Console.WriteLine("Se imprimirá el resultado del valor maximo de un int + 20. El programa debería caerse y lanzar una excepción pero no ocurre");
            Console.WriteLine("El output es el siguiente:");
            num = int.MaxValue;
            resultado = num + 20;
            Console.WriteLine(resultado);
            Console.WriteLine("Para hacer que el programa lanze la excepción hay varios métodos");
            Console.WriteLine("Ver métodos?");
            answer = Console.ReadLine();
            while (answer != "n") 
            {
                Console.WriteLine("Selecciona el método: " +
                    "\n1: Bloque Checked " +
                    "\n2: Directiva Checked " +
                    "\n3: Directiva Unchecked");
                try { option = int.Parse(Console.ReadLine()); }
                catch(Exception e){ Console.WriteLine("Número de operación inválido");}
                CheckOption();
            }
            Console.WriteLine("Que tengas un buen dia!");
           

            //Para no tener que programar un checked, Visual Studio nos permite configurarlo desde
            //propiedades del proyecto:
            //Propiedades / Compilación / Avanzadas 
            //Se activa la casilla de -Comprobar desbordamiento y subdesbordamiento aritmético-
        
        }

        static void CheckOption() 
        {
            switch (option) 
            {
                case 1:
                    Console.WriteLine("El programa deberia caerse y tirar una excepción pero ésta pasa por alto, por ende, se usa el bloque checked en el código para lanzar esa excepción");
                    checked // Hace que el programa caiga cuando se generan excepciones que pasan por alto
                    {
                        num = int.MaxValue;
                        resultado = num + 20;
                        Console.WriteLine($"El resultado es {resultado}");
                    }
                    break;
                case 2:
                    Console.WriteLine("Se utiliza la directiva checked delante de la línea de código a evaluar para no dejar pasar excepciones");
                    num = int.MaxValue;
                    resultado = checked(num + 20);
                    Console.WriteLine($"El resultado es {resultado}");
                    break;
                case 3:
                    num = int.MaxValue;
                    resultado = unchecked(num + 20);
                    Console.WriteLine($"El resultado es {resultado}");
                    break;
                default:
                    Console.WriteLine("No has elegido un método válido");
                    break;
            }
        }
    }
}
