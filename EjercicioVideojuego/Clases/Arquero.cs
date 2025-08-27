using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arquero : Personaje
    {
        /*
        Arquero
        Vida = 120, Ataque = 25, Defensa = 10 (tiene un 25% de probabilidad de infligir el doble de daño).
        La vida aumenta 12pts por nivel.

        */
        public Arquero(string Nombre, int Nivel)
        {
            this.Nombre = Nombre;
            this.Nivel = Nivel;
            Vida = 120 + (Nivel - 1) * 12;
            Ataque = 25;
            Defensa = 10;
        }

        //(tiene un 25% de probabilidad de infligir el doble de daño).
        public override void Atacar(Personaje objetivo)
        {
            int dano;
            Random random = new Random();
            int numeroran = random.Next(1, 101);
            if (numeroran >= 25)
                dano = Ataque * 2 - objetivo.Defensa;
            else
                dano = Ataque - objetivo.Defensa;
            if (dano < 0)
                dano = 0;

            //DanoInfligidoTotal += dano
            Console.WriteLine($"{Nombre} Le tira un flechaso a {objetivo.Nombre}, causando {dano} de daño.");
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
