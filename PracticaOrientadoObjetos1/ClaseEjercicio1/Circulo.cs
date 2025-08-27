using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Circulo : Figura
    {
        public double radio {  get; set; }
        public override void calculararea()
        {
            double area = radio * radio * 3.1416;
            Console.WriteLine($"el area del circulo es {area} cm2");
        }
        public Circulo(double radio)
        {
            this.radio = radio;
        }
    }
}
