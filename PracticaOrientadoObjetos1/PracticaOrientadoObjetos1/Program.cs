using System.Xml.Linq;
using ClaseEjercicio1;

namespace PracticaOrientadoObjetos1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Persona persona1 = new Persona();
            persona1.Edad = 19;
            persona1.Nombre = "Kevin";
            persona1.Saludar();
            Console.WriteLine(persona1.Edad);
            
            Persona persona2 = new Persona("juani", 20);
            persona2.Saludar();
            Empleado empleado1 = new Empleado("juani", 20, "Petero");
            empleado1.Trabajar();
            */
            Gato gatito = new Gato ("plaga", 4);
            gatito.HacerSonido();
            Perro perrito = new Perro("Taladro", "Golden", 9);
            perrito.HacerSonido();


            //Usa una List<Animal> y agrega varios Perro y Gato.
            //Recorre la lista y llama a HacerSonido() en cada elemento.
            List<Animal> Animales = new List<Animal> 
            {
                new Perro("firulais","Galgazo", 9),
                new Gato("Nevado", 3),
                new Perro("Picante","Labrador", 10),
            };
            foreach (Animal a in Animales)
            {
                a.HacerSonido();
            }

            Rectangulo rectangulito = new Rectangulo(5, 10);
            rectangulito.calculararea();

            ProductoPerecedero producto = new ProductoPerecedero
                ("Chocolate", 100000, new DateTime(2026, 06, 02));
            producto.estavencido();
            DateTime asd = DateTime.Now;
            Console.WriteLine(asd);

            Profesor juani = new Profesor("juani", 46044159, "programacion ");
            juani.Enseñar();
        }
    }
}
