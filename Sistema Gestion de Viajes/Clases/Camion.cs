using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Camion : Vehiculo
    {
        public int capacidadAdicional { get; set; }
        public int capacidadPasajeros { get; set; }
        public int cargaMaxima()
            
        {
            int max = 0;
            foreach (Viaje viaje in ListaViajes)
            {
                if (viaje.cargaTransportada > max)
                    max = viaje.cargaTransportada;
            }
            return 0;
        }


        public Camion(int capacidadMaxima, string patente, int kilometraje)
        {
            this.capacidadAdicional = capacidadMaxima;
            this.kilometraje = kilometraje;
            this.placa = patente;
            ListaViajes = new List<Viaje>();
            tipo = "Camion";
        }
    }
}
