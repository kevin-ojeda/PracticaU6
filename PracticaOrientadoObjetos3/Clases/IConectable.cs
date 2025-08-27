using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IConectable
    {
        //Crear una interfaz IConectable con métodos Conectar() y Desconectar().
        //Implementar Impresora, Teclado y Monitor.
        void conectar();
        void desconectar();
    }
}
