using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class ManejadorDeEmisores
    {
        private List<Emisor> emisores;
        private string region;

        private ManejadorDeEmisores()
        {
            emisores = new List<Emisor>();
        }

        public ManejadorDeEmisores(string region) : this()
        {
            this.region = region;
        }

        public static bool operator ==(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return manejador.emisores.Contains(emisor);
        }

        public static bool operator !=(ManejadorDeEmisores manejador, Emisor emisor)
        {
            return !(manejador == emisor);
        }

        public static bool operator +(ManejadorDeEmisores manejador, Emisor emisor)
        {
            if (!(manejador == emisor))
            {
                manejador.emisores.Add(emisor);
                return true;
            }
            return false;
        }

        public static bool operator -(ManejadorDeEmisores manejador, Emisor emisor)
        {
            foreach (Emisor emisorAux in manejador.emisores)
            {
                if (emisor == emisorAux)
                {
                    return manejador.emisores.Remove(emisorAux);   
                }
            }
            return false;
        }

        public string EnviarMensajes()
        {
            StringBuilder sb = new StringBuilder(ToString());
            foreach (Emisor emisor in emisores)
            {
				if (emisor is EmisorDeEmails)
				{
					sb.Append("\n" + emisor.EnviarMensajes());
				}
				else if (emisor is EmisorDeWhatsapp)
				{
					sb.Append("\n" + emisor.EnviarMensajes());
				}
			}

            return sb.ToString();
        }

		/// <summary>
		/// retorna el nombre de la región y la información de todos los emisores
		/// </summary>
		/// <returns></returns>
		public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nRegion: {0}\n", this.region);

			return sb.ToString();
        }


    }
}
