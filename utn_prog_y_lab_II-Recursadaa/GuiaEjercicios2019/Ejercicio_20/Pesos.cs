using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Pesos
    {
        private double cantidad;
        private static double cotizRespectoDolar = 1;

        private Pesos()
        {

        }

        public Pesos(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Pesos(double cantidad, double cotizacion) : this(cantidad)
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

        public static explicit operator Dolar(Pesos p)
        {
            return new Dolar(p.GetCantidad() * Dolar.GetCotizacion());
        }

        public static explicit operator Euro(Pesos p)
        {
            return new Euro(p.GetCantidad() * Pesos.GetCotizacion());
        }

        public static bool operator ==(Pesos p1, Pesos p2)
        {
            return (p1.cantidad == p2.cantidad);
        }

        public static bool operator !=(Pesos p1, Pesos p2)
        {
            return !(p1.cantidad == p2.cantidad);
        }

        public static Pesos operator +(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad + (d.GetCantidad() * Dolar.GetCotizacion()));
        }

        public static Pesos operator +(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad + (e.GetCantidad() / Euro.GetCotizacion()));
        }

        public static Pesos operator -(Pesos p, Dolar d)
        {
            return new Pesos(p.cantidad - (d.GetCantidad() * Dolar.GetCotizacion()));
        }

        public static Pesos operator -(Pesos p, Euro e)
        {
            return new Pesos(p.cantidad - (e.GetCantidad() / Euro.GetCotizacion()));
        }
    }
}

