using System;

namespace Finally
{
    class Program
    {
        static int num;
        static void Main(string[] args)
        {
            //Para que este programa funcione es necesario crear un archivo txt e insertar el  
            //path en la declaración de la variable path 
            System.IO.StreamReader archivo = null;

            try
            {
                string linea;
                int contador = 0;
                string path = @"NOMBRE DEL PATH";
                archivo = new System.IO.StreamReader(path);

                while ((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;
                }
            }
            catch (Exception e) { Console.WriteLine("ERROR --- No se puede leer el archivo"); }
            finally
            {
                if (archivo != null) archivo.Close();
                Console.WriteLine("Conexión con el fichero cerrada");
            }
            //Finally se puede utilizar en la conexión con bases de datos y para liberar recursos
        }
    }
}
