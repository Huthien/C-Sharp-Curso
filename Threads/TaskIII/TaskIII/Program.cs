using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace TaskIII
{
    class Program
    {
        static void Main(string[] args)
        {
            RealizarTodasTareas();
            Console.ReadLine();
        }

        static void RealizarTodasTareas() //Método que llama a los demás
        {
            Task t1 = Task.Run(() =>
            {
                EjecutarTarea1();
            });

            Task t2 = Task.Run(() =>
            {
                EjecutarTarea2();
            });

            //Le decimos con WaitAll() que espere la finalización de ejecución de las tareas pasadas en el parámetro:
            Task.WaitAll(t1,t2); 

            //A diferencia del método WaitAll(), le podemos decir que espere a que una de las dos finalice su ejecución
            //o proporcione la información necesaria para la ejecución de la siguiente tarea con el método WaitAny()

            Task t3 = Task.Run(() =>
            {
                EjecutarTarea3();
            });

            //Se indica que hasta que la tarea 3 no esté terminada no se ejecuten las demás que le siguen:
            t3.Wait(); //Uso del método Wait()

            Task t4 = Task.Run(() =>
            {
                EjecutarTarea4();
            });

            Task t5 = Task.Run(() =>
            {
                EjecutarTarea5();
            });
        }


        //Se declaran 3 métodos, cada uno con sus tareas
        static void EjecutarTarea1() 
        { 
            for (int i = 0; i < 10; i++) 
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(1000);
                Console.WriteLine($"Tarea 1 --- Hilo N°: {t}");
            }
        }

        static void EjecutarTarea2()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 2 --- Hilo N°: {t}");
            }
        }

        static void EjecutarTarea3()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 3 --- Hilo N°: {t}");
            }
        }

        static void EjecutarTarea4()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 4 --- Hilo N°: {t}");
            }
        }

        static void EjecutarTarea5()
        {
            for (int i = 0; i < 10; i++)
            {
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"Tarea 5 --- Hilo N°: {t}");
            }
        }
    }
}
