using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Persona
    {
        //Crear una clase con propiedades y un método simple.
        //Crea la clase Persona con propiedades Nombre, Edad.
        //Agrega un método Saludar() que imprima "Hola, soy {Nombre}".
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public void Saludar()
        {
            Console.WriteLine($"hola, soy {Nombre}");
        }
        public Persona(string Nombre, int Edad)
        {
            this.Nombre = Nombre;
            this.Edad = Edad;
        }
    }
}
