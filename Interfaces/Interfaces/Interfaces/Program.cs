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
            Console.WriteLine($"Número de elementos: {inst1.Num()}");

            Console.WriteLine("\nInstrumento: ");
            inst2.getNombre();
            inst2.getTipo();
            inst2.Sonido();
            inst2.Vibrar();

            //Donde se produjo la ambigüedad se llama a un método específico creando un objeto de tipo interfaz
            //y decirle que es igual a nuestro objeto con el método de sustitución:

            INumeroCuerdas numCuerdas = inst2;
            IElementos elem = inst2;
            Console.WriteLine($"Número de cuerdas: {numCuerdas.Num()}");  
            Console.WriteLine($"Número de elementos: {elem.Num()}");

            Console.WriteLine("\nInstrumento: ");
            inst3.getNombre();
            inst3.getTipo();
            inst3.Sonido();
            inst3.Soplar();
        }
    }

    interface IElementos //Se declara una interfaz para que las subclases que tienen varios elementos la hereden
    {
        int Num();
    }
    interface INumeroCuerdas //Declaración de interfaz para instrumentos de cuerdas
    {
        int Num();
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

        public int Num() => 3; //Método de la interfaz de la que hereda
    }

    class Violín : Instrumento, INumeroCuerdas, IElementos //Hereda de dos interfaces
    { 
        public Violín(String nombre) : base(nombre) { }

        public void Vibrar() => Console.WriteLine("-Funciona en base a vibraciones sobre las cuerdas del instrumento");
        public override void getTipo() => Console.WriteLine("-Es un instrumento de cuerda");

        //Cuando una clase hereda dos métodos iguales pertenecientes a diferentes Interfaces de las que hereda se 
        //genera una ambigüedad y hay que especificar a que método hacemos referencia.

        //Se prescinde del modificador de acceso y se llama al nombre del método desde el nombre de la interfaz a la 
        //que hacemos referencia con la nomenclatura del punto:
        int INumeroCuerdas.Num() => 4; //Método de interfaz INumeroCuerdas

        int IElementos.Num() => 2; //Método de interfaz IElementos
    }

    class Flauta : Instrumento
    { 
        public Flauta(String nombre) : base(nombre) { }

        public void Soplar() => Console.WriteLine("-Funciona a base de soplar el instrumento");
        public override void getTipo() => Console.WriteLine("-Es un instrumento de aire");
    }
}
