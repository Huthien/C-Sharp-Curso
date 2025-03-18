using System;
using System.Runtime.InteropServices;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Batería inst1 = new Batería("Batería");
            Violín inst2 = new Violín("Violin");
            Flauta inst3 = new Flauta("Flauta");

            Console.WriteLine("\nInstrumento: ");
            inst1.getNombre();
            inst1.getTipo();
            inst1.Sonido();
            inst1.Golpear();
            Console.WriteLine($"Número de elementos: {inst1.NumElementos()}");

            Console.WriteLine("\nInstrumento: ");
            inst2.getNombre();
            inst2.getTipo();
            inst2.Sonido();
            inst2.Vibrar();
            Console.WriteLine($"Número de cuerdas: {inst2.NumCuerdas()}");  
            Console.WriteLine($"Número de elementos: {inst2.NumElementos()}");

            Console.WriteLine("\nInstrumento: ");
            inst3.getNombre();
            inst3.getTipo();
            inst3.Sonido();
            inst3.Soplar();
        }
    }

    interface IElementos //Se declara una interfaz para que las subclases que tienen varios elementos la hereden
    {
        int NumElementos();
    }
    interface INumeroCuerdas //Declaración de interfaz para instrumentos de cuerdas
    {
        int NumCuerdas();
    }
    class Instrumento
    {
        string nombre;
        public Instrumento(String nombre) => this.nombre = nombre;   
        public void Sonido() => Console.WriteLine("-Emite sonido");

        public void getNombre() => Console.WriteLine(nombre);
        public virtual void getTipo() => Console.WriteLine("El instrumento puede ser de percusión, cuerdas o aire");
    }

    class Batería : Instrumento, IElementos //Hereda de interfaz IElementos
    {
        public Batería(String nombre) : base(nombre) { }

        public void Golpear() => Console.WriteLine("-Funciona en base a 'golpear' el instrumento");
        public override void getTipo() => Console.WriteLine("-Es un instrumento de percusión");

        public int NumElementos() => 3; //Método de la interfaz de la que hereda
    }

    class Violín : Instrumento, INumeroCuerdas, IElementos //Hereda de dos interfaces
    { 
        public Violín(String nombre) : base(nombre) { }

        public void Vibrar() => Console.WriteLine("-Funciona en base a vibraciones sobre las cuerdas del instrumento");
        public override void getTipo() => Console.WriteLine("-Es un instrumento de cuerda");
        public int NumCuerdas() => 4; //Método de interfaz INumeroCuerdas

        public int NumElementos() => 2; //Método de interfaz IElementos
    }

    class Flauta : Instrumento
    { 
        public Flauta(String nombre) : base(nombre) { }

        public void Soplar() => Console.WriteLine("-Funciona a base de soplar el instrumento");
        public override void getTipo() => Console.WriteLine("-Es un instrumento de aire");
    }
}
