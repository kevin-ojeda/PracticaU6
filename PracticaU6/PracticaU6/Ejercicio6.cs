using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    internal class Ejercicio6
    {
        //Rotar los elementos de un array una posición a la derecha.
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

            /* 
            for (int i = 0; i < cantidad-1; i++) //(asi es al reves)
            {
                int aux = nums[i + 1];
                nums[i + 1] = nums[i];
                nums[i] = aux;
            }
            */

            for (int i = cantidad - 1; i > 0 ; i--)
            {
                int aux = nums[i - 1];
                nums[i - 1] = nums[i];
                nums[i] = aux;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write($"{nums[i]} ");
            }
        }
    }
}
