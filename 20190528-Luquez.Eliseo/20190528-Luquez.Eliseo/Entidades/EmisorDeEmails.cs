using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class EmisorDeEmails : Emisor
    {
        private string email;
        private bool enviado;

        public EmisorDeEmails(string mensaje, EProducto producto, string email) : base(mensaje, producto)
        {
            this.email = email;
            this.enviado = false;
        }

        public static explicit operator string(EmisorDeEmails emisor)
        {
            StringBuilder sb = new StringBuilder(emisor.ToString());
            sb.AppendFormat("\n.{0}", emisor.email);
            
            return sb.ToString();
        }

        public override string EnviarMensajes()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append((string)this);
            sb.AppendLine("\n.Se envia el mensaje");
            //this.enviado = true;
           // sb.AppendLine("\n.Error, el mensaje ya fue enviado");

            return sb.ToString();

        }



    }
}
