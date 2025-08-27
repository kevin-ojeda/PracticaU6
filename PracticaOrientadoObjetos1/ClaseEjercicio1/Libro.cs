using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseEjercicio1
{
    public class Libro
    {
        //Clase base Libro con Titulo, Autor, Paginas.
        //Clase LibroDigital hereda de Libro y agrega PesoEnMB y Formato.
        //Crear sus constructores.
        public string titulo {  get; set; }
        public string autor { get; set; }
        public int paginas { get; set; }

        public Libro (string titulo, string autor, int paginas)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.paginas = paginas;
        }
    }
}
