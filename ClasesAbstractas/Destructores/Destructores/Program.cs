using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Destructores
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos mi_archivo = new ManejoArchivos();
            mi_archivo.Mensaje();
        }
    }

    class ManejoArchivos
    {
        StreamReader archivo = null;
        int contador = 0;
        string linea;

        public ManejoArchivos() 
        {
            archivo = new StreamReader(@"PATH"); //Se reemplaza PATH con el directorio del archivo txt a leer

            while ((linea = archivo.ReadLine()) != null) 
            {
                Console.WriteLine(linea);
                contador++;
            }
        }

        public void Mensaje() => Console.WriteLine("Hay {0} lineas", contador);

        //Creación del destructor (Se debe llamar igual a la clase, como los constructores)
        ~ManejoArchivos() => archivo.Close();
    }
}
