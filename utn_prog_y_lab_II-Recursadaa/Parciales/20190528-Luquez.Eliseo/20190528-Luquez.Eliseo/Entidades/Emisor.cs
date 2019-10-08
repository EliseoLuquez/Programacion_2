using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Emisor
    {
        private string mensaje;
        private EProducto producto;
        
        public enum EProducto
        {
            SQLDatabase,
            MonitoringApp,
            AppHosting
        }

        protected Emisor(string mensaje, EProducto producto)
        {
            this.mensaje = mensaje;
            this.producto = producto;
        }

        public abstract string EnviarMensajes();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\n.{0} \n.{1}", producto, mensaje);

            return sb.ToString();
        }


        public static bool operator ==(Emisor e1, Emisor e2)
        {
            return (e1.producto == e2.producto && e1.mensaje == e2.mensaje ? true : false);
        }

        public static bool operator !=(Emisor e1, Emisor e2)
        {
            return (!(e1 == e2));
        }







    }
}
