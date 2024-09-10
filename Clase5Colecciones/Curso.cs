using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class Curso
    {
        public string NombreDelCurso {  get; set; }
        public List<Estudiante> Estudiantes { get; set; }

        public Curso(string nombreDelCurso) { 
         NombreDelCurso = nombreDelCurso;
            Estudiantes = new List<Estudiante>();
        
        }

        public void AgregarEstudiante(Estudiante estudiante) {
        
            Estudiantes.Add(estudiante);
        
        }

        public void MostrarEstudiantes()
        {
            foreach (var estudiante in Estudiantes)
            {
                estudiante.MostrarInformacion();
            }
        }

    }
}
