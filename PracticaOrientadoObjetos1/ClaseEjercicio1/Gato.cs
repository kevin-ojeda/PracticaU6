using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Gato : Animal
    {
        public int Edad {  get; set; }
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} Tiene {Edad} años y esta Maullando"); 
        }
        public Gato(string Nombre, int Edad) : base(Nombre) 
        {
            this.Edad = Edad;
        }
    }
}
