using Clases;

namespace EjercicioVideojuego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salirr = true;
            bool salir = true;
            while (salir)
            {
                Console.WriteLine("===== MENÚ PRINCIPAL =====");
                Console.WriteLine("1 - Registrar personajes (Guerrero, Mago, Arquero)");
                Console.WriteLine("2 - Ver lista de personajes creados");
                Console.WriteLine("3 - Iniciar un combate entre dos personajes");
                Console.WriteLine("4 - Ver historial de combates");
                Console.WriteLine("5 - Ver estadísticas globales de cada personaje");
                Console.WriteLine("6 - Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        while (salirr)
                        {
                            Console.WriteLine("===== REGISTRO DE PERSONAJES =====");
                            Console.WriteLine("Seleccione el tipo de personaje a registrar:");
                            Console.WriteLine("1 - Guerrero");
                            Console.WriteLine("2 - Mago");
                            Console.WriteLine("3 - Arquero");
                            Console.WriteLine("4 - Volver al menú principal");
                            string tipoPersonaje = Console.ReadLine();
                            if (tipoPersonaje == "4")
                            {
                                salirr = false;
                                break;
                            }
                            Console.Write("Ingrese el nombre del personaje: ");
                            string nombre = Console.ReadLine();
                            Console.Write("Ingrese el nivel del personaje (1-100): ");
                            string nivelInput = Console.ReadLine();
                            int nivel;
                            while (!int.TryParse(nivelInput, out nivel) || nivel < 1 || nivel > 100)
                            {
                                Console.Write("Nivel inválido. Ingrese un nivel entre 1 y 100: ");
                                nivelInput = Console.ReadLine();
                            }
                            Personaje personaje = null;
                            switch (tipoPersonaje)
                            {
                                case "1":
                                    personaje = new Guerrero(nombre, nivel);
                                    break;
                                case "2":
                                    personaje = new Mago(nombre, nivel);
                                    break;
                                case "3":
                                    personaje = new Arquero(nombre, nivel);
                                    break;
                                default:
                                    Console.WriteLine("Tipo de personaje no válido. Intente nuevamente.");
                                    continue;
                            }
                            personaje.RegistrarPersonaje(personaje);
                        }
                        break;

                    case "2":
                        Console.WriteLine("Opción 2: Ver lista de personajes creados.");
                        if (Personaje.ListaPersonajes.Count == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Lista de personajes registrados:");
                            foreach (var p in Personaje.ListaPersonajes)
                            {
                                Console.WriteLine($"Nombre: {p.Nombre}, Nivel: {p.Nivel}, Vida: {p.Vida}, Ataque: {p.Ataque}, Defensa: {p.Defensa}");
                            }
                        }
                        break;

                    case "3":
                        Console.WriteLine("Opción 3: Iniciar un combate entre dos personajes.");
                        if (Personaje.ListaPersonajes.Count < 2)
                        {
                            Console.WriteLine("No hay suficientes personajes registrados para iniciar un combate.");
                            break;
                        }
                        Console.WriteLine("Seleccione el primer personaje:");
                        for (int i = 0; i < Personaje.ListaPersonajes.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - {Personaje.ListaPersonajes[i].Nombre}");
                        }
                        int index1 = int.Parse(Console.ReadLine()) - 1;
                        if (index1 < 0 || index1 >= Personaje.ListaPersonajes.Count)
                        {
                            Console.WriteLine("Índice no válido. Intente nuevamente.");
                            break;
                        }
                        Personaje personaje1 = Personaje.ListaPersonajes[index1];
                        Console.WriteLine("Seleccione el segundo personaje:");
                        for (int i = 0; i < Personaje.ListaPersonajes.Count; i++)
                        {
                            if (i == index1) continue; // Evitar seleccionar el mismo personaje
                            Console.WriteLine($"{i + 1} - {Personaje.ListaPersonajes[i].Nombre}");
                        }
                        int index2 = int.Parse(Console.ReadLine()) - 1;
                        if (index2 < 0 || index2 >= Personaje.ListaPersonajes.Count || index2 == index1)
                        {
                            Console.WriteLine("Índice no válido. Intente nuevamente.");
                            break;
                        }
                        Personaje personaje2 = Personaje.ListaPersonajes[index2];
                        Combate combate = new Combate();
                        combate.IniciarCombate(personaje1, personaje2);
                        Console.WriteLine($"Combate iniciado entre {personaje1.Nombre} y {personaje2.Nombre}.");
                        Console.WriteLine($"Ganador: {combate.Ganador}, Turnos: {combate.Turnos}");
                        combate.RegistrarCombate(combate);

                        break;

                    case "4":
                        Console.WriteLine("Opción 4: Ver historial de combates.");
                        if (Combate.HistorialCombates.Count == 0)
                        {
                            Console.WriteLine("No hay combates registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Historial de Combates:");
                            foreach (var c in Combate.HistorialCombates)
                            {
                                Console.WriteLine($"Combate entre {c.Personaje1} y {c.Personaje2}, Ganador: {c.Ganador}, Turnos: {c.Turnos}");
                            }
                        }
                        break;

                    case "5":
                        Console.WriteLine("Opción 5: Ver estadísticas globales de cada personaje.");
                        if (Personaje.ListaPersonajes.Count == 0)
                        {
                            Console.WriteLine("No hay personajes registrados.");
                        }
                        else
                        {
                            Console.WriteLine("Estadísticas de personajes:");
                            foreach (var p in Personaje.ListaPersonajes)
                            {
                                Console.WriteLine($"Nombre: {p.Nombre}, Nivel: {p.Nivel}, Vida: {p.Vida}, Ataque: {p.Ataque}, Defensa: {p.Defensa}");
                            }
                        }
                        break;

                    case "6":
                        Console.WriteLine("Saliendo del programa...");
                        salir = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente nuevamente.");
                        break;
                }

                Console.WriteLine();
            }
        }
    }
}
