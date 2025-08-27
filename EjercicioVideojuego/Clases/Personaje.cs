using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public abstract class Personaje
    {
        //Nombre, Nivel, Vida, Ataque, Defensa.
        public string Nombre { get; set; }
        public int Nivel { get; set; }
        public int Vida { get; set; }
        public int Ataque { get; set; }
        public int Defensa { get; set; }
        public static List<Personaje> ListaPersonajes { get; set; } = new List<Personaje>();
        public abstract void Atacar(Personaje objetivo);
        public abstract void RecibirDano(int cantidad);

        public void RegistrarPersonaje(Personaje personaje)
        {
            if (personaje != null && !ListaPersonajes.Contains(personaje))
            {
                ListaPersonajes.Add(personaje);
                Console.WriteLine($"Personaje {personaje.Nombre} registrado correctamente.");
            }
            else
            {
                Console.WriteLine("El personaje ya está registrado o es nulo.");
            }
        }
        

    }
}
