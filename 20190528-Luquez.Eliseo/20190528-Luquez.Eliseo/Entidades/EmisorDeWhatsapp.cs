using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EmisorDeWhatsapp : Emisor
    {
        private bool numeroCargado;
        private int numeroTelefono;

        public int NumeroTelefono
        {
            get
            {
				return numeroTelefono;
            }
            set
			{
				if (value > 1500000000 || value < 1599999999)
				{
					numeroCargado = true;
					numeroTelefono = value;
				}
				else
				{
					numeroCargado = false;	
				}
				numeroTelefono = value;
			}
        }

        public EmisorDeWhatsapp(string mensaje, EProducto producto) : base(mensaje, producto)
        {
        }

        public static explicit operator string(EmisorDeWhatsapp emisor)
        {
            StringBuilder sb = new StringBuilder(emisor.ToString());
            if (emisor.numeroCargado)
            {
                sb.AppendFormat("\n.{0}", emisor.NumeroTelefono);
            }
            else
            {
                sb.Append("\n.No cargado");        
            }
            return sb.ToString();


        }

        public override string EnviarMensajes()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            if (numeroCargado)
            {
                sb.Append("\n.Enviando Mensaje");
            }
            else
            {
                sb.Append("\n.No se pudo Enviar el Mensaje");
            }
            return sb.ToString();
        }

    }
}
