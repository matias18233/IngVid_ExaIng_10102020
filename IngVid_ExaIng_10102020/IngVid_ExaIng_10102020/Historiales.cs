using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    public class Historiales : Impresiones, Cotizaciones {

        Historiales Historial;
        Random aleatorio;
        List<Historiales> historial;
        
        public int Id;
        public string FechaHora;
        public int CodVendedor;
        public int Prenda;
        public int CantPrenda;
        public double Total;

        public Historiales() {

        }

        public Historiales(string cadena) {
            Historial = new Historiales();
            aleatorio = new Random();
            historial = new List<Historiales>();
        }

        public void Cotizar(Vendedores Vendedor, Tiendas Tienda) {
            Console.WriteLine("Seleccione una prenda para cotizar");

            for (int i = 0; i < 6; i++) {
                Console.WriteLine(i + " . " + Tienda.MostrarPrenda(i));
            }
            string idPrenda = "";
            idPrenda = Console.ReadLine();
            // Console.WriteLine("Seleccionaste la opción: {0}", idPrenda);

            Console.WriteLine("Ingrese una cantidad a cotizar:");
            string cantidad = "";
            cantidad = Console.ReadLine();

            string fecha_actual;
            fecha_actual = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss");

            double precio = 0;

            Historial.AlmacenarHistoria(aleatorio.Next(), fecha_actual, Vendedor.CodVendedor, idPrenda, cantidad, precio);
            

        }

        public void ImprimirCotizacion() {
            Console.WriteLine("ImprimirCotizacion");
        }

        public void ImprimirHistorial() {
            Console.WriteLine("ImprimirHistorial");
        }

        public void AlmacenarHistoria(int pId, string pFecha, int pCodVendedor, string pPrenda, string pCantidad, double pPrecio) {
            Historiales Historial_aux = new Historiales();
            Historial_aux.Id = pId;
            Historial_aux.FechaHora = pFecha;
            Historial_aux.CodVendedor = pCodVendedor;
            Historial_aux.Prenda = Convert.ToInt32(pPrenda);
            Historial_aux.CantPrenda = Convert.ToInt32(pCantidad);
            Historial_aux.Total = pPrecio;


        }
    }
}
