using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Empleado : Persona
    {
        
        
        //Crea una clase Empleado que herede de Persona.
        //Añade la propiedad Puesto y un método Trabajar() que imprima qué hace.
        public string Puesto { get; set; }

        public void Trabajar()
        {
            Console.WriteLine($"El empleado {Nombre} trabaja de {Puesto}");
        }
        public Empleado(string nombre, int edad, string puesto) : base(nombre, edad)
        {
           this.Puesto = puesto;
        }
    }
}
