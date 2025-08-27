using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Generador
    {
        public int IdEquipo { get ; set; } = 0;
        public int IdPartido { get; set; } = 0;
        public int IdTorneo { get; set; } = 0;

        public int GetNextIdEquipo()
        {
            return ++IdEquipo;
        }
        public int GetNextIdPartido()
        {
            return ++IdPartido;
        }
        public int GetNextIdTorneo()
        {
            return ++IdTorneo;
        }
    }
}
