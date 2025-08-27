using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Rectangulo : Figura
    {
        public double longitud { get; set; }
        public double altura { get; set; }
        public override void calculararea()
        {
            double area = longitud * altura;
            Console.WriteLine($"el area del rectangulo es {area} cm2");
        }
        public Rectangulo(double longitud, double altura)
        {
            this.longitud = longitud;
            this.altura = altura;
        }
    }
}
