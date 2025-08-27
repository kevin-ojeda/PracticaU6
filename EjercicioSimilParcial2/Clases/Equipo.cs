using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Equipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; } 

        public Listv <Partido> HistorialPartido { get; set; }
    }
}
