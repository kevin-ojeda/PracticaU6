using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingenieria_de_software
{
    public class Caramelo
    {
        public int id { get; set; }
        public string sabor { get; set; }
        public string marca { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }

        public Caramelo(int id, string marca, string sabor, double precio, int cantidad)
        {
            this.id = id;
            this.marca = marca;
            this.sabor = sabor;
            this.precio = precio;
            this.cantidad = cantidad;
        }
        public double CalcularPrecioTotal()
        {
            return cantidad * precio;
        }
    }
}
