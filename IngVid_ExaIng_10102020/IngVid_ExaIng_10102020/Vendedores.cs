using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    public class Vendedores {
        
        public Vendedores() {
            Nombre = "Fernando Matías";
            Apellido = "Cruz";
            CodVendedor = 1;
        }

        public string Nombre;
        public string Apellido;
        public int CodVendedor;

        public void MostrarVendedor() {
            Console.WriteLine("Información del vendedor:");
            Console.WriteLine("Código de vendedor: {0}", CodVendedor);
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Apellido: {0}", Apellido);
            Console.WriteLine("");
        }
    }
}
