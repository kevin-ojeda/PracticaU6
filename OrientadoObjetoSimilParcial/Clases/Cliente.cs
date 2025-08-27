using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cliente : Usuarios
    {
        public void MostrarProductos()
        {
            Console.WriteLine($"Los productos que se encuentran disponibles son:");
            Console.WriteLine($"");
        }
        





        public Cliente(string nombre,int dni) : base(nombre,dni) { }
    }
}
