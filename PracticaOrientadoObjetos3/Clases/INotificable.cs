using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface INotificable
    {
        //Crear una interfaz INotificable con método Notificar(string mensaje).
        //Implementar Email, SMS, PushNotification.
        void Notificar(string mensaje);
    }
}
