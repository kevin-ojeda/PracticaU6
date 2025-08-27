using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Productos
    {
        //La tienda vende productos: ropa, accesorios, cosas simples.
        //Cada producto tiene un nombre, un precio y una cantidad disponible

        public string NombreProducto { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public void MostrarProducto()
        {
            Console.WriteLine($"Nombre del producto: {NombreProducto}, Cantidad disponible: {Stock}, Precio: {Precio}USD");
        }

        /*
        public Productos(string NombreProducto, int Stock, double Precio)
        {
            this.NombreProducto = NombreProducto;
            this.Stock = Stock;
            this.Precio = Precio;
        }
        */
    }
}
