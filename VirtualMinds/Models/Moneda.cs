using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VirtualMinds.Models
{
    public enum TipoMoneda
    {
        Dolar = 0,
        Peso =1,
        Real = 2
    }
    public class Moneda
    {
        public Moneda(string[] Datos)
        {
            Compra = Convert.ToDouble(Datos[0]);
            Venta = Convert.ToDouble(Datos[1]);
            Actualizado = Datos[2];
        }

        public Double Compra { get; set; }
        public Double Venta { get; set; }
        public string Actualizado { get; set; }
    }
}