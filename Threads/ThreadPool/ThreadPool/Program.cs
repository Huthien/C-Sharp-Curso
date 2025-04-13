using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolTask
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++) 
            {
                //Se crea un pool de threads que reutilizará los threads que finalizan sus tareas para ejecutar otras
                ThreadPool.QueueUserWorkItem(EjecutarTarea,i);
            }
        }

        static void EjecutarTarea(Object obj) 
        {
            int nTarea = (int)obj;
            Console.WriteLine($"Thread N°: {Thread.CurrentThread.ManagedThreadId} a comenzado la tarea N°{nTarea}!");
            Thread.Sleep(1000);
            Console.WriteLine($"Thread N°: {Thread.CurrentThread.ManagedThreadId} a finalizado la tarea N°{nTarea}...");
        }
    }
}
