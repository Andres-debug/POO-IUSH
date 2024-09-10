using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase5Colecciones
{
    class Tienda
    {
        public Dictionary<string, Producto> Inventario { get; set; }

        public Tienda()
        {
            Inventario = new Dictionary<string, Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            Inventario.Add(producto.Nombre, producto);
        }

        public void MostrarInventario()
        {
            foreach (var item in Inventario)
            {
                Console.WriteLine($"Producto: {item.Value.Nombre}, " +
                    $"Precio: {item.Value.Precio}");
            }
        }

        public decimal ObtenerPrecio (string nombreProducto)
        {
            if (Inventario.ContainsKey(nombreProducto))
            {
                return Inventario[nombreProducto].Precio;
            }
            else
            {
                Console.WriteLine("Producto No Enocntrado");
                return 0;
            }
        }
    }
}
