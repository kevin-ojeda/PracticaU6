using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class PersonaNueva
    {
        //Persona tiene Nombre, DNI. Estudiante tiene Legajo y método Estudiar().
        //Profesor tiene Materia y método Enseñar().Crear sus constructores.
        public string Nombreee { get; set; }
        public int DNI { get; set; }
        public PersonaNueva (string Nombreee, int DNI)
        {
            this.Nombreee = Nombreee;
            this.DNI = DNI;
        }
        
    }
}
