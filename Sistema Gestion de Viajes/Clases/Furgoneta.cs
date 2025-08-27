using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Furgoneta : Vehiculo
    { 
        public int capacidadAdicional {  get; set; }
        public Furgoneta(int capacidadAdicional, string patente, int kilometraje)
        {
            this.capacidadAdicional = capacidadAdicional;
            this.kilometraje = kilometraje;
            this.placa = patente;
            ListaViajes = new List<Viaje>();
            tipo = "Furgoneta";
        }
    }
}
