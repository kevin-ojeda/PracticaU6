using Clases;

namespace PracticaOrientadoObjetos3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IConectable> conectables = new List<IConectable>()
            {
                new Teclado(),
                new Impresora()
            }; 
            foreach (IConectable conectable in conectables)
            {
                conectable.conectar();
                conectable.desconectar();
            }
        }
    }
}
