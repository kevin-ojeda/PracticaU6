using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Partido
    {
        public int Id { get; set; }
        public Equipo Local { get; set; }
        public Equipo Visitante { get; set; }
    }
}
