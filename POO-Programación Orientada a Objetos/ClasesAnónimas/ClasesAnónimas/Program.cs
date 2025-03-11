using System;

namespace ClasesAnónimas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Las clases anónimas se declaran con la palabra reservada var
            //Se omite indicar el tipo de variable en las variables de campo de la clase, ya que 
            //el compilador lo atribuye dependiendo el dato que se almacena
            var PersonaPublic = new { Nombre = "Felipe", Edad = 34 };
            var PersonaPriv = new { Nombre = "Gabriela", Edad = 36 };

            //Lo que hace la siguiente línea es sobreescribir las variables de clase porque los
            //datos son del mismo tipo, están en el mismo orden y tienen la misma cantidad de
            //campos. Por lo tanto los valores de la clase PersonaPublic pasan a ser los mismo que PersonaPriv
            PersonaPublic = PersonaPriv; 
            Console.WriteLine($"Persona: \nNombre: {PersonaPublic.Nombre} \nEdad: {PersonaPublic.Edad}");
        }
    }
}
