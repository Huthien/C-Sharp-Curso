using System;
using System.Runtime.InteropServices;

namespace Protected
{
    class Program
    {
        static void Main(string[] args)
        {
            Cartas carta = new Cartas("Chinchón");
            carta.getNombre();
            carta.Reglas();

            Tablero tablero = new Tablero("Ajedrez");
            tablero.getNombre();
            tablero.Reglas();
            tablero.Piezas();

            //tablero.Reglamento(); da error porque usamos protected en el método de la clase padre y solo puede ser 
            //accedido desde la clase principal y las subclases que heredan.
        }
    }

    class Juego
    {
        private String nombre;
        public Juego(String nombre) => this.nombre = nombre;
        public void getNombre() => Console.WriteLine($"\nNombre del juego: {nombre}");
        protected void Reglamento() => Console.WriteLine("Tiene reglamento");
    }

    class Cartas : Juego 
    {
        public Cartas(String nombreJuego):base(nombreJuego) 
        {
            nombre = nombreJuego;
        }

        public void Reglas() 
        {
            //Al usar protected en el método declarado en la clase padre, podemos acceder a él desde la subclase:
            Reglamento();
        }
        public void Mazo() => Console.WriteLine("Se usa un mazo español de 40 naipes o el clásico de 50");
        
        private String nombre;

    }

    class Tablero : Juego
    {
        public Tablero(String nombreJuego) : base(nombreJuego)
        {
            nombre = nombreJuego;
        }

        public void Piezas() => Console.WriteLine("Se juega con 32 piezas, 16 por jugador");
        public void Reglas() 
        { 
            Reglamento() ; 
        }
        private string nombre;
    }
    //El modificador de acceso protected permite que una variable o método sea accesible desde la clase en la que se 
    //declare y desde las subclases que hereden dicha clase.
}
