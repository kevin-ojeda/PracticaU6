using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Impresora : IConectable
    {
        public void conectar()
        {
            Console.WriteLine("La impresora se ha conectado");
        }
        public void desconectar()
        {
            Console.WriteLine("La impresora se ha desconectado");
        }
    }
}
