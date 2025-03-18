using System;

namespace EjercicioHerencia
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Instancias de los objetos:
            Avion avion = new Avion();
            Auto auto = new Auto();
            Moto moto = new Moto();

            Console.WriteLine("Propiedades de un avión:");
            avion.ArrancarMotor();
            avion.Despegar();
            avion.Aterrizar();
            avion.PararMotor();
            avion.Conducir();

            Console.WriteLine("\nPropiedades de un auto:");
            auto.ArrancarMotor();
            auto.PararMotor();
            auto.Conducir();

            Console.WriteLine("\nPropiedades de una moto:");
            moto.ArrancarMotor();
            moto.PararMotor();
            moto.Conducir(); //Usa el método de la clase padre porque no tiene un método conducir override propio.
        }
    }

    class Vehiculo 
    {
        public void ArrancarMotor() => Console.WriteLine("-Puede arrancar el motor");
        public void PararMotor() => Console.WriteLine("-Puede parar el motor");

        public virtual void Conducir() => Console.WriteLine("-Se puede conducir"); //Método virtual
    }

    class Avion : Vehiculo
    {
        public Avion() : base() { }
        public override void Conducir() => Console.WriteLine("-Se pilotea de manera manual o automática");

        //Métodos propios de un avión:
        public void Despegar() => Console.WriteLine("-Puede despegar");
        public void Aterrizar() => Console.WriteLine("-Puede Aterrizar");
    }

    class Auto :Vehiculo
    { 
        public Auto() : base() { }
        public override void Conducir() => Console.WriteLine("-Se conduce de manera manual o automática");
    }

    class Moto : Vehiculo 
    { 
        public Moto() : base() { }
    }
}
