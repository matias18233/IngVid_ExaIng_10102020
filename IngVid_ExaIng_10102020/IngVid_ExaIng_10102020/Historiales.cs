using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    public class Historiales : Impresiones, Cotizaciones
    {
        public void Cotizar() {
            Console.WriteLine("Cotizacion");
        }

        public void ImprimirCotizacion() {
            Console.WriteLine("ImprimirCotizacion");
        }

        public void ImprimirHistorial() {
            Console.WriteLine("ImprimirHistorial");
        }
    }
}
