using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    internal class Ejercicio8
    {
        //Generar 10 números aleatorios entre 1 y 20 sin repetir. Mostrarlos en una lista. 
        public static void Ejecutar()
        {
            Random random = new Random();
            List<int> list = new List<int>();
            list.Add(random.Next(1,21));
            while (true) 
            {
                int nums = random.Next(1, 21);
                int contador = 0;
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != nums)
                        contador++;
                }
                if (contador == list.Count)
                    list.Add(nums);
                if (list.Count == 10)
                    break;
            }
            Console.Write("Los numeros aleatorios son:");
            foreach (int i in list)
                Console.Write($"{i} ");
        }
    }
}
