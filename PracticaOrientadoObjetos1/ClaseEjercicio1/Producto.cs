using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Producto
    {
        //Clase Producto con Nombre, Precio.
        //Subclase ProductoPerecedero agrega FechaCaducidad y método EstaVencido().
        //Subclase ProductoElectronico agrega Voltaje y TieneGarantia.Crear sus constructores.
        public string nombre { get; set; }
        public double precio { get; set; }
        public Producto (string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }
    }
}
