using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU7
{
    internal class Ejercicio2
    {
        //Crea una función que reciba una lista de números y devuelve la suma de los mismos.
        public static void Ejecutar()
        {
            static double SumaNumeros(List<double> Numeros)
            {
                double suma = 0;
                foreach (double i in Numeros)
                {
                    suma += i;
                }
                Console.Write($"la suma de los numeros es: {suma}");
                return suma;
            }
            Console.WriteLine("ingresar numeros, 0 para cortar");
            List<double> lista = new List<double>();
            while (true)
            {
                Console.Write("ingresar numero:");
                string input = Console.ReadLine();
                if (double.TryParse(input, out double num))
                {
                    if (num == 0)
                        break;
                    lista.Add(num);
                }
                else
                    Console.WriteLine("valor invalido");
            }
            double resultado = SumaNumeros(lista);
        }
    }
}
