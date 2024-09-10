using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    internal class Cafeteria
    {
        public Queue <Pedido> ColadePedidos { get; set; }

        public Cafeteria()
        {
            ColadePedidos = new Queue <Pedido>();
        }

        public void AgregarPedido(Pedido pedido) { 
        
        ColadePedidos.Enqueue(pedido);
            Console.WriteLine($"Pedido agregado: {pedido.Cliente} ha pedido {pedido.Bebida}");
        }

        public void AtenderPedido()
        {
            if (ColadePedidos.Count > 0)
            {
                Pedido pedidoAtendido = ColadePedidos.Dequeue();
                Console.WriteLine($"Atendiendo a {pedidoAtendido.Cliente}, Pedido: {pedidoAtendido.Bebida}");
            }
            else
            {
                Console.WriteLine("No hay pedidos pendientes");
            }
        }
    }
}
