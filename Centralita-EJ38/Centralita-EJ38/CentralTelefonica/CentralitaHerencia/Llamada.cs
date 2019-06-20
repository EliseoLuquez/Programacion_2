using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        /// <summary>
        /// 
        /// </summary>
        public float Duracion
        {
            get { return duracion; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string NroDestino
        {
            get { return nroDestino; }
        }


        /// <summary>
        /// 
        /// </summary>
        public string NroOrigen
        {
            get { return nroOrigen; }
        }

		/// <summary>
		/// 
		/// </summary>
        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="duracion"></param>
        /// <param name="nroDestino"></param>
        /// <param name="nroOrigen"></param>
        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

		public abstract float CostoLlamada{ get ;}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            string aux = Convert.ToString(this.duracion);
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nDuracion: {0} \nNro Destino: {1} \nNro Origen: {2}", aux, this.nroDestino,
                this.nroOrigen);

            return sb.ToString();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="llamada1"></param>
        /// <param name="llamada2"></param>
        /// <returns></returns>
        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
			int orden;
			orden = llamada1.duracion > llamada2.duracion ? 1 : llamada1.duracion < llamada2.duracion ? -1 : 0;
			return orden;
		}

		public static bool operator ==(Llamada llamada1, Llamada llamada2)
		{
			if (llamada1.GetType() == llamada2.GetType() && llamada1.NroOrigen == llamada2.NroOrigen && 
				llamada1.NroDestino == llamada2.nroDestino)
			{
				return true;
			}
			return false;

		}


		public static bool operator !=(Llamada llamada1, Llamada llamada2)
		{
			return !(llamada1 == llamada2);
		}


	}
}

