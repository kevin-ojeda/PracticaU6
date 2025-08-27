using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clases
{
    internal class Carrito
    {
        public List<Caramelo> ListaCompra { get; set; }
        public void agregarCaramelo(Caramelo caramelos)
        {
            ListaCompra.Add(caramelos);
        }
        public double CalcularTotal()
        {
            double total = 0;
            foreach (Caramelo caramelo in ListaCompra)
            {
                total += caramelo.CalcularPrecioTotal();
            }
            return total;
        }
    }
}
