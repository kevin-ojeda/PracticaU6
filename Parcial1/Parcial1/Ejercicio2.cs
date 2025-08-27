using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1
{
    internal class Ejercicio2
    {
        //Crear un programa que permita al usuario ingresar las temperaturas diarias de una semana y luego muestre:
        //El promedio de temperaturas, la cantidad de días por encima del promedio
        //la cantidad de días por debajo del promedio. La temperatura se ingresa con coma.
        //En caso que no ingrese un valor válido, mostrar un mensaje de error y pedir nuevamente que ingrese el valor.

        public static void Ejecutar()
        {
            List<double> listaDias = new List<double>();
            for (int i = 0; i < 7; i++)
            {
                while (true)
                {
                    Console.WriteLine($"ingresar la temperatura del dia {i + 1}");
                    string input = Console.ReadLine();
                    if (double.TryParse(input, out double temperatura))
                    {
                        listaDias.Add(temperatura);
                        break;
                    }
                    else
                        Console.WriteLine("error, valor invalio");
                }
            }
            /*
            double suma = 0;
            for(int i = 0; i < listaDias.Count; i++)
            {
                suma += listaDias[i];
            }
            double promedio = suma / 7;
            */
            double promedio = listaDias.Average();
            int pordebajo = 0;
            for (int i = 0;i < 7;i++)
            {
                if (listaDias[i] < promedio)
                    pordebajo++;
            }
            Console.WriteLine($"El promedio de las temperaturas registradas en la semana es: {promedio}");
            Console.WriteLine($"hay {pordebajo} dias por debajo del promedio y {7 - pordebajo} dias por encima del promedio");
        }
    }
}
