using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PracticaU6
{
    internal class Ejercicio2
    {
        //Registrar alumnos en 3 cursos (A, B, C), y luego listar cuántos hay en cada uno.
        public static void Ejecutar()
        {
            List <string> listA = new List<string>();
            List<string> listb = new List<string>();
            List<string> listc = new List<string>();
            int a = 0;
            int b = 0;
            int c = 0;
            bool z = true;
            while (z) 
            {
                Console.Write("indicar curso al que se desea cargar alumnos(A, B, C): ");
                string curso = Console.ReadLine();
                switch (curso)
                {
                    case "A":
                        Console.WriteLine("ingresar nombres, enter para cortar");
                        bool x = true;
                        while (x)
                        {
                            Console.Write("ingresar nombre: ");
                            string nombresA = Console.ReadLine();
                            if (nombresA != null)
                            {
                                listA.Add(nombresA);
                                a++;
                            }
                            else
                                x = false;
                                break;
                        }
                        break;
                    case "B":
                        Console.WriteLine("ingresar nombres, enter para cortar");
                        while (true)
                        {
                            Console.Write("ingresar nombre: ");
                            string nombresB = Console.ReadLine();
                            if (nombresB != null)
                            {
                                listA.Add(nombresB);
                                b++;
                            }
                            else
                                x = false;
                                break;
                        }
                        break;
                    case "C":
                        Console.WriteLine("ingresar nombres, enter para cortar");
                        while (true)
                        {
                            Console.Write("ingresar nombre: ");
                            string nombresC = Console.ReadLine();
                            if (nombresC != null)
                            {
                                listA.Add(nombresC);
                                c++;
                            }
                            else
                                x = false;
                                break;
                        }
                        break;
                }
                Console.WriteLine("desea cargar mas alumnos?");
                string respuesta = Console.ReadLine();
                switch (respuesta)
                {
                    case "si":
                        break;
                    case "no":
                        z = false;
                        break;
                }
            }
        }
    }
}
