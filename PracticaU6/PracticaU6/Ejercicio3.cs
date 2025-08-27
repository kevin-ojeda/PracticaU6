using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    //Verificar si un array de enteros se lee igual de izquierda a derecha que de derecha a izquierda.
    internal class Ejercicio3
    {
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
            int contador = 0;
            int a = cantidad - 1;
            for (int i = 0; i < (cantidad/2); i++)
            {  
                if (nums[i] == nums[a])
                { 
                    contador++;
                    a--;
            }
                }
            if (contador == cantidad / 2)
                Console.WriteLine("el array se lee igual de izquierda a derecha que de derecha a izquierda");
            else
                Console.WriteLine("el array no se lee igual de izquierda a derecha que de derecha a izquierda");
            
        }
    }
}
