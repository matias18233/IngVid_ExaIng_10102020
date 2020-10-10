using System;

namespace IngVid_ExaIng_10102020
{
    public class Tiendas
    {

        Prendas Prenda;

        public Tiendas()
        {
            Nombre = "Prendas Moda";
            Direccion = "Payró 1941, Godoy Cruz";

            Prenda = new Prendas("cargar");
        }

        public string Nombre;
        public string Direccion;

        public void MostrarTienda()
        {
            Console.WriteLine("Información de la tienda:");
            Console.WriteLine("Nombre: {0}", Nombre);
            Console.WriteLine("Dirección: {0}", Direccion);
            Console.WriteLine("");
        }

        public void MostrarListadoPrendas()
        {
            Prenda.MostrarPrendas();
        }

        public string MostrarPrenda(int posicion)
        {
            string cadena;
            cadena = Prenda.ObtenerElemento(posicion);
            return cadena;
        }

        internal string ObtenerTipoPrendas(int posicion)
        {
            string cadena;
            cadena = Prenda.ObtenerTipoPrendas(posicion);
            return cadena;
        }

        internal string ObtenerTipoPrendas2(int posicion)
        {
            string cadena;
            cadena = Prenda.ObtenerTipoPrendas(posicion);
            return cadena;
        }
    }
}
