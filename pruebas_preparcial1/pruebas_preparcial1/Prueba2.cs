using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_preparcial1
{
    internal class Prueba2
    {
        public static void Ejecutar()
        {
            Console.WriteLine("ingresar numeros para calcular su promedio, enter para cortar");
            List<int> lista = new List<int>();
            int b = 0;
            while (true)
            {
                Console.Write($"ingresar el valor numero{b + 1}: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int num) && input != null)
                {
                    lista.Add(num);
                    b++;
                }
                else if (input == "")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("valor invalido");
                }
            }
            lista.Sort();
            foreach (int i in lista)
                Console.WriteLine(i);
            Console.WriteLine($"el promedio es: {lista.Average()}");
        }    
    }
}
