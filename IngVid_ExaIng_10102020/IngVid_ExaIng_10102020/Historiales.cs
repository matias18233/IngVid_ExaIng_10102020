﻿using System;
using System.Collections.Generic;

namespace IngVid_ExaIng_10102020
{
    public class Historiales : Impresiones, Cotizaciones
    {

        Historiales Historial;
        Random aleatorio = new Random();
        List<Historiales> ListaHistorial = new List<Historiales>();

        public int Id;
        public string FechaHora;
        public int CodVendedor;
        public int Prenda;
        public int CantPrenda;
        public double Total;

        public Historiales()
        {

        }

        public Historiales(string cadena)
        {
            Historial = new Historiales();
        }

        public void Cotizar(Vendedores Vendedor, Tiendas Tienda)
        {
            Console.WriteLine("Seleccione una prenda para cotizar");

            for (int i = 0; i < 6; i++)
            {
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

            // INICIO: SE CALCULA LA LÓGICA DEL COSTO
            double precio = 0;

            string tipo = Tienda.ObtenerTipoPrendas(Convert.ToInt32(idPrenda));
            string tipo2 = Tienda.ObtenerTipoPrendas2(Convert.ToInt32(idPrenda));
            switch (tipo) {
                case "Manga corta":
                    if (tipo2 == "cuello mao") {
                        // calcular - 10%
                        // calcular + 3%
                    } else {
                        // calcular - 10%
                    }
                    break;
                case "Manga larga":
                    if (tipo2 == "cuello mao") {
                        // calcular + 3%
                    } else {

                    }
                    break;
                case "pantalon":
                    if (tipo2 == "chupines") {
                        // calcular - 10%
                    }
                    break;
                default:
                    break;
            }
            // FIN: SE CALCULA LA LÓGICA DEL COSTO

            Historial.AlmacenarHistoria(aleatorio.Next(), fecha_actual, Vendedor.CodVendedor, idPrenda, cantidad, precio);
        }

        public void ImprimirCotizacion()
        {
            Console.WriteLine("ImprimirCotizacion");
        }

        public void ImprimirHistorial()
        {
            Console.WriteLine("ImprimirHistorial");
        }

        public void AlmacenarHistoria(int pId, string pFecha, int pCodVendedor, string pPrenda, string pCantidad, double pPrecio)
        {
            Historiales Historial_aux = new Historiales();
            Historial_aux.Id = pId;
            Console.WriteLine(pId);
            Historial_aux.FechaHora = pFecha;
            Console.WriteLine(pFecha);
            Historial_aux.CodVendedor = pCodVendedor;
            Console.WriteLine(pCodVendedor);
            Historial_aux.Prenda = Convert.ToInt32(pPrenda);
            Console.WriteLine(pPrenda);
            Historial_aux.CantPrenda = Convert.ToInt32(pCantidad);
            Console.WriteLine(pCantidad);
            Historial_aux.Total = pPrecio;
            Console.WriteLine(pPrecio);

            ListaHistorial.Add(Historial_aux);
            // Console.WriteLine("" + ListaHistorial.Count);
        }

        public void MostrarHistorial() {

            Console.WriteLine("Listado de cotizaciones:" + ListaHistorial.Count);
            /*
            foreach (Historiales item in ListaHistorial) {
                Console.WriteLine("Id: " + item.Id + " Fecha y hora: " + item.FechaHora + " Cód. vendedor: " + item.CodVendedor + " Prensa: " + item.Prenda + " Cantidad: " + item.CantPrenda + " Total: " + item.Total);
            }
            */
            Console.WriteLine("");
        }
    }
}
