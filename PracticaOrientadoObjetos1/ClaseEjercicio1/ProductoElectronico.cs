using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class ProductoElectronico : Producto
    {
        //Subclase ProductoElectronico agrega Voltaje y TieneGarantia.Crear sus constructores.
        public int voltaje { get; set; }
        public string tienegarantia { get; set; }

        public ProductoElectronico(string nombre, double precio, int voltaje, string tienegarantia) 
        : base (nombre, precio)
        {
            this.voltaje = voltaje;
            this.tienegarantia = tienegarantia;
        }
    }
}
