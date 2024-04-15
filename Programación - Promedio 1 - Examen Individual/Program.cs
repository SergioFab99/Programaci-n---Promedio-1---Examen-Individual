using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programación___Promedio_1___Examen_Individual
{

    class Program
    {
        static void Main(string[] args)
        {
            CarritoCompras carrito = new CarritoCompras();

            // Agregar productos iniciales al carrito
            carrito.agregarProducto(new ProductoTela("Bufanda", "Mediana", new Material("Lana"), "Rojo", 20.5));
            carrito.agregarProducto(new ProductoTela("Mantel", "Grande", new Material("Algodón"), "Azul", 35.75));
            carrito.agregarProducto(new ProductoArcilla("Maceta", 1.5, "Pequeña", "Terracota", 15.25));
            carrito.agregarProducto(new ProductoArcilla("Figura decorativa", 0.8, "Pequeña", "Blanco", 10.0));

            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("¿Qué desea hacer?");
                Console.WriteLine("1. Agregar producto");
                Console.WriteLine("2. Ver contenido del carrito");
                Console.WriteLine("3. Finalizar compra");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Seleccione el tipo de producto:");
                        Console.WriteLine("1. Producto de tela");
                        Console.WriteLine("2. Producto de arcilla");
                        int tipoProducto = int.Parse(Console.ReadLine());
                        if (tipoProducto == 1)
                        {
                            // Crear y agregar un producto de tela al carrito
                            Console.WriteLine("Ingrese el nombre:");
                            string nombreTela = Console.ReadLine();
                            Console.WriteLine("Ingrese el tamaño:");
                            string tamañoTela = Console.ReadLine();
                            Console.WriteLine("Ingrese el material:");
                            string materialTela = Console.ReadLine();
                            Console.WriteLine("Ingrese el color:");
                            string colorTela = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio:");
                            double precioTela = double.Parse(Console.ReadLine());

                            Material material = new Material(materialTela);
                            ProductoTela productoTela = new ProductoTela(nombreTela, tamañoTela, material, colorTela, precioTela);
                            carrito.agregarProducto(productoTela);
                        }
                        else if (tipoProducto == 2)
                        {
                            // Crear y agregar un producto de arcilla al carrito
                            Console.WriteLine("Ingrese el nombre:");
                            string nombreArcilla = Console.ReadLine();
                            Console.WriteLine("Ingrese el peso:");
                            double pesoArcilla = double.Parse(Console.ReadLine());
                            Console.WriteLine("Ingrese el tamaño:");
                            string tamañoArcilla = Console.ReadLine();
                            Console.WriteLine("Ingrese el color:");
                            string colorArcilla = Console.ReadLine();
                            Console.WriteLine("Ingrese el precio:");
                            double precioArcilla = double.Parse(Console.ReadLine());

                            ProductoArcilla productoArcilla = new ProductoArcilla(nombreArcilla, pesoArcilla, tamañoArcilla, colorArcilla, precioArcilla);
                            carrito.agregarProducto(productoArcilla);
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida");
                        }
                        break;
                    case 2:
                        // Mostrar contenido del carrito
                        Console.WriteLine("Contenido del carrito:");
                        foreach (object producto in carrito.listaProductos)
                        {
                            if (producto is ProductoTela)
                            {
                                ProductoTela tela = (ProductoTela)producto;
                                Console.WriteLine($"{tela.getCaracteristicas()}, Precio: {tela.getPrecio()}");
                            }
                            else if (producto is ProductoArcilla)
                            {
                                ProductoArcilla arcilla = (ProductoArcilla)producto;
                                Console.WriteLine($"{arcilla.getCaracteristicas()}, Precio: {arcilla.getPrecio()}");
                            }
                        }
                        break;
                    case 3:
                        // Finalizar compra
                        Console.WriteLine("Productos comprados:");
                        foreach (object producto in carrito.listaProductos)
                        {
                            if (producto is ProductoTela)
                            {
                                ProductoTela tela = (ProductoTela)producto;
                                Console.WriteLine($"{tela.getCaracteristicas()}, Precio: {tela.getPrecio()}");
                            }
                            else if (producto is ProductoArcilla)
                            {
                                ProductoArcilla arcilla = (ProductoArcilla)producto;
                                Console.WriteLine($"{arcilla.getCaracteristicas()}, Precio: {arcilla.getPrecio()}");
                            }
                        }
                        Console.WriteLine($"Precio total: {carrito.calcularPrecioTotal()}");
                        Console.WriteLine("¿Desea crear un nuevo carrito de compras?");
                        Console.WriteLine("1. Sí");
                        Console.WriteLine("2. No");
                        int opcionNuevoCarrito = int.Parse(Console.ReadLine());
                        if (opcionNuevoCarrito == 1)
                        {
                            carrito = new CarritoCompras();
                        }
                        else
                        {
                            salir = true;
                        }
                        break;
                    case 4:
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        break;
                }
            }
        }
    }
}
