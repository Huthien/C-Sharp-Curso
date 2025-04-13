using System;
using System.Linq.Expressions;
using System.Threading;

namespace BloqueoThreads
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CuentaBancaria cuenta = new CuentaBancaria(5000);
            Thread[] personas = new Thread[15];

            for (int i = 0; i < personas.Length; i++) 
            {
                Thread t = new Thread(cuenta.LlamadaExtraer);
                t.Name = i.ToString();
                personas[i] = t;
            }

            for (int i = 0; i < personas.Length; i++) 
            { 
                personas[i].Start(); 
                personas[i].Join(); //Se sincronizan los hilos
            }

        }
    }

    class CuentaBancaria 
    {
        private Object bloqueo = new Object();
        private double Saldo { set; get; }
        public CuentaBancaria(double saldo) => this.Saldo = saldo;

        public double ExtraerDinero(double cant) 
        {
            if (Saldo - cant < 0)
            {
                Console.WriteLine($"Hilo:{Thread.CurrentThread.Name} Saldo insuficiente --- Saldo en la cuenta: {Saldo}");
                return Saldo;
            }

            //Se limita el acceso a un hilo o thread a la vez:
            lock(bloqueo) //Se bloquea el pedazo de código al que acceden los hilos simultáneamente
            {
                if (Saldo >= cant)
                {
                    Console.WriteLine($"Hilo {Thread.CurrentThread.Name} ha retirado {cant}. Quedan {Saldo - cant} en la cuenta");
                    Saldo -= cant;
                }
                return Saldo;
            }
        }

        //Método que llama al método de extraer dinero 
        public void LlamadaExtraer()
        {
            Console.WriteLine("Hilo: {0} está retirando dinero", Thread.CurrentThread.Name);
            for (int i = 0; i < 4; i++) ExtraerDinero(500);
        }
    }
}
