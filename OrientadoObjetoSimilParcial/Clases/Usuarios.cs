using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Usuarios
    {
        //Quiero que haya dos tipos de usuarios: los clientes, que compran, y
        //los administradores, que manejamos el stock.
        public virtual void TipoUsuario()
        {
            Console.WriteLine("No se a seleccionado un tipo de usuario especifico.");
        }
        public string nombre { get; set; }
        public int dni { get; set; }

        public Usuarios(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
    }
}
