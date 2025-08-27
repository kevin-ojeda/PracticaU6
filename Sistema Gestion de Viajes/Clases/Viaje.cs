using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Viaje
    {
        public int distancia {  get; set; }
        public int cargaTransportada {  get; set; }
        public DateTime fecha { get; set; }

        public Viaje(int distancia, int cargaTransportada, DateTime fecha)
        {
            this.distancia = distancia;
            this.cargaTransportada = cargaTransportada;
            this.fecha = fecha;
        }
    }
}
