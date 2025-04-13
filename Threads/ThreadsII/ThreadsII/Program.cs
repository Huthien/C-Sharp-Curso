using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadsII
{
    class Program
    {
        static void Main(string[] args)
        {
            var tareaTerminada = new TaskCompletionSource<bool>(); //Es para indicar si la tarea ha sido finalizada

            var t1 = new Thread(() => 
            {
                for (int i = 0; i < 5; i++) 
                { 
                    Console.WriteLine("Thread 1");
                    Thread.Sleep(1000);
                } 
                tareaTerminada.SetResult(true);
            });

            var t2 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Thread 2");
                    Thread.Sleep(1000);
                }
            });

            var t3 = new Thread(() =>
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Thread 3");
                    Thread.Sleep(1000);
                }
            });

            //Se chequea si las tareas del Thread 1 y 2 han finalizado
            //Si las tareas finalizaron, entonces comenzará a ejecutarse el Thread 3
            t1.Start();
            t2.Start();
            var resultado = tareaTerminada.Task.Result;
            t3.Start();

            //A diferencia del método Join() que sincroniza los threads, ésta instrucción sirve para indicarle
            //a un Thread en específico que comience su tarea luego de que la tarea del thread que queramos haya
            //finalizado.
        }
    }
}
