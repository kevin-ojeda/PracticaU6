using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pruebas_preparcial1
{
    internal class Prueba4
    {
        //practica del segundo ejercicio del primer parcial.
        public static void Ejecutar()
        {
            int cant;
            while (true)
            {
                Console.WriteLine("ingresar tamaño del arreglo(numero entero)");
                string input = Console.ReadLine();
                if (int.TryParse(input, out cant) && cant > 0)
                    break;
                else if (cant < 0)
                    Console.WriteLine("Error, no se ingreso un numero positivo");
                else
                    Console.WriteLine("Error, valor invalido");
            }
            double[] nums = new double[cant]; 
            for (int i = 0; i < cant; i++)
            {
                while(true)
                {
                    Console.Write($"ingresar el valor de la posicion {i + 1}: ");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double num))
                    { 
                        nums[i] = num;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error; valor invalido");
                    }
                }
            }
            double calculo = 0;
            for (int i = 0;i < cant;i++)
            {
                if (i % 2 == 0)
                {
                    calculo += nums[i];
                }
                else
                {
                    calculo -= (nums[i]*3-1);
                }
            }
            Console.WriteLine(calculo);
        }
    }
}
