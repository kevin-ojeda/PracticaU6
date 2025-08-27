using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU7
{
    internal class Ejercicio1
    {
        //Crea una función que reciba 2 números y los sume.
        public static void Ejecutar()
        {
            static double suma(double num1, double num2)
            {
                double suma = num1 + num2;
                Console.WriteLine(suma);
                return suma;
            }
            suma(45, 55);
        }
    }
}
