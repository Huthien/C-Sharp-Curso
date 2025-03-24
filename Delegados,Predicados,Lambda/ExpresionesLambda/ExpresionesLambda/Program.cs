using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace ExpresionesLambda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uso del delegado:
            Console.WriteLine("LAMBDA con un parámetro: ");
            Operaciones op = new Operaciones(num => num* num); //Uso de expresión Lambda para prescindir de la función
            Console.WriteLine(op(4));

            //Cuando el delegado debe manejar varios parámetros y queremos usar expresiones lambda se colocan los 
            //parámetros entre paréntesis, la expresión => y la operación a realizar.
            Console.WriteLine("\nLAMBDA con varios parámetros: ");
            Sumando sum = new Sumando((num1,num2) => num1 + num2);
            Console.WriteLine(sum(20,5));

            Console.WriteLine("\nLAMBDA con listas:");
            List<int> numeros = new List<int>{1,2,3,4,5,6,7,8,9};
            List<int> pares = numeros.FindAll(i => i%2 == 0); //Uso de FindAll() para filtrar y se usa lambda

            //Se puede usar lambda en con foreach para recorrer listas: 
            //foreach(int i in pares) Console.WriteLine(i);
            pares.ForEach(i => {
                Console.WriteLine("Números Pares:");
                Console.WriteLine(i);});

            //Además cuando son varias lineas de código a realizar, se abren llaves después de la expresión => y
            //se prosigue a escribir las líneas necesarias

            Console.WriteLine("LAMBDA con Objetos de clase:");

            //Se crean dos objetos de la clase Persona:
            Persona pers1 = new Persona();
            pers1.Nombre = "Marta";
            pers1.Edad = 34;

            Persona pers2 = new Persona();
            pers2.Nombre = "Eugenia";
            pers2.Edad = 34;

            //Se comparan la edad de dos personas diferentes
            Console.WriteLine("\nTienen la misma edad?");
            ComparaEdad compEdad = (p1, p2) => p1 == p2; //Lambda en el uso del delegado
            Console.WriteLine(compEdad(pers1.Edad,pers2.Edad));

            //Se comparan los nombres de dos personas diferentes
            Console.WriteLine("\nTienen el mismo nombre?");
            ComparaNombre compNombre = (p1, p2) => (p1 == p2);
            Console.WriteLine(compNombre(pers1.Nombre,pers2.Nombre));
        }

        //Al usar lambda desde la creación del objeto delegado se prescinde del método y se simplifica el código:
        //public static int Cuadrado(int num)=> num * num; 

        public delegate int Operaciones(int numero);
        public delegate int Sumando(int num1, int num2);

        public delegate bool ComparaEdad(int num1, int num2);
        public delegate bool ComparaNombre(string nom1, string nom2);
    }

    class Persona  
    {
        private int edad;
        private string nombre;

        public int Edad { get => edad; set => edad = value; }
        public string Nombre { get => nombre; set => nombre = value; }
    }
}
