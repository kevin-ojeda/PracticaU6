using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Vehiculo
    {

        public string tipo {  get; set; }
        public string placa {  get; set; }
        public int kilometraje { get; set; }
        public int capacidadPasajeros {  get; set; }
        public List<Viaje> ListaViajes { get; set; } = new List<Viaje>();
        public void agregarviaje(Viaje viajeAgregar)
        {
            ListaViajes.Add(viajeAgregar);
        }
        public void MostrarCantidadViajes()
        {
            Console.WriteLine($"Viajes: {ListaViajes.Count}.");
        }
        public static string PatenteUnica(List<Vehiculo> lista)
        {
            while (true)
            {
                Console.Write("Ingresar patente de vehículo: ");
                string patente = Console.ReadLine();
                bool existe = false;
                foreach (Vehiculo v in lista)
                {
                    if (v.placa == patente)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                    Console.WriteLine("Ya existe un vehículo con esa patente, ingrese otra.");
                else
                    return patente;
            }
        }
        
    }
}
