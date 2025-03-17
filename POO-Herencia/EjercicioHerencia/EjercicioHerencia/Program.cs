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
            avion.PararMotor();
            avion.Conducir();

            Console.WriteLine("\nPropiedades de un auto:");
            auto.ArrancarMotor();
            auto.PararMotor();
            auto.Conducir();

            Console.WriteLine("\nPropiedades de una moto:");
            moto.ArrancarMotor();
            moto.PararMotor();
            moto.Conducir();
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
    }

    class Auto :Vehiculo
    { 
        public Auto() : base() { }
        public override void Conducir() => Console.WriteLine("-Se puede conducir de manera manual y automática");
    }

    class Moto : Vehiculo 
    { 
        public Moto() : base() { }
    }
}
