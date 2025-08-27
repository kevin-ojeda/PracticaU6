using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Monitor : IConectable
    {
        public void conectar()
        {
            Console.WriteLine("El monitor se ha conectado");
        }
        public void desconectar()
        {
            Console.WriteLine("El monitor se ha desconectado");
        }
    }
}
