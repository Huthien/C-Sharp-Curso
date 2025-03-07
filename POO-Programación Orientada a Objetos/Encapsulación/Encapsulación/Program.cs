using System;

namespace Encapsulación
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversorEuroDolar conversor = new ConversorEuroDolar();
            Console.WriteLine("Conversor de Euro a Dolar");
            Console.WriteLine("Ingresa una cantidad: ");
            double userInput = double.Parse(Console.ReadLine());
            Console.WriteLine($"La cantidad ingresada equivale a: {conversor.Convert(userInput)}");

            //En el caso de que el valor del euro cambie, podemos modificarlo a través de un método
            //public desde la clase EuroDolar, pero manteniendo el encapsulamiento de la variable euro
            //en private
        }
    }
 
    class ConversorEuroDolar
    {
        //Se encapsula el dato para que no sea accesible desde fuera de la clase
        //No es necesario colocar el private porque sin él la variable ya está encapsulada, 
        //pero es recomendable utilizarlo en programas complejos para que a simple vista se sepa
        //que la variable está encapsulada.
        private double euro = 1.08;

        public double Convert(double cantidad) 
        { 
            return cantidad * euro;
        }

        public void NuevoValor(double valor) 
        {
            if (valor < 0) euro = 1.08;
            else euro = valor;

            //Se checkea que el usuario no cambie el valor del euro con un valor negativo,
            //porque de ser asi se quedará el valor por defecto
            //ÉSste método se puede llamar desde la clase Program, método Main para modificar el valor
            //del euro
        }
    }
}
