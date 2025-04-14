using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea una task:
            Task t1 = new Task(EjecutarTarea); //Task que ejecuta un método
            Task t2 = new Task(() =>  //Task que ejecuta código desde la instancia
            {
                for (int i = 0; i < 10; i++) 
                {
                    var t = Thread.CurrentThread.ManagedThreadId;
                    Thread.Sleep(1000);
                    Console.WriteLine($"Tarea del thread N°: {t}");
                }
            } );

            //Se le indica a la task que inicie:
            t1.Start();
            t2.Start();
            Console.ReadLine(); //Para que el programa no finalice antes de la ejecución de las task  
        }
        static void EjecutarTarea() 
        {
            for (int i = 0; i < 10; i++)
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Esta vuelta corresponde al thread N°: {t}");
            }
        }
    }
}
