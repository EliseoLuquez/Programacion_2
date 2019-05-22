using System;
using System.Collections.Generic;
using System.Text;


namespace Contable
{
    public class Contabilidad<T, U> where T : Documento where U : Documento, new()
    {
        List<T> egresos;
        List<U> ingresos;

        public Contabilidad()
        {
            this.ingresos = new List<U>();
            this.egresos = new List<T>();
        }

        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, T egreso)
        {
            c.egresos.Add(egreso);
            return c;
        }


        public static Contabilidad<T, U> operator +(Contabilidad<T, U> c, U ingreso)
        {
            c.ingresos.Add(ingreso);
            return c;
        }
    }
}
