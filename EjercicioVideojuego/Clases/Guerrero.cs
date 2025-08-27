using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Guerrero : Personaje
    {
        /*
        Guerrero
        Vida = 150, Ataque = 30, Defensa = 15.
        La vida aumenta 15pts por nivel.
        */
        public Guerrero(string Nombre, int Nivel)
        {
            this.Nombre = Nombre;
            this.Nivel = Nivel;
            Vida = 150 + (Nivel-1) * 15;
            Ataque = 30;
            Defensa = 15;
        }
        public override void Atacar(Personaje objetivo)
        {
            int dano = Ataque - objetivo.Defensa;
            if (dano < 0) 
                dano = 0;

            //DanoInfligidoTotal += dano
            Console.WriteLine($"{Nombre} Le mete la espada a {objetivo.Nombre}, causando {dano} de daño.");
            objetivo.RecibirDano(dano);
        }

        public override void RecibirDano(int cantidad)
        {
            Vida -= cantidad;
            if (Vida < 0) 
                Vida = 0;

            //DanoRecibidoTotal += cantidad;
            Console.WriteLine($"{Nombre} recibió {cantidad} de daño. Vida restante: {Vida}");
        }
    }
}
