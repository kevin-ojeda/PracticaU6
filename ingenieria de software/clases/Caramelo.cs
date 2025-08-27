using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    public class Caramelo
    {
        public int id { get; set; }
        public string marca { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public string sabor { get; set; }

        public Caramelo(int id, string marca, int cantidad, double precio, string sabor)
        {
            this.id = id;
            this.marca = marca;
            this.cantidad = cantidad;
            this.precio = precio;
            this.sabor = sabor;
        }
        public double CalcularPrecioTotal()
        {
            return cantidad * precio;
        }
    }
}
