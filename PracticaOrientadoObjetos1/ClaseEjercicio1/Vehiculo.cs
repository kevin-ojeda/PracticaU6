using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Vehiculo
    {
        //Crear clase base Vehiculo con método Conducir().
        //Clase Automovil hereda de Vehiculo y agrega NumeroDePuertas.
        //Clase Camion hereda de Automovil y agrega CapacidadCarga. Crear sus constructores.

        public virtual void Conducir()
        {
            Console.WriteLine("Vehiculo generico");
        }

    }
}
