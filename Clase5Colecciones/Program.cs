using Clase5Colecciones;
using System;

namespace Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Navegador navegador = new Navegador();

            navegador.VisitarPagina(new PaginaWeb("https://github.com/Andres-debug/POO-IUSH"));
            navegador.VisitarPagina(new PaginaWeb("https://git-scm.com/download/win"));
            navegador.VisitarPagina(new PaginaWeb("https://visualstudio.microsoft.com/es/thank-you-downloading-visual-studio/?sku=Community&channel=Release&version=VS2022&source=VSLandingPage&passive=false&cid=2030"));

            navegador.RetrocederPagina();
            navegador.RetrocederPagina();
        }
    }
}