 using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaU7
{
    internal class Ejercicio4
    {
        //Crea una función que reciba un string y devuelve la cantidad de vocales que contiene.
        public static void Ejecutar()
        {
            static int Vocales(string string1)
            {
                char[] vocales = {'a', 'e', 'i', 'o', 'u' };
                int contador = 0;
                for (int i = 0; i < string1.Length; i++)
                {
                    for (int j = 0; j < vocales.Length; j++)
                        if (string1[i] == vocales[j])
                            contador++;
                }
                if (contador > 0)
                    Console.WriteLine($"la cantidad de vocales son: {contador}");
                else
                    Console.WriteLine("no hay vocales");
                return contador;
            }

            Console.Write("ingresar una palabra o frase: ");
            string input = Console.ReadLine();
            Vocales(input);
        }
    }
}
