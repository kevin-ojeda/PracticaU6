using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Combate
    {
        public string Personaje1 { get; set; }
        public string Personaje2 { get; set; }
        public string Ganador { get; set; }
        public int Turnos { get; set; }

        public List<Combate> ListaCombate { get; set; } = new List<Combate>();
        public static List<Combate> HistorialCombates { get; set; } = new List<Combate>();
        public void RegistrarCombate(Combate combate)
        {
            if (combate != null && !ListaCombate.Contains(combate))
            {
                ListaCombate.Add(combate);
                HistorialCombates.Add(combate);
                Console.WriteLine($"Combate entre {combate.Personaje1} y {combate.Personaje2} registrado correctamente.");
            }
            else
            {
                Console.WriteLine("El combate ya está registrado o es nulo.");
            }
        }
        public void IniciarCombate(Personaje p1, Personaje p2)
        {
            if (p1 == null || p2 == null)
            {
                Console.WriteLine("Uno o ambos personajes son nulos. No se puede iniciar el combate.");
                return;
            }
            Personaje atacante = p1;
            Personaje defensor = p2;
            Turnos = 0;
            while (p1.Vida > 0 && p2.Vida > 0)
            {
                Turnos++;
                atacante.Atacar(defensor);
                if (defensor.Vida <= 0)
                {
                    Ganador = atacante.Nombre;
                    break;
                }
                // Intercambiar roles
                var temp = atacante;
                atacante = defensor;
                defensor = temp;
            }
            RegistrarCombate(new Combate { Personaje1 = p1.Nombre, Personaje2 = p2.Nombre, Ganador = Ganador, Turnos = Turnos });
        }
        public void MostrarHistorialCombates()
        {
            if (HistorialCombates.Count == 0)
            {
                Console.WriteLine("No hay combates registrados.");
                return;
            }
            Console.WriteLine("Historial de Combates:");
            foreach (var combate in HistorialCombates)
            {
                Console.WriteLine($"Combate entre {combate.Personaje1} y {combate.Personaje2}. Ganador: {combate.Ganador}. Turnos: {combate.Turnos}");
            }
        }
        



    }
}
