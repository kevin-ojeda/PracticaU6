using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PracticaU7
{
    internal class Program
    {
        //Crea una función que reciba 2 números y los sume.
        static double suma(double num1, double num2)
        {
            double suma = num1 + num2;
            Console.WriteLine(suma);
            return suma;
        }
        //Crea una función que reciba una lista de números y devuelve la suma de los mismos.
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
        //Crea una función que reciba 2 números y devuelva su multiplicación.
        static double multiplicarNums(double num1, double num2)
        {
            double resultado = num1 * num2;
            Console.WriteLine($"La multiplicacion da: {resultado}");
            return resultado;
        }
        //Crea una función que reciba un string y devuelve la cantidad de vocales que contiene.
        static int Vocales(string string1)
        {
            char[] vocales = { 'A', 'E', 'I', 'O', 'U' };
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
        //Crea una función que reciba un texto con varias palabras separadas por espacios y devuelve la palabra más larga.
        static string PalabraMasLarga(string texto)
        {
            string[] palabras = texto.Split(' ');
            List<string> palabrasLimpias = new List<string>();
            foreach (string palabra in palabras)
            {
                string limpia = new string(palabra.Where(char.IsLetterOrDigit).ToArray());
                palabrasLimpias.Add(limpia);
            }
            int a = 0;
            string MasLarga = "asd";
            for (int i = 0; i < palabrasLimpias.Count; i++)
            {
                if (palabrasLimpias[i].Length > a)
                { 
                    MasLarga = palabrasLimpias[i];
                    a = palabrasLimpias[i].Length;
                }
            }
            Console.WriteLine($"la palabra mas larga es: {MasLarga}");
            return MasLarga;
        }
        //Crea una función que reciba un número entero y devuelve la suma de sus dígitos.
        static int SumarDigitors(string num)
        {
            int suma = 0;
            for (int i = 0;i < num.Length;i++)
            {
                int nums = int.Parse(num[i].ToString());
                suma += nums;
            }
            Console.WriteLine($"la suma de los digitos da: {suma}");
            return suma;
        }




        static void Main(string[] args)
        {
            string asd = Console.ReadLine();
            SumarDigitors(asd);
        }
    
    }
}
