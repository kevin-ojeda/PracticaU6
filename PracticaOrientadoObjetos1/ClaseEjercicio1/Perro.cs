using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Perro : Animal
    {
        public string Raza { get; set; }
        public int Edad { get; set; }
        public override void HacerSonido()
        {
            Console.WriteLine($"{Nombre} de la Raza {Raza} con {Edad} Años Esta Ladrando.");
        }
        public Perro(string nombre, string Raza, int Edad) : base(nombre)
        {
            this.Raza = Raza;
            this.Edad = Edad;
        }
    }
}
