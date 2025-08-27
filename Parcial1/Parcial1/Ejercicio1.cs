using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Ejercicio1
    {
        //Crear un programa que genere números aleatorios entre 0 y 100
        //y los almacene en una lista hasta que se genere un número mayor a 98
        //. Luego encuentre el número más grande sin ordenar la lista.

        public static void Ejecutar()
        {
            List<int> lista = new List<int>();
            while (true)
            {
                int numerorandom = new Random().Next(0, 101);
                if (numerorandom > 98)
                    break;
                else
                    lista.Add(numerorandom);
            }
            int mayor = 0;
            for (int i = 0;i < lista.Count; i++)
            {
                if (lista[i] > mayor)
                    mayor = lista[i];
            }
            Console.WriteLine($"el numero aleatorio mas grande es: { mayor} ");
        }
    }
}
