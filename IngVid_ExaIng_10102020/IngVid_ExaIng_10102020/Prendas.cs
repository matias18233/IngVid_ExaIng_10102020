using System;
using System.Collections.Generic;

namespace IngVid_ExaIng_10102020
{
    public class Prendas
    {

        List<Prendas> ListaPrendas = new List<Prendas>();

        public Prendas()
        {

        }

        public Prendas(string cadena)
        {
            CargarPrendas(0, "Camisas Cool Night", 100, 200, "Manga corta", "cuello mao");
            CargarPrendas(1, "Camisas Verano 98", 100, 300, "Manga corta", "cuello normal");
            CargarPrendas(2, "Camisas rojas a cuadros", 100, 150, "Manga larga", "cuello mao");
            CargarPrendas(3, "Camisas formal", 100, 350, "Manga larga", "cuello normal");
            CargarPrendas(4, "Pantalón estilo moderno", 200, 1500, "pantalon", "chupines");
            CargarPrendas(5, "Pantalón trabajador", 200, 500, "pantalon", "normales");
        }

        public int Id;
        public string Nombre;
        public double Precio; // = 0.0d;
        public int Stock;
        public string TipoPrenda;
        public string TipoPrenda2;

        public void CargarPrendas(int pId, string pNombre, double pPrecio, int pStock, string pTipoPrenda, string pTipoPrenda2)
        {
            Prendas prenda = new Prendas();
            prenda.Id = pId;
            prenda.Nombre = pNombre;
            prenda.Precio = pPrecio;
            prenda.Stock = pStock;
            prenda.TipoPrenda = pTipoPrenda;
            prenda.TipoPrenda2 = pTipoPrenda2;

            ListaPrendas.Add(prenda);
        }

        public void MostrarPrendas()
        {
            Console.WriteLine("Listado de prendas:");
            foreach (Prendas item in ListaPrendas)
            {
                Console.WriteLine("ID: " + item.Id + " Nombre: " + item.Nombre + " Precio: " + item.Precio + " Stock: " + item.Stock + " TipoPrenda: " + item.TipoPrenda + " TipoPrenda2: " + item.TipoPrenda2);
            }
            Console.WriteLine("");
        }

        public string ObtenerElemento(int elemento)
        {
            string cadena = "";
            foreach (Prendas item in ListaPrendas)
            {
                if (item.Id == elemento)
                {
                    cadena = "ID: " + item.Id + " Nombre: " + item.Nombre + " Precio: " + item.Precio + " Stock: " + item.Stock + " TipoPrenda: " + item.TipoPrenda + " TipoPrenda2: " + item.TipoPrenda2;
                }
            }
            return cadena;
        }

        public string ObtenerTipoPrendas(int elemento) {
            string cadena = "";
            foreach (Prendas item in ListaPrendas)
            {
                if (item.Id == elemento) {
                    cadena = item.TipoPrenda;
                }
            }
            return cadena;
        }
        public string ObtenerTipoPrendas2(int elemento)
        {
            string cadena = "";
            foreach (Prendas item in ListaPrendas)
            {
                if (item.Id == elemento)
                {
                    cadena = item.TipoPrenda2;
                }
            }
            return cadena;
        }
    }
}
