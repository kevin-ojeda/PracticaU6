using System.Collections.Generic;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using Clases;

namespace Sistema_Gestion_de_Viajes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> ListaVehiculos = new List<Vehiculo>();
            List<Viaje> ListaViajes = new List<Viaje>();


            while (true)
            {
                Console.WriteLine("\nSelecciona una opción:");
                Console.WriteLine("1 - Agregar Vehiculo");
                Console.WriteLine("2 - Registrar un viaje para un vehículo");
                Console.WriteLine("3 - Mostrar información de un vehículo.");
                Console.WriteLine("4 - Mostrar todos los vehículos y estadísticas generales.");
                Console.WriteLine("0 - Salir");

                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Por favor ingresa un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        AgregarVehiculo(ListaVehiculos);
                        break;
                    case 2:
                        RegistrarViaje(ListaVehiculos);
                        break;
                    case 3:
                        Console.WriteLine("3 - Mostrar información de un vehículo.");
                        Console.Write("Ingresar patente de vehículo: ");
                        string patente = Console.ReadLine();
                        Vehiculo vehiculoEncontrado = null;
                        foreach (Vehiculo v in ListaVehiculos)
                        {
                            if (v.placa == patente)
                            {
                                vehiculoEncontrado = v;
                                break;
                            }
                        }
                        if (vehiculoEncontrado != null)
                        {
                            Console.WriteLine($"Vehículo encontrado: {vehiculoEncontrado.tipo}");
                            Console.WriteLine($"patente {vehiculoEncontrado.placa}");
                            Console.WriteLine($"kilometraje: {vehiculoEncontrado.kilometraje}");
                            Console.WriteLine($"");
                            vehiculoEncontrado.MostrarCantidadViajes();
                            if (vehiculoEncontrado.ListaViajes.Count > 0)
                            {
                                Console.WriteLine("Detalles de los viajes:");
                                foreach (Viaje viaje in vehiculoEncontrado.ListaViajes)
                                {
                                    Console.WriteLine($"Fecha: {viaje.fecha.ToShortDateString()}, Distancia: {viaje.distancia} km, Carga transportada: {viaje.cargaTransportada} kg");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("❌ No se encontró un vehículo con esa patente.");
                        }
                        break;
                    case 4:
                        MostrarVehiculos(ListaVehiculos);
                        break;
                    case 0:
                        Console.WriteLine("Saliendo...");
                        return;
                    default:
                        Console.WriteLine("Opción inválida, intenta de nuevo.");
                        break;
                }
            }

        }   

        static void AgregarVehiculo(List<Vehiculo> ListaVehiculo)
        {
            Console.WriteLine("1 - Agregar Camion");
            Console.WriteLine("2 - Agregar Furgoneta");
            Console.WriteLine("3 - Agregar Moto");
            int opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Console.Write("ingresar capacidad adicional: ");
                int capacidadAdicional = int.Parse(Console.ReadLine());
                string patente = Vehiculo.PatenteUnica(ListaVehiculo);
                Console.Write("ingresar kilometraje: ");
                int kilometraje = int.Parse(Console.ReadLine());
                Camion camion = new Camion(capacidadAdicional, patente, kilometraje);
                ListaVehiculo.Add(camion);
            }
            if (opcion == 2)
            {
                Console.Write("ingresar capacidad adicional: ");
                int capacidadAdicional = int.Parse(Console.ReadLine());
                string patente = Vehiculo.PatenteUnica(ListaVehiculo);
                Console.Write("ingresar kilometraje: ");
                int kilometraje = int.Parse(Console.ReadLine());
                Furgoneta furgoneta = new Furgoneta(capacidadAdicional, patente, kilometraje);
                ListaVehiculo.Add(furgoneta);
            }
            if (opcion == 3)
            {
                string patente = Vehiculo.PatenteUnica(ListaVehiculo);
                Console.Write("ingresar kilometraje: ");
                int kilometraje = int.Parse(Console.ReadLine());
                Moto moto = new Moto(patente, kilometraje);
                ListaVehiculo.Add(moto);
            }
        }



        static void MostrarVehiculos(List<Vehiculo> lista)
        {
            foreach (Vehiculo Vehiculos in lista)
            {
                Console.WriteLine($"{Vehiculos.tipo} patente {Vehiculos.placa}, kilometraje: {Vehiculos.kilometraje}, viajes: {Vehiculos.MostrarCantidadViajes}");
            }
        }



        static void RegistrarViaje(List<Vehiculo> lista)
        {
            Console.Write("Ingresar patente de vehiculo: ");
            string patente = Console.ReadLine();
            Vehiculo vehiculoEncontrado = null;
            foreach (Vehiculo v in lista)
            {
                if (v.placa == patente)
                {
                    vehiculoEncontrado = v;
                    break;
                }
            }

           
            if (vehiculoEncontrado == null)
            {
                Console.WriteLine("❌ No se encontró un vehículo con esa patente.");
                return;
            }
            Console.Write("Fecha del viaje (dd/MM/yyyy): ");
            DateTime fecha = DateTime.Parse(Console.ReadLine());
            Console.Write("Distancia recorrida: ");
            int distancia = int.Parse(Console.ReadLine());
            int cargaTransportada = 0;
            if (vehiculoEncontrado is Camion || vehiculoEncontrado is Furgoneta)
            {
                Console.Write("Carga transportada: ");
                cargaTransportada = int.Parse(Console.ReadLine());
            }
            Viaje viaje = new Viaje(distancia, cargaTransportada, fecha);
            vehiculoEncontrado.agregarviaje(viaje);

            Console.WriteLine("Viaje registrado para " + vehiculoEncontrado.placa);
        }
        
        
        

    }
}
