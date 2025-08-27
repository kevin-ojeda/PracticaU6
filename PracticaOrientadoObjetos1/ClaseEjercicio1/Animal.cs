using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public abstract class Animal
    {
        //Crea una clase abstracta Animal con un método abstracto HacerSonido().
        //Crea clases Perro y Gato que hereden de Animal e implementen HacerSonido().
        //Crear sus constructores.
        public String Nombre { get; set; }
        public abstract void HacerSonido();

        public Animal (string Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
