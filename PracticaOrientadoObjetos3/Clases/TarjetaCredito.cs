using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class TarjetaCredito : IMetodoPago
    {
        public void Pagar(decimal Monto)
        {
            Console.WriteLine($"El pago se realizo con una tarjeta de credito a nombre de {TitularTarjeta}");
            Console.WriteLine($"Monto: {Monto}");
        }
        public float Monto { get; set; }
        public int NumeroTarjeta{ get; set; }
        public string TitularTarjeta { get; set; }
        public int PinTarjeta { get; set; }
        
        public TarjetaCredito(float Monto, int NumeroTarjeta,string TitularTarjeta,int PinTarjeta)
        { 
            this.Monto = Monto;
            this.NumeroTarjeta = NumeroTarjeta;
            this.TitularTarjeta = TitularTarjeta;
            this.PinTarjeta = PinTarjeta;
        }
    }
}
