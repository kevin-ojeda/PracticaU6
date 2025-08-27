using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Automovil : Vehiculo
    {
        //Clase Automovil hereda de Vehiculo y agrega NumeroDePuertas.
        public int numerodepuertas {  get; set; }
        public override void Conducir()
        {
            Console.WriteLine("Esta conduciendo un automovil");
        }
        public Automovil(int numerodepuertas)
        {
            this.numerodepuertas = numerodepuertas;
        }
    }
}
