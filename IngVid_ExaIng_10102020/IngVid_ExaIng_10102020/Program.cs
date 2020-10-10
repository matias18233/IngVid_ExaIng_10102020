using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    class Program {
        static void Main(string[] args) {
            bool control = true; // control de menú
            string cadena; // opción seleccionada

            Vendedores Vendedor = new Vendedores();

            Tiendas Tienda = new Tiendas();
            
            Console.WriteLine("Bienvenido al sistema de cotizaciones.");
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Usuario actual: {0}, {1}", Vendedor.Nombre, Vendedor.Apellido);
            Console.WriteLine("--------------------------------------");

            while (control == true) {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("a . Mostrar información del usuario");
                Console.WriteLine("b . Mostrar información de la tienda");
                Console.WriteLine("c . Mostrar listado de prendas");
                Console.WriteLine("d . Realizar una nueva cotización");
                Console.WriteLine("e . Mostrar historial de cotizaciones");
                Console.WriteLine("f . Salir del sistema");
                cadena = Console.ReadLine();
                switch (cadena) {
                    case "a":
                        Vendedor.MostrarVendedor();
                        break;
                    case "b":
                        Tienda.MostrarTienda();
                        break;
                    case "c":
                        Tienda.MostrarListadoPrendas();
                        break;
                    case "d":

                        break;
                    case "e":

                        break;
                    case "f":
                        control = false;
                        break;
                    default:
                        Console.WriteLine("");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
