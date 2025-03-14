using System;

namespace BucleFor_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara el array:
            int[] numeros = new int[6] { 1, 2, 3, 4, 5, 6 };

            Console.WriteLine("---Bucle indicando la cantidad de vueltas:---");
            //Se usa el bucle for para recorrer e imprimir en pantalla los valores:
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            //Uso de Length: 
            //Se crean los objetos:
            Personas Maria = new Personas("Maria", 35);
            Personas Juan = new Personas("Juan", 56);
            Personas Amelie = new Personas("Amelie", 28);

            //Se almacenan los objetos en un array:
            Personas[] persona = new Personas[]{Maria, Juan, Amelie};

            Console.WriteLine("\n---Bucle indicando la cantidad desde la longitud del array:---\n");
            //Se le indica al bucle que debe repetirse mientras que i sea menor a la longitud del array usando Length
            for (int i = 0; i < persona.Length; i++) 
            {
                Console.WriteLine(persona[i].getInfo()+"\n");
            }

            Console.WriteLine("---Bucle foreach:---\n");
            //Se usa una variable iterador del mismo tipo que se almacena en el array
            foreach (Personas per in persona) 
            {
                Console.WriteLine(per.getInfo() + "\n");
            }


            Console.WriteLine("---Bucle foreach con array implícito:---\n");

            //Creación de un array implícito:
            var empleados = new[] 
            { 
                new { Nombre = "Hector", Edad = 53},
                new { Nombre = "Gerardo", Edad = 65},
                new { Nombre = "Jessica", Edad = 45}
            };

            //Uso de foreach para recorrer el array implícito:
            foreach (var emp in empleados) //El tipo del objeto es var porque no se sabe de que tipo es el array
            {
                Console.WriteLine(emp);
            }
        }

        class Personas 
        {
            string nombre;
            int edad;
            public Personas(String nombre, int edad) 
            { 
                this.nombre = nombre;
                this.edad = edad;   
            }

            public String getInfo() 
            {
                return $"Nombre: {nombre} \nEdad: {edad}";
            }
        }
    }
}
