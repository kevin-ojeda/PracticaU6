using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Carrito
    {
        public List<Productos> Items { get; set; } = new List<Productos>();

        public void AgregarProducto(Productos producto, int cantidad)
        {
            var existente = Items.FirstOrDefault(p => p.NombreProducto == producto.NombreProducto);
            if (existente != null)
            {
                existente.Stock += cantidad;
            }
            else
            {
                Items.Add(new Productos
                {
                    NombreProducto = producto.NombreProducto,
                    Precio = producto.Precio,
                    Stock = cantidad
                });
            }
        }

        public void MostrarCarrito()
        {
            if (Items.Count == 0)
            {
                Console.WriteLine("El carrito está vacío.");
                return;
            }

            Console.WriteLine("Contenido del carrito:");
            foreach (var item in Items)
            {
                Console.WriteLine($"{item.NombreProducto} - {item.Stock} unidades - Total: ${item.Stock * item.Precio}");
            }
            Console.WriteLine($"Total general: ${CalcularTotal()}");
        }

        public double CalcularTotal()
        {
            return Items.Sum(p => p.Precio * p.Stock);
        }

        public void ConfirmarCompra(List<Productos> inventario)
        {
            foreach (var item in Items)
            {
                var productoInventario = inventario.FirstOrDefault(p => p.NombreProducto == item.NombreProducto);
                if (productoInventario != null)
                {
                    productoInventario.Stock -= item.Stock;
                }
            }

            Console.WriteLine("Compra confirmada. ¡Gracias por tu compra!");
            Items.Clear();
        }
    }
}
