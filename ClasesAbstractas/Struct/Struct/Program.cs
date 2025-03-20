using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crea un objeto de tipo empleado son su salario y comision
            Empleado emp1 = new Empleado(2500, 300);
            Console.WriteLine(emp1);

            //Se incrementa el salario y la comision, pero los cambios no se ven reflejados porque Empleado es struct
            emp1.cambiaSalario(emp1, 100);
            Console.WriteLine(emp1);
            
        }
    }

    struct Empleado //Se almacena en la memoria stack y los cambios solo afectan a la copia en vez de a la estructura
    {
        private double salario;
        private double comision;
        public Empleado(int salario, int comision)
        {
            this.salario = salario;
            this.comision = comision;
        }

        public override string ToString()
        {
            return string.Format("Salario del empleado: {0} \nComisión: {1}", this.salario, this.comision);
        }

        public void cambiaSalario(Empleado em, double incremento)
        {
            em.salario += incremento;
            em.comision += incremento;
        }
    }
}
