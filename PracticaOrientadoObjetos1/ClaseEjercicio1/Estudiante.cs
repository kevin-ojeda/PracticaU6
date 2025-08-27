using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Estudiante : PersonaNueva
    {
        public int legajo { get; set; }
        public void estudiar()
        {
            Console.WriteLine($"{Nombreee} esta estudaindo");
        }
        public Estudiante (string Nombreee, int DNI, int legajo) : base (Nombreee, DNI)
        {
            this.legajo = legajo;
        }
    }
}
