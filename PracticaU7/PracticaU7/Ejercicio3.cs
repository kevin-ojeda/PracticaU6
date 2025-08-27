using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU7
{
    internal class Ejercicio3
    {
        //Crea una función que reciba 2 números y devuelva su multiplicación.
        public static void Ejecutar()
        {
            static double multiplicarNums(double num1, double num2)
            {
                double resultado = num1 * num2;
                Console.WriteLine($"La multiplicacion da: {resultado}");
                return resultado;
            }
            Console.WriteLine("ingresar dos numeros para multiplicar: ");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            multiplicarNums(num1, num2);
        }
    }
}
