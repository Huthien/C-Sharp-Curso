using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskII
{
    class Program
    {
        static void Main(string[] args)
        {
            Task t1 = Task.Run(() => {EjecutarTarea();});
            //La task 2 se ejecuta solo cuando la primera haya finalizado usando el método ContinueWith()
            //Para que no de error al llamar al método, a ese método hay que decirle que recibe como parámetro
            //un objeto de tipo Task:
            Task t2 = t1.ContinueWith(EjecutarTarea2);
            Console.ReadLine();
        }

        static void EjecutarTarea() 
        { 
            var t = Thread.CurrentThread.ManagedThreadId;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"TAREA 1 --- Hilo N°: {t}");
            }
        }

        static void EjecutarTarea2(Task task) //Se le pasa un objeto de tipo Task como parámetro
        {
            var t = Thread.CurrentThread.ManagedThreadId;
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine($"TAREA 2 --- Hilo N°: {t}");
            }
        }
    }
}
