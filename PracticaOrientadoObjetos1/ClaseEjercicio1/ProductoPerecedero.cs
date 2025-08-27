using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ClaseEjercicio1
{
    public class ProductoPerecedero : Producto
    {
        ////Subclase ProductoPerecedero agrega FechaCaducidad y método EstaVencido().
        public DateTime fechacaducidad { get; set; }
        public void estavencido()
        {
            if (DateTime.Now < fechacaducidad)
                Console.WriteLine($"el producto {nombre} no esta vencido");
            else Console.WriteLine($"el producto {nombre} esta vencido");
        }
        public ProductoPerecedero(string nombre, double precio, DateTime fechacaducidad)
        : base(nombre, precio)
        {
            this.fechacaducidad = fechacaducidad;
        }
    }
}
