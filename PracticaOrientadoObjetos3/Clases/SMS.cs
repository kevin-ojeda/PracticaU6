using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class SMS : INotificable
    {
        public void Notificar(string mensaje)
        {
            Console.WriteLine("Se ha enviado el siguiente Mensaje por SMS:");
            Console.WriteLine(mensaje);
        }
    }
}
