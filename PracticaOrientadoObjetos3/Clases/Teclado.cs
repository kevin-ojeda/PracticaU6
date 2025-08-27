using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Teclado : IConectable
    {
        public void conectar()
        {
            Console.WriteLine("El teclado se ha conectado");
        }
        public void desconectar()
        {
            Console.WriteLine("El teclado se ha desconectado");
        }
    }
}
