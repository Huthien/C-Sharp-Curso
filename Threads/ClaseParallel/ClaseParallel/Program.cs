using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ClaseParallel
{
    internal class Program
    {

        private static int acumulador = 0;
        static void Main(string[] args)
        {
            //Se usa la clase Parallel y su método For para simplificar el código y reemplazar el bucle for tradicional
            //Se pasa como primer parámetro el valor de inicio, le sigue el valor al que llegaría, y luego el nombre del
            //método a ejecutar:
            Parallel.For(0,100,RealizarTarea);
        }

        static void RealizarTarea(int dato) 
        {
            Console.WriteLine($"Acumulador vale: {acumulador}. Tarea realizada por el hilo N°: {Thread.CurrentThread.ManagedThreadId}");
            if ((acumulador % 2) == 0)
            {
                acumulador += dato;
                Thread.Sleep(100);
            }
            else 
            { 
                acumulador -= dato;
                Thread.Sleep(100);
            }
        }
    }
}
