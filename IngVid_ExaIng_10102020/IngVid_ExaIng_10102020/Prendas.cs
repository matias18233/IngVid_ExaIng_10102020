using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngVid_ExaIng_10102020 {
    public class Prendas {

        List<Prendas> ListaPrendas = new List<Prendas>();

        public Prendas() {

        }
        
        public Prendas(string cadena) {
            CargarPrendas(0, "Camisas Cool Night", 100, 200, "Manga corta con cuello mao");
            CargarPrendas(2, "Camisas Verano 98", 100, 300, "Manga corta con cuello normal");
            CargarPrendas(2, "Camisas rojas a cuadros", 100, 150, "Manga larga con cuello mao");
            CargarPrendas(3, "Camisas formal", 100, 350, "Manga larga con cuello normal");
            CargarPrendas(4, "Pantalón estilo moderno", 200, 1500, "chupines");
            CargarPrendas(5, "Pantalón trabajador", 200, 500, "normales");
        }

        public int Id;
        public string Nombre;
        public double Precio; // = 0.0d;
        public int Stock;
        public string TipoPrenda;

        public void CargarPrendas(int pId, string pNombre, double pPrecio, int pStock, string pTipoPrenda) {
            Prendas prenda = new Prendas();
            prenda.Id = pId;
            prenda.Nombre = pNombre;
            prenda.Precio = pPrecio;
            prenda.Stock = pStock;
            prenda.TipoPrenda = pTipoPrenda;
            
            ListaPrendas.Add(prenda);
        }

        public void MostrarPrendas() {
            Console.WriteLine("Listado de prendas:");
            foreach (Prendas item in ListaPrendas) {
                Console.WriteLine("ID: " + item.Id + " Nombre: " + item.Nombre + " Precio: " + item.Precio + " Stock: " + item.Stock + " TipoPrenda: " + item.TipoPrenda);
            }
            Console.WriteLine("");
        }
    }
}
