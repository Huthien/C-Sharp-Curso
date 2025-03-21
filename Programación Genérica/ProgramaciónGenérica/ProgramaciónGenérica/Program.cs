using System;

namespace ProgramaciónGenérica
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se reutiliza la clase Genérica de AlmacenObjetos para manejar diferentes tipos de elementos:

            //Creación de un objeto AlmacenObjetos que maneja elementos de tipo objeto:
            AlmacenObjetos<Caja> cajas = new AlmacenObjetos<Caja>(4);
            cajas.AgregarObj(new Caja("Box1"));
            cajas.AgregarObj(new Caja("Box2"));
            cajas.AgregarObj(new Caja("Box3"));
            cajas.AgregarObj(new Caja("Box4"));
            Caja caja = cajas.getObjeto(2);
            //Se obtiene el nombre del objeto caja en el index pasado por parámetro:
            Console.WriteLine($"El nombre de la caja es: {caja.getNombre()}");

            //Creación de un objeto AlmacenObjetos que maneja elementos de tipo int:
            AlmacenObjetos<int> numeros = new AlmacenObjetos<int>(4);
            numeros.AgregarObj(45);
            numeros.AgregarObj(125);
            numeros.AgregarObj(78);
            numeros.AgregarObj(349);
            //Se obtiene el valor almacenado en el index pasado por parámetro:
            Console.WriteLine($"El número es: {numeros.getObjeto(2)}");
        }
    }

    //Creación de la clase genérica:
    class AlmacenObjetos <T> //Se usa por convencion una T mayúscula como genérico
    {
        //Variables de Campo:
        private T[] datos;
        private int i;

        //Constructor
        public AlmacenObjetos(int z) => datos = new T[z];

        //Métodos:
        public void AgregarObj(T obj)
        {
            datos[i] = obj;
            i++;
        }

        public T getObjeto(int i) 
        { 
            return datos[i];
        }
    }

    class Caja 
    {
        private String nombre;
        public Caja(String nombre) => this.nombre = nombre;

        public String getNombre() => nombre;
    }
}
