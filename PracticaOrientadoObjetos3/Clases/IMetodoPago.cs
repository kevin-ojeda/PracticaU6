using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IMetodoPago
    {
        //Crear una interfaz IMetodoPago con el método Pagar(decimal monto).
        //Implementar las clases TarjetaCredito y TransferenciaBancaria.
        //Crear una lista de métodos de pago y procesar una compra.
        void Pagar(decimal monto);
    }
}
