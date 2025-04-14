using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CancelacionTask
{
    class Program
    {
        static int acumulador = 0;
        static void Main(string[] args)
        {
            //El cancellation token source señala qué cancellation token es el que cancelará la task
            CancellationTokenSource miToken = new CancellationTokenSource();
            CancellationToken cancelaToken = miToken.Token;//Se crea el token que cancela

            Task t1 = Task.Run(() => EjecutarTarea(cancelaToken));

            for (int i = 0; i < 100; i++) 
            { 
                acumulador += 30;
                Thread.Sleep(1000);
                //Se chequea si la variable acumulador es mayor a 100, y si es así se cancela la tarea
                if (acumulador > 100) 
                { 
                    miToken.Cancel();
                    break;//Se sale del bucle
                }
            }
           
            Thread.Sleep(1000);
            Console.WriteLine($"VALOR DE ACUMULADOR: {acumulador}");
            Console.ReadLine();
        }

        //Se le indica al método a través de un parámetro que puede ser cancelado bajo ciertas circunstancias:
        static void EjecutarTarea(CancellationToken tk) 
        {
            for (int i = 0; i < 100; i++) 
            {
                acumulador++;
                var t = Thread.CurrentThread.ManagedThreadId;
                Thread.Sleep(500);
                Console.WriteLine($"El hilo N°: {t} está ejecutando la tarea");
                Console.WriteLine(acumulador);
                if (tk.IsCancellationRequested) 
                {
                    acumulador = 0;
                    return; 
                }
            }
        }
    }
}
