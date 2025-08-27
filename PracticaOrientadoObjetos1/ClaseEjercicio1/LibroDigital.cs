using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class LibroDigital : Libro
    {
        public double pesoenMb { get; set; }
        public string formato { get; set; }

        public LibroDigital(string titulo, string autor, int paginas, double pesoenMb, string formato)
        : base (titulo, autor, paginas)
        {
            this.pesoenMb = pesoenMb;
            this.formato = formato;
        }
    }
}
