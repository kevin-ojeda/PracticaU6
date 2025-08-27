using Clases;

namespace OrientadoObjetoSimilParcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Productos Ropa = new Productos();
            Ropa.NombreProducto = "Campera Impermeable";
            Ropa.Precio = 125;
            Ropa.Stock = 5;
            Productos Accesorios = new Productos();
            Accesorios.NombreProducto = "Reloj Rolex Daytona";
            Accesorios.Precio = 10000;
            Accesorios.Stock = 2;
            Productos CosasSimples = new Productos();
            CosasSimples.NombreProducto = "Guantes de lana";
            CosasSimples.Precio = 5;
            CosasSimples.Stock = 18;
            List<Productos> ListaDeProductos = new List<Productos>() {Ropa, Accesorios, CosasSimples};


            Console.WriteLine("¡Bienvenido a la tienda online de Laura!");
            while(true)
            { 
                Console.WriteLine("Selecione su rol:");
                Console.WriteLine("1.Cliente");
                Console.WriteLine("2.Administrador");
                Console.WriteLine("3.Salir");
                int RespuestaRol;

                while (true)
                {
                    string OpcionRol = Console.ReadLine();
                    if (int.TryParse(OpcionRol,out RespuestaRol) && RespuestaRol > 0 && RespuestaRol < 4)
                        break;
                    else
                        Console.WriteLine("Numero o caracter invalido");
                }
                switch (RespuestaRol)
                {
                    case 1:
                        List<Productos> Carrito = new List<Productos>();
                        bool a = true;
                        while (a)
                        {
                            Console.WriteLine("Opciones:");
                            Console.WriteLine("1. Ver productos disponibles.");
                            Console.WriteLine("2. Agregar producto al carrito.");
                            Console.WriteLine("3. Ver carrito.");
                            Console.WriteLine("4. Confirmar compra.");
                            Console.WriteLine("5. Volver al menú principal.");

                            int RespuestaCliente;
                            while (true)
                            {
                                string OpcionCliente = Console.ReadLine();
                                if (int.TryParse(OpcionCliente, out RespuestaCliente) && RespuestaCliente > 0 && RespuestaCliente < 6)
                                    break;
                                else
                                    Console.WriteLine("Número o carácter inválido");
                            }

                            switch (RespuestaCliente)
                            {
                                case 1:
                                    Console.WriteLine("Productos disponibles:");
                                    foreach (var producto in ListaDeProductos)
                                        producto.MostrarProducto();
                                    break;

                                case 2:
                                    Console.Write("Ingresar producto que desea guardar en el carrito: ");
                                    string SeleccionProducto = Console.ReadLine();
                                    foreach (var producto in ListaDeProductos)
                                    {
                                        if (producto.NombreProducto == SeleccionProducto)
                                        {
                                            Console.Write("Cantidad: ");
                                            int RespuestaCantidad;
                                            while (true)
                                            {
                                                string CantidadSeleccionada = Console.ReadLine();
                                                if (int.TryParse(CantidadSeleccionada, out RespuestaCantidad) && RespuestaCantidad > 0)
                                                {
                                                    if(producto.Stock > 0)
                                                    {
                                                        Productos productoCarrito = new Productos()
                                                        {
                                                            NombreProducto = producto.NombreProducto,
                                                            Precio = producto.Precio,
                                                            Stock = RespuestaCantidad
                                                        };
                                                    }
                                                    break;
                                                }
                                                else
                                                    Console.WriteLine("Número o carácter inválido");
                                            }
                                        }

                                    }
                                    break;
                                case 3:
                                    if (Carrito.Count == 0)
                                    {
                                        Console.WriteLine("Tu carrito está vacío.");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Carrito:");
                                        foreach (var item in Carrito)
                                        {
                                            Console.WriteLine($"{item.NombreProducto} - {item.Stock} unidades - ${item.Precio * item.Stock}");
                                        }
                                    }
                                    break;
                                case 4:
                                    // ConfirmarCompra(); // Aquí deberías implementar la lógica para confirmar la compra
                                    break;
                                case 5:
                                    a = false;
                                    break; // Sale del menú del cliente y vuelve al menú principal
                            }
                        }
                        break;
                }
            }
        }
    }
}
