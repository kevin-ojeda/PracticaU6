using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    internal class Ejercicio5
    {
        //Ordenar una lista de enteros usando el algoritmo de burbuja.
        public static void Ejecutar()
        {
            Console.Write("idique cantidad de numeros a ingresar: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] nums = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"ingresar el {i + 1} numero: ");
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < cantidad; i++)
            {
                for (int j = i+1;j < cantidad;j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int aux = nums[j];
                        nums[j] = nums[i];
                        nums[i] = aux;
                    }
                }
            }
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
