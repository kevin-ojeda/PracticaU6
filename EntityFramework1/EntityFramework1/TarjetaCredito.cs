namespace EntityFramework1
{
    public class TarjetaCredito
    {
        public int id { get; set; }
        public int numeroTarjeta { get; set; }
        public float limiteCredito { get; set; }
        public float saldoActual { get; set; }
        public Cliente clienteTC { get; set; }
        public EstadoTarjeta estado { get; set; }

        public enum EstadoTarjeta
        {
            Activa,
            Pausada,
            Bloqueada
        }
    }
}
