using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_preparcial1
{
    internal class Prueba3
    {
        //practica del primer ejercicio del primer parcial.
        public static void Ejecutar()
        {
            List<int> lista = new List<int>();
            int a = 0;
            Console.WriteLine("ingresar numeros, 0 para cortar");
            while (true)
            {
                Console.Write($"ingresar el valor de la posicion {a+1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int nums) && nums != 0)
                {
                    lista.Add(nums);
                    a++;
                }
                else if (int.TryParse(input, out nums) && nums == 0) 
                {
                    break;
                }
                else
                {
                    Console.WriteLine("valor invalido");
                }
            }
            List<int> ImparesOrdenados = lista.Where(x => x % 2 != 0).OrderByDescending(x => x).ToList();
            foreach (int i in ImparesOrdenados)
                Console.WriteLine(i);
        }
    }
}
