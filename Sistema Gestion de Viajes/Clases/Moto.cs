using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Moto : Vehiculo
    {

        public Moto(string patente, int kilometraje)
        {
            this.kilometraje = kilometraje;
            this.placa = patente;
            ListaViajes = new List<Viaje>();
            tipo = "moto";
        }
    }
}
