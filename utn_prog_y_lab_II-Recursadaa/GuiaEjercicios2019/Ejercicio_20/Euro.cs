using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1;

        private Euro()
        {

        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizacion) : this(cantidad)
        {
            cotizRespectoDolar = cotizacion;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return cotizRespectoDolar;
        }

        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Pesos(Euro e)
        {
            return new Pesos(e.GetCantidad() * Pesos.GetCotizacion());
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            return (e1.cantidad == e2.cantidad);
        }

        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1.cantidad == e2.cantidad);
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.cantidad + (d.GetCantidad() * Dolar.GetCotizacion()));
        }

        public static Euro operator +(Euro e, Pesos p)
        {
            return new Euro(e.cantidad + (p.GetCantidad() / Pesos.GetCotizacion()));
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.cantidad - (d.GetCantidad() * Dolar.GetCotizacion()));
        }

        public static Euro operator -(Euro e, Pesos p)
        {
            return new Euro(e.cantidad - (p.GetCantidad() / Pesos.GetCotizacion()));
        }




    }
}
