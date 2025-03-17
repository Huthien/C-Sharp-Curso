using System;
using System.Runtime.InteropServices;
using System.Security;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cada objeto creado hereda de Empleado por lo que se puede llamar a los métodos de la clase, 
            //pero cada uno no puede acceder de manera independiente a los métodos de las otras clases de las que NO heredan 
            

            Secretario secretario = new Secretario("Julio"); //Se pasa el parámetro nombre pedido por el constructor
            Jefe jefe = new Jefe("Walter");
            Director director = new Director("Ernesto");

            //Principio de sustitución: Se crean dos objetos y se le dice a uno que es igual al otro, siempre teniendo
            //en cuenta la jerarquía:
            Empleado persona = new Empleado("Persona");
            Secretario secretario2 = new Secretario("Marta");
            persona = secretario2; //Se sustituye el parámetro de la clase padre con el parámetro del nuevo objeto

            Console.WriteLine("Secretario:");
            secretario.getNombre();
            Console.WriteLine("Tareas:");
            secretario.Horario();
            secretario.Papeleo();
            secretario.Administracion();

            Console.WriteLine("\nJefe: ");
            jefe.getNombre();
            Console.WriteLine("Tareas:");
            jefe.Horario();
            jefe.Papeleo();
            jefe.Supervisar();

            Console.WriteLine("\nDirector: ");
            director.getNombre();
            Console.WriteLine("Tareas:");
            director.Horario();
            director.Papeleo();
            director.TomaDecisiones();

            Console.WriteLine("\nNuevo Empleado - Secretario:");
            persona.getNombre();           
        }
    }

    class Empleado
    {
        string nombre;
        public Empleado(String nombre) { this.nombre = nombre; } //Se crea un constructor para la clase padre
        public virtual void Horario() => Console.WriteLine("- Trabajar 8 horas diarias");

        public void Papeleo() => Console.WriteLine("- Realizar papeleo básico");

        public void getNombre() => Console.WriteLine($"Nombre: {nombre}"); 
    }

    class Jefe : Empleado//La clase Jefe hereda métodos y propiedades de la clase Empleado
    {
        //Se crea un constructor para la subclase y se le indica que llame al constructor de la clase padre usando base:
        public Jefe(String nombre) : base(nombre) { } 
        public void Supervisar() => Console.WriteLine("- Supervisar a los secretarios y trabajadores de la oficina");
    }

    class Director : Empleado //La clase Director hereda métodos y propiedades de la clase Empleado
    {
        public Director(String nombre) : base(nombre) { }
        public void TomaDecisiones() => Console.WriteLine("- Dirijir la empresa tomando decisiones importantes");

        //Override se usa para sobreescribir un método heredado de la clase padre siempre y cuando el método en 
        //la clase padre sea virtual, porque lo que hace es ocultar el método heredado y sobreescribir una modificación
        public override void Horario() => Console.WriteLine("- Trabajar 4 horas en oficina y 4 horas remoto");
    }

    class Secretario : Empleado //La clase Secretario hereda métodos y propiedades de la clase Empleado
    {
        public Secretario(String nombre) : base(nombre) { }

        //El método papeleo de la clase Secretario invalida el método papeleo heredado de Empleado al tener el mismo
        //nombre y número de parámetros (sobrecarga de métodos), por lo que se usa new para quitar la advertencia de 
        //la sobrecarga:
        new public void Papeleo() => Console.WriteLine("- Realizar papeleo de los turnos e información de clientes");
        public void Administracion() => Console.WriteLine("- Administrar turnos y reuniones de la empresa");
    }

    //La superclase cósmica Object es la clase de la que heredan todas las clases que creas, es la clase que 
    //siempre está en la cúspide de la jerarquía de manera implícita. Por ende todas las clases que creas 
    //heredarán los métodos de la clase Object, siempre y cuando se tengan en cuenta los modificadores de acceso.

    //En casos con el principio de sustitución, para que se hereden los métodos correspondientes se debe---
}
