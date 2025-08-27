using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Animal
    {
        //Crear una clase abstracta Animal con el método movilidad().
        //Derivar a Leon, Paloma y Pez. Mostrar cómo se mueve cada uno usando polimorfismo.
        public virtual void Movilidad()
        {
            Console.WriteLine("El animal se esta moviendo.");
        }

    }
}
