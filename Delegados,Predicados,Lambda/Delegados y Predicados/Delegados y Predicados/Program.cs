using System;
using System.Collections.Generic;

namespace Delegados_y_Predicados
{
    class Program
    {
        //Se declara el delegado:
        delegate void Delegado1(String msj);
        delegate void Delegado2();

        static void Main(string[] args)
        {
            Console.WriteLine("-------Uso de Delegados---------");
            //Se crea un objeto de tipo delegado indicando el método al que apunta:
            Delegado1 deleg = new Delegado1(MensajeBienvenida.SaludoBienvenida);
            Delegado2 deleg2 = new Delegado2(MensajeDespedida.SaludoDespedida);

            //Se llama al delegado:
            Console.WriteLine("Saludo de bienvenida:");
            deleg("Hola, que tal?");

            //Se le dice que apunte al método de la clase con mismo tipo y parámetros:
            Console.WriteLine("\nSaludo de despedida:");
            deleg2();

            Console.WriteLine("\n-------Uso de Delegados Predicados---------");

            //Se declara una lista de numeros enteros:
            List<int> numeros = new List<int>();

            //Se añade a la lista un array de valores:
            numeros.AddRange(new int[] {1,2,3,4,5,6,7,8,9,10});

            //Se declara el predicado y se le indica la función a la que apunta:
            Predicate<int> delega = new Predicate<int>(NumerosPares);

            //Se crea una lista donde se almacenan los numeros pares filtrados por el método FindAll de la lista 
            //numeros indicando el delegado predicado:
            List<int> numPares = numeros.FindAll(delega);
            Console.WriteLine("Lista de Números Pares:");
            foreach(int num in numPares) Console.WriteLine(num);

            //Delegados predicados con objetos:
            Console.WriteLine("-------Uso de Delegados Predicados con Objetos--------");
            //Se crea una lista de objetos:
            List<Persona> gente = new List<Persona>();

            //Se rellena la lista:
            Persona p1 = new Persona();
            p1.Nombre = "Ramiro";
            p1.Edad = 15;
            Persona p2 = new Persona();
            p2.Nombre = "Marta";
            p2.Edad = 26;
            Persona p3 = new Persona();
            p3.Nombre = "Julio";
            p3.Edad = 27;

            gente.AddRange(new Persona[] { p1,p2,p3});

            //Se declara el predicado que va a filtrar los objetos:
            Predicate<Persona> predicado = new Predicate<Persona>(FiltraPersona);

            //Se llama al predicado a través del método Exists() desde la lista y se guarda el resultado en una variable
            //de tipo bool
            bool existe = gente.Exists(predicado);

            //Se checkea si existe el valor que estamos filtrando con el predicado:
            if (existe) Console.WriteLine("Marta existe en la lista");
            else Console.WriteLine("Marta no existe en la lista");

            //Se le dice al predicado que apunte a la otra función:
            predicado = new Predicate<Persona>(FiltraEdad);
            bool edad = gente.Exists(predicado);

            if(edad) Console.WriteLine("Hay un menor de edad en la lista");
            else Console.WriteLine("No hay menores de edad en la lista");
        }

        static bool NumerosPares(int num) 
        { 
            if(num%2 == 0) return true;
            else return false;
        }
        static bool FiltraPersona(Persona persona)
        {
            if (persona.Nombre == "Marta") return true;
            else return false;
        }

        static bool FiltraEdad(Persona persona) 
        {
            if (persona.Edad <= 18) return true;
            else return false;
        }
    }

    class MensajeBienvenida 
    {
        public static void SaludoBienvenida(string msj) => Console.WriteLine("Mensaje: {0}", msj);
    }

    class MensajeDespedida 
    {
        public static void SaludoDespedida() => Console.WriteLine("Adiós!");
    }

    class Persona 
    {
        private string nombre;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}
