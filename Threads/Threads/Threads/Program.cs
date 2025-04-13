using System;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t1 = new Thread(Despedida); //Se hace un hilo con la tarea que se realizará de manera simultánea
            Thread t2 = new Thread(Pregunta);
            t1.Start();
            t1.Join();//El método Join() sincroniza la ejecución del hilo o thread
            t2.Start();
            t2.Join();

            //Sleep permite poner una especia de pausa o delay en la ejecución del código
            Console.WriteLine("Hello World!!");
            Thread.Sleep(500); // Permite dormir el hilo durante medio segundo 
            Console.WriteLine("Hello World!!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!!");
            Thread.Sleep(500);
            Console.WriteLine("Hello World!!");
            Thread.Sleep(500);
        }

        static void Despedida() 
        {
            Console.WriteLine("Goodbye World...");
            Thread.Sleep(500); 
            Console.WriteLine("Goodbye World...");
            Thread.Sleep(500);
            Console.WriteLine("Goodbye World...");
            Thread.Sleep(500);
            Console.WriteLine("Goodbye World...");
            Thread.Sleep(500);
            Console.WriteLine("Goodbye World...");
            Thread.Sleep(500);
        }

        static void Pregunta() 
        {
            Console.WriteLine("How are you?");
            Thread.Sleep(500);
            Console.WriteLine("How are you?");
            Thread.Sleep(500);
            Console.WriteLine("How are you?");
            Thread.Sleep(500);
            Console.WriteLine("How are you?");
            Thread.Sleep(500);
            Console.WriteLine("How are you?");
            Thread.Sleep(500);
        }
    }
}
