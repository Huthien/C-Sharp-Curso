using System;
using System.Runtime.InteropServices;

namespace ClasesAbstractas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cracterísticas de un cangrejo:
            Cangrejo cangrejo = new Cangrejo("Cangrejo");
            cangrejo.getNombre();
            Console.WriteLine($"Número de patas: {cangrejo.NumPatas()}");
            cangrejo.Desplazarse();

            //Características de una Abeja:
            Abeja abeja = new Abeja("Abeja");
            abeja.getNombre();
            Console.WriteLine($"Número de patas: {abeja.NumPatas()}");
            abeja.HacerMiel();
            Console.WriteLine($"-Es capaz de volar? = {abeja.Volar()}");

            //Características de una Hormiga:
            Hormiga hormiga = new Hormiga("Hormiga");
            hormiga.getNombre();
            Console.WriteLine($"Número de patas: {hormiga.NumPatas()}");
            hormiga.Transportar();
            Console.WriteLine($"-Es capaz de volar? = {hormiga.Volar()}");

            //Características de un Mosquito:
            Mosquito mosquito = new Mosquito("Mosquito");
            mosquito.getNombre();
            Console.WriteLine($"Número de patas: {mosquito.NumPatas()}");
            mosquito.ChuparSangre();
            Console.WriteLine($"-Es capaz de volar? = {mosquito.Volar()}");
        }
    }

    //Se declara una clase abstracta por encima de las demás:
    abstract class Artrópodos 
    {
        //Método abstracto que heredarán las subclases que lo requieren:
        abstract public int NumPatas();
        abstract public void getNombre();
    }
    class Insectos : Artrópodos //Clase padre Insectos
    {
        String nombre;
        int patas;
        bool volar;
        public Insectos(String nombre) => this.nombre = nombre;

        //Métodos override heredados de la clase abstracta
        public override void getNombre() => Console.WriteLine($"\nNombre del Insecto: {nombre}");
        public override int NumPatas() => 6;

        //Método propio de la clase insecto, heredado por sus subclases
        public virtual bool Volar() => volar;
    }

    class Abeja : Insectos //Subclase de Insectos
    { 
        public Abeja(String nombre):base(nombre) { }

        //Método propio de la clase
        public void HacerMiel() => Console.WriteLine("-Son capaces de crear miel en sus panales");

        public override bool Volar() => true; //Método heredado de la clase Insectos
    }

    class Hormiga :Insectos //Subclase de Insectos
    {
        public Hormiga(String nombre) : base(nombre) { }

        //Método propio de la clase
        public void Transportar() => Console.WriteLine("-Pueden transportar cargas de hasta 50 veces su peso con sus mandíbulas");

        public override bool Volar() => false; //Método heredado de la clase Insectos
    }

    //La palabra reservada sealed sella la clase mosquito
    sealed class Mosquito : Insectos //Subclase de Insectos
    {
        public Mosquito(String nombre) : base(nombre) { }

        //Método propio de la clase
        public void ChuparSangre() => Console.WriteLine("-Se alimentan de absorber sangre de otros animales");

        public override bool Volar() => true; //Método heredado de la clase Insectos
    }

    class Cangrejo : Artrópodos //No es un insecto por lo que hereda de la clase abstracta Artrópodos
    {
        int patas;
        string nombre;

        public Cangrejo(String nombre) => this.nombre = nombre;

        //Método propio de la clase
        public void Desplazarse() => Console.WriteLine("-Puede desplazarse de lado");

        //Métodos heredados de la clase abstracta
        public override int NumPatas() => 10;
        public override void getNombre() => Console.WriteLine($"\nNombre del Artrópodo: {nombre}");
    }

    //La palabra reservada sealed sirve para sellar una clase para que otras no puedan heredas de ella
    //También sirve para sellar métodos para que no puedan ser sobreescritos por otras subclases con override
}
