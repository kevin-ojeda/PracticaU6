using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_preparcial1
{
    internal class Prueba1
    {
        public static void Ejecutar()
        {
            int cant;
            Console.WriteLine("ingresar tamaño del arreglo:");
            while (true)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out cant))
                {
                    //Console.WriteLine("tamaño de arreglo valido");
                    break;
                }
                else
                {
                    Console.WriteLine("tamaño de arreglo invalido");
                }
            }
            int[] arreglo = new int [cant];
            for (int i = 0; i < cant; i++)
            {
                while (true)
                {
                    Console.Write($"ingresar el numero de la posicion {i+1}: ");
                    string input2 = Console.ReadLine();
                    if (int.TryParse(input2, out int nums))
                    {
                        arreglo[i] = nums;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("ingresaste una letra");
                    }
                }
            }
            for (int i = 0;i < cant;i++)
                Console.WriteLine(arreglo[i]);

        }
    }
}
