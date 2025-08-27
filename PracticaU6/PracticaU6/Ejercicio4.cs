using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    //Eliminar los valores duplicados de una lista.
    internal class Ejercicio4
    {
        public static void Ejecutar()
        {
            List<int> lista = new List<int>();
            Console.WriteLine("ingresar numeros, 0 para cortar");
            while (true)
            {
                Console.Write("ingresar numero: ");
                int nums = int.Parse(Console.ReadLine());
                lista.Add(nums);
                if (nums == 0)
                    break;
            }
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int j = i + 1; j < lista.Count; j++)
                {
                    if (lista[i] == lista[j] && i != j)
                    {
                        lista.RemoveAt(j);
                    }

                }
            }
            Console.WriteLine("se eliminaron los duplicados:");
            foreach (int i in lista)
                Console.Write($"{i} ");
        }
    }
}
