using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    internal class Camion : Automovil
    {
        //Clase Camion hereda de Automovil y agrega CapacidadCarga. Crear sus constructores.
        public int capacidadcarga {  get; set; }
        public override void Conducir()
        {
            Console.WriteLine("Esta conduciendo un camion");
        }
        public Camion(int numerodepuertas, int capacidadcarga) : base(numerodepuertas) 
        {
            this.capacidadcarga = capacidadcarga;
        } 

    }
}
