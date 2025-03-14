using System;

namespace Arrays
{
     class Program
    {
        static void Main(string[] args)
        {
            //---ARRAY----
            //Declaración del array e iniciación con la cantidad de valores que tendrá en su interior:
            int[] Numeros = new int[5];

            //Almacenamiento de valores en las posiciones del array (index):
            Numeros[0] = 15;
            Numeros[1] = 12;
            Numeros[2] = 47;
            Numeros[3] = 75;
            Numeros[4] = 69;

            //Si ya se sabe que valores se almacenan en el array, se puede declarar, inicializar y
            //rellenar en la misma linea de código:
            String[] Letras = new String[4] { "a", "b", "c", "d" };

            //También se puede hacer un array que almacene una cantidad indefinida de valores:
            int[] Numeros2 = new int[] {1,4,78,45,30 };
            //Se puede dejar vacío para que el usuario introduzca los valores por consola o bien se 
            //pueden definir e ir agregando sin problema en el array manualmente.

            //--------------------------------------------------------------------------------------

            //---ARRAY IMPLÍCITO---:
            var datos = new[] { "Juan", "Maria", "Fabricio" }; //El tipo de dato depende de los valores almacenados
            var nums = new[] { 2, 16, 56, 4.5, 7.9 };//Se le atribuye un tipo double por los valores en su interior

            //---ARRAY DE OBEJTOS---:
            Personas[] persona = new Personas[2]; //Se declara el array

            persona[0] = new Personas("Martina", 35); //Se almacena una instancia del objeto en el array

            //Otra manera de almacenar una instancia:
            Personas Julio = new Personas("Julio", 54); //Se instancia el objeto y se pasan los parámetros
            persona[1] = Julio; //Luego se almacena la instancia en el array

            //---ARRAY ANÓNIMO---:
            var per = new[]
            {
                //No se indica tipo y se inicia creando las instancias y pasando los valores en las variables de campo
                new{Nombre = "Karen", Edad = 14 },
                new{Nombre = "Gabe", Edad = 36 },
                new{Nombre = "Noemi", Edad = 40 }

                //Los campos deben iguales en todos los objetos creados.
            };


        }
    }

    class Personas
    {
        String nombre;
        int edad;
        public Personas(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
    }
}
