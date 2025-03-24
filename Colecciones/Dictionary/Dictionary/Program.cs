using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se declara un diccionario, y se pide una clave de tipo int, y un valor de tipo string
            Dictionary<string,int> personas = new Dictionary<string,int>();

            //Se agregan elementos con el método Add() :
            personas.Add("Marta", 34);
            personas.Add("Jorge", 56);
            personas.Add("Luciano", 83);
            //Otra manera de agregar un elemento:
            personas["Antonio"] = 76;

            //Se imprime el par de nombre y valor en el diccionario:
            Console.WriteLine("Personas: ");
            foreach (KeyValuePair<string, int> persona in personas) 
            {
                Console.WriteLine("Nombre: {0} | Edad: {1}",persona.Key,persona.Value); 
            }
        }
    }
}
