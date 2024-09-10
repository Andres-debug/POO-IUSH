using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class Estudiante
    {
        public string Nombre { get; set; }
        public int Edad {  get; set; }

        public Estudiante(string nombre, int edad) { 
            Nombre = nombre;
            Edad = edad;    
        }
        public void MostrarInformacion()
        {
            Console.WriteLine($"Nombre: {Nombre}, Edad: {Edad}");
        }



    }
}
