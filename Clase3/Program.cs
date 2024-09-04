using System;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado emp1 = new Empleado("Pablo", 20,2000);
            Console.WriteLine(emp1.Edad);
            emp1.Edad = 30;
            Console.WriteLine(emp1.Edad);
            Console.WriteLine(emp1.AumentarSueldo());
        }
    }
}