using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingenieria_de_software
{
    public class Carrito
    {
        public List<Caramelo> ListaCompra { get; set; } = new List<Caramelo>();
        public void agregarCaramelo(Caramelo caramelos)
        {
            if (ListaCompra == null)
            {
                ListaCompra = new List<Caramelo>();
            }
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
