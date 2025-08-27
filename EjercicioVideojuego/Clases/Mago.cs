using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Mago : Personaje
    {
        /*
        Mago
        Vida = 100, Ataque = 50, Defensa = 5.
        La vida aumenta 10pts por nivel.
        */
        public Mago(string Nombre, int Nivel)
        {
            this.Nombre = Nombre;
            this.Nivel = Nivel;
            Vida = 100 + (Nivel - 1) * 10;
            Ataque = 50;
            Defensa = 5;
        }

        public override void Atacar(Personaje objetivo)
        {
            int dano = Ataque - objetivo.Defensa;
            if (dano < 0)
                dano = 0;

            //DanoInfligidoTotal += dano
            Console.WriteLine($"{Nombre} Le tira una bola de fuego a {objetivo.Nombre}, causando {dano} de daño.");
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
