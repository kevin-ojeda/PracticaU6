using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingenieria_de_software
{
    public class Turron
    {
        public bool contieneMani { get; set; }
        public string nombreDelDulce { get; set; }
        public int cantidad { get; set; }
        public double precio { get; set; }
        public Turron(bool contieneMani, string nombreDelDulce, int cantidad, double precio)
        {
            this.contieneMani = contieneMani;
            this.nombreDelDulce = nombreDelDulce;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public double CalcularPrecioTotal()
        {
            return cantidad * precio;
        }
    }
}
