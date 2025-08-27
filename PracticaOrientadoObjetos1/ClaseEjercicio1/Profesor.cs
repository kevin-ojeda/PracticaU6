using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Profesor : PersonaNueva
    {
        //Profesor tiene Materia y método Enseñar().Crear sus constructores.
        public string materia { get; set; }
        public void Enseñar()
        {
            Console.WriteLine($"{Nombreee} esta enseñando");
        } 
        public Profesor(string Nombreee, int DNI, string materia) : base(Nombreee, DNI)
        {
            this.materia = materia;
        }
    }
}
