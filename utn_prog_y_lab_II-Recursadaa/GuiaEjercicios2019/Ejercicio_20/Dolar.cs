using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1;

        private Dolar()
        {

        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad; }

        public Dolar(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Euro(Dolar d)
        {
            return new Euro(d.GetCantidad() / Euro.GetCotizacion());
        }

        public static explicit operator Pesos(Dolar d)
        {
            return new Pesos(d.GetCantidad() * Pesos.GetCotizacion());
        }

        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        public static bool operator ==(Dolar d, Euro e)
        {
            return (d.cantidad == (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static bool operator ==(Dolar d, Pesos p)
        {
            return (d.cantidad == (p.GetCantidad() / Pesos.GetCotizacion()));
        }

        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator !=(Dolar d, Pesos p)
        {
            return !(d == p);
        }

        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return (d1.cantidad == d2.cantidad);
        }

        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1.cantidad == d2.cantidad);
        }

        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static Dolar operator +(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad + (p.GetCantidad() / Pesos.GetCotizacion()));
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - (e.GetCantidad() * Euro.GetCotizacion()));
        }

        public static Dolar operator -(Dolar d, Pesos p)
        {
            return new Dolar(d.cantidad - (p.GetCantidad() / Pesos.GetCotizacion()));
        }
    }
}
