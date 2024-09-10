using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class Navegador
    {
        public Stack <PaginaWeb> Historial { get; set; }

        public Navegador()
        {
            Historial = new Stack <PaginaWeb>();
        }

        public void VisitarPagina(PaginaWeb pagina) {

            Historial.Push(pagina);
            pagina.MostrarPagina();
        }

        public void RetrocederPagina()
        {
            if(Historial.Count > 0)
            {
                PaginaWeb paginaAnterior = Historial.Pop();
                Console.WriteLine($"Retrocediendo a {paginaAnterior.URL}");
            }
            else
            {
                Console.WriteLine("No hay mas paginas en el historial");
            }
        }
    }
}
