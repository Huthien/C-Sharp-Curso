using System;

namespace Constructores
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se instancia un objeto de tipo Auto con un estado inicial:
            Auto auto1 = new Auto(); 
            Auto auto2 = new Auto();
            Auto auto3 = new Auto(2000,1000);

            //Se llama al método setter para indicar los valores que van a tener las propiedades
            //del auto instanciado:
            auto1.setExtras(false,"tela");
            auto2.setExtras(true,"tela");
            auto3.setExtras(true,"cuero");

            //Se llama al método get a través de cw para imprimir la información en pantalla:
            Console.WriteLine(auto1.getInfoAuto());
            Console.WriteLine(auto1.getExtras());

            Console.WriteLine(auto2.getInfoAuto());
            Console.WriteLine(auto2.getExtras()); 

            Console.WriteLine(auto3.getInfoAuto());
            Console.WriteLine(auto3.getExtras());
        }
    }

    //La palabra partial se usa para modularizar una clase en bloques
    partial class Auto //Primer bloque de la clase Auto (Constructores)
    {
        //Se declara una clase de tipo auto con sus propiedades o características
        private int ruedas;
        private double largo;
        private double ancho;
        private bool climatizador;
        private String tapicería;

        //El constructor es un método con el mismo nombre que la clase a la que pertenece:
        public Auto()
        {
            //Se determinan valores default para el auto:
            ruedas = 4;
            largo = 2400;
            ancho = 0.800;
        }

        //Se puede hacer una sobrecarga de constructores para tener varios objetos con diferentes
        //estados iniciales. Los constructores deben tener diferente cantidad de parámetros:
        public Auto(double largoAuto, double anchoAuto)
        {
            ruedas = 4;
            largo = largoAuto;
            ancho = anchoAuto;
        }
        //Incluso se puede crear un constructor vacío que será el que queda por defecto y 
        //otro/otros constructores por si pasamos parámetros
    }
    partial class Auto //Segundo bloque de la clase Auto (Getters y Setters)
    {
        //Se necesita un método de acceso para acceder a la información de las variables encapsuladas
        public string getInfoAuto() //Se hace un método getter para obtener la información del auto
        {
            return $"Información del auto:\nRuedas: {ruedas} \nLargo: {largo} \nAncho: {ancho}\n";
        }

        public void setExtras(bool climatizador, string tapicería)
        {
            //Se usa la palabra this para diferenciar las variables con el mismo nombre.
            //Una es la variable de campo (donde usamos this), y la otra es la variable de parámetro
            this.climatizador = climatizador;
            this.tapicería = tapicería;
        }

        public string getExtras()
        {
            return $"Extras:\nTapicería: {tapicería} \nClimatizador: {climatizador}\n";
        }
    }

    //Se pueden crear clases en archivos cs diferentes al principal, y desde el archivo main 
    //instanciar el objeto y utilizarlo. Es lo que se conoce como modularización del programa.
}
