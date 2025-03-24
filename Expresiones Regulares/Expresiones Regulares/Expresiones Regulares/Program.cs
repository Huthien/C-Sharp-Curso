using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Expresiones_Regulares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cadena de caracteres a evaluar:
            string frase = "Hola, mi nombre es Marta, mi número de teléfono es (+34) 5678-9128, (+44) 3874-9645";
            string frase2 = "La web es http://pildorasinformaticas.es";
            //Patrón que vamos a buscar:
            string pattern = "[M]";
            string pattern2 = @"\d{4}-{2}"; //El @ nos permite usar la barra invertida dentro del string (caracter de escape)
            string pattern3 = @"\+34|\+54"; //El | se usa como operador lógico, por lo que se busca numeros de +34 o +54.
            string pattern4 = "https?://(www.)?pildorasinformaticas.es"; //Entre parentesis indicamos que puede estar la triple w o no con el ?

            //Instancia de un regex (regular expresion):
            Regex reg = new Regex(pattern);
            //Se le indica donde se realizara la búsqueda de coincidencias
            MatchCollection match = reg.Matches(frase);

            Console.WriteLine("Búsqueda de un caracter:");
            if (match.Count > 0) Console.WriteLine("Se ha encontrado una M");
            else Console.WriteLine("No se ha encontrado");

            //Se instancia otro regex para checkear un si hay bloques de números
            Regex reg2 = new Regex(pattern2);
            MatchCollection match2 = reg2.Matches(frase);

            Console.WriteLine("\nBúsqueda de número de teléfono por chequeo de bloques:");
            if (match2.Count > 0) Console.WriteLine("Hay número de teléfono");
            else Console.WriteLine("No hay números de teléfono");

            //Se instancia otro regex para checkear prefijos de números telefónicos:
            Regex reg3 = new Regex(pattern3);
            MatchCollection match3 = reg3.Matches(frase);

            Console.WriteLine("\nBúsqueda de número de teléfono +34 o +54:");
            if(match3.Count > 0) Console.WriteLine("Se ha encontrado un número con uno de los prefijos establecidos");
            else Console.WriteLine("No se ha encontrado número con ese prefijo");

            //Se instancia otro regex para búsqueda de una página web:
            Regex reg4 = new Regex(pattern4);
            MatchCollection match4 = reg4.Matches(frase2);

            Console.WriteLine("\nBúsqueda de página web: ");
            if(match4.Count > 0) Console.WriteLine("La página existe");
            else Console.WriteLine("La página no existe");

            //El cuantificador ? Se usa para indicar si una parte de los caracteres pueden estar o no presentes
            //Por eso si la página tiene o no las 3 w o no, existe igual porque forma parte de la condición de búsqueda.
        }
    }
}
