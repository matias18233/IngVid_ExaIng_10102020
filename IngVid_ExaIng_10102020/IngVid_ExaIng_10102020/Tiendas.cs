using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    public class Tiendas {

        Prendas Prenda;

        public Tiendas() {
            Nombre = "Prendas Moda";
            Direccion = "Payró 1941, Godoy Cruz";
            
            Prenda = new Prendas("cargar");
        }

        public string Nombre;
        public string Direccion;

        public void MostrarTienda() {
            Console.WriteLine("Información de la tienda:");
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Dirección: {0}", Direccion);
            Console.WriteLine("");
        }

        public void MostrarListadoPrendas() {
            Prenda.MostrarPrendas();
        }
    }
}
