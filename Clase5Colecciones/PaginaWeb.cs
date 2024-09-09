using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class PaginaWeb
    {
        public string URL { get; set; }

        public PaginaWeb(string url)
        {
            URL = url;
        }

        public void MostrarPagina()
        {
            Console.WriteLine($"Visitando: {URL}");
        }
    }
}
