using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3
{
    internal class Empleado: Persona
    {   
        public readonly string Id;
        private int Sueldo;
        public Empleado(String nombre, int edad,int sueldo) : base(nombre, edad)
        {
            Sueldo = sueldo;
        }

        public int AumentarSueldo()
        {
            return Sueldo = Sueldo + 1000;
        }

        public int AumentarSueldo(int num)
        {
            return Sueldo = Sueldo * num;
        }
    }
}
