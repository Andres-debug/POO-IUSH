using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class Pedido
    {
        public string Cliente { get; set; }
        public string Bebida {  get; set; }

        public Pedido(string cliente, string bebida) {
            Cliente = cliente;
            Bebida = bebida;
        }

        public void MostrarPedido()
        {
            Console.WriteLine($"Cliente: {Cliente}, Bebida: {Bebida}");
        }
    }
}
