using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Administradores : Usuarios
    {
        public override void TipoUsuario()
        {
            Console.WriteLine("El tipo de usuario que se esta ejecutando es de tipo administrador.");
        }
        public void AñadirStock(Productos ProductoAgregar)
        {
            Console.WriteLine("Ingrese la cantidad del producto:");
            int CantidadDeStock = int.Parse(Console.ReadLine());
            ProductoAgregar.Stock = CantidadDeStock;
        }
        public void AñadirProducto(Productos NombreProducto)
        {
            Console.WriteLine("Ingrese la cantidad del producto:");
            string NuevoProducto = Console.ReadLine();
            NombreProducto.NombreProducto = NuevoProducto;
        }
        public int IdAdministrador {  get; set; }
        public Administradores(string nombre, int dni, int IdAdministrador) : base (nombre,dni)
        {
            this.IdAdministrador = IdAdministrador;
        }

    }
}
